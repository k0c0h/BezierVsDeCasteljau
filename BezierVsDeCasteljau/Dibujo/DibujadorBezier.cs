using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using BezierVsDeCasteljau.Modelos;

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

using BezierVsDeCasteljau.Modelos;
using BezierVsDeCasteljau.Algoritmos;

namespace BezierVsDeCasteljau.Dibujo
{
    public class DibujadorBezier
    {
        private const float Margen = 35;

        public static readonly Color ColorCurvaDirecta = Color.FromArgb(224, 124, 174);
        public static readonly Color ColorCurvaCasteljau = Color.FromArgb(145, 116, 190);
        public static readonly Color ColorPoligonoControl = Color.FromArgb(240, 158, 103);

        private readonly Color[] coloresNiveles =
        {
            Color.FromArgb(180, 170, 190),
            Color.FromArgb(194, 149, 204),
            Color.FromArgb(137, 190, 177),
            Color.FromArgb(244, 177, 128),
            Color.FromArgb(183, 145, 211),
            Color.FromArgb(224, 135, 164)
        };

        public void Dibujar(
            Graphics g,
            int ancho,
            int alto,
            List<Punto2D> puntosControl,
            List<Punto2D> curvaDirecta,
            List<Punto2D> curvaCasteljau,
            List<NivelInterpolacion> niveles)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(Color.FromArgb(255, 251, 253));

            if (puntosControl == null || puntosControl.Count == 0)
            {
                using (Font fuente = new Font("Segoe UI", 10))
                {
                    g.DrawString(
                        "Agregue puntos de control para visualizar la curva.",
                        fuente,
                        Brushes.Gray,
                        15,
                        15
                    );
                }

                return;
            }

            double minX = double.PositiveInfinity;
            double maxX = double.NegativeInfinity;
            double minY = double.PositiveInfinity;
            double maxY = double.NegativeInfinity;

            ObtenerLimites(
                puntosControl,
                ref minX, ref maxX, ref minY, ref maxY
            );

            ObtenerLimites(
                curvaDirecta,
                ref minX, ref maxX, ref minY, ref maxY
            );

            ObtenerLimites(
                curvaCasteljau,
                ref minX, ref maxX, ref minY, ref maxY
            );

            double rangoX = Math.Max(maxX - minX, 1);
            double rangoY = Math.Max(maxY - minY, 1);

            minX -= rangoX * 0.15;
            maxX += rangoX * 0.15;
            minY -= rangoY * 0.15;
            maxY += rangoY * 0.15;

            Func<double, float> convertirX = x =>
                Margen + (float)(
                    (x - minX) / (maxX - minX) *
                    (ancho - 2 * Margen)
                );

            Func<double, float> convertirY = y =>
                alto - Margen - (float)(
                    (y - minY) / (maxY - minY) *
                    (alto - 2 * Margen)
                );

            DibujarCuadricula(g, ancho, alto);

            DibujarEjes(
                g, ancho, alto,
                minX, maxX, minY, maxY,
                convertirX, convertirY
            );

            DibujarPoligonoControl(
                g, puntosControl, convertirX, convertirY
            );

            // Curvas calculadas.
            DibujarCurva(
                g, curvaDirecta,
                convertirX, convertirY,
                ColorCurvaDirecta, 3
            );

            DibujarCurva(
                g, curvaCasteljau,
                convertirX, convertirY,
                ColorCurvaCasteljau, 2
            );

            // Interpolaciones del algoritmo De Casteljau.
            DibujarNiveles(
                g, niveles,
                convertirX, convertirY
            );

            DibujarPuntosControl(
                g, puntosControl,
                convertirX, convertirY
            );
        }

        private void ObtenerLimites(
            List<Punto2D> puntos,
            ref double minX,
            ref double maxX,
            ref double minY,
            ref double maxY)
        {
            if (puntos == null)
                return;

            foreach (Punto2D punto in puntos)
            {
                if (punto == null)
                    continue;

                minX = Math.Min(minX, punto.X);
                maxX = Math.Max(maxX, punto.X);
                minY = Math.Min(minY, punto.Y);
                maxY = Math.Max(maxY, punto.Y);
            }
        }

        private void DibujarCuadricula(
            Graphics g,
            int ancho,
            int alto)
        {
            using (Pen pen = new Pen(Color.Gainsboro))
            {
                for (int i = 0; i <= 10; i++)
                {
                    float x = Margen +
                        i * (ancho - 2 * Margen) / 10f;

                    float y = Margen +
                        i * (alto - 2 * Margen) / 10f;

                    g.DrawLine(
                        pen, x, Margen,
                        x, alto - Margen
                    );

                    g.DrawLine(
                        pen, Margen, y,
                        ancho - Margen, y
                    );
                }
            }
        }

        private void DibujarEjes(
            Graphics g,
            int ancho,
            int alto,
            double minX,
            double maxX,
            double minY,
            double maxY,
            Func<double, float> convertirX,
            Func<double, float> convertirY)
        {
            using (Pen pen = new Pen(Color.DimGray, 1.5f))
            {
                if (minY <= 0 && maxY >= 0)
                {
                    float y0 = convertirY(0);

                    g.DrawLine(
                        pen, Margen, y0,
                        ancho - Margen, y0
                    );
                }

                if (minX <= 0 && maxX >= 0)
                {
                    float x0 = convertirX(0);

                    g.DrawLine(
                        pen, x0, Margen,
                        x0, alto - Margen
                    );
                }
            }
        }

        private void DibujarPoligonoControl(
            Graphics g,
            List<Punto2D> puntos,
            Func<double, float> convertirX,
            Func<double, float> convertirY)
        {
            if (puntos == null || puntos.Count < 2)
                return;

            using (Pen pen = new Pen(ColorPoligonoControl, 1.5f))
            {
                pen.DashStyle = DashStyle.Dash;

                for (int i = 0; i < puntos.Count - 1; i++)
                {
                    g.DrawLine(
                        pen,
                        convertirX(puntos[i].X),
                        convertirY(puntos[i].Y),
                        convertirX(puntos[i + 1].X),
                        convertirY(puntos[i + 1].Y)
                    );
                }
            }
        }

        private void DibujarCurva(
            Graphics g,
            List<Punto2D> puntos,
            Func<double, float> convertirX,
            Func<double, float> convertirY,
            Color color,
            float grosor)
        {
            if (puntos == null || puntos.Count < 2)
                return;

            using (Pen pen = new Pen(color, grosor))
            {
                for (int i = 0; i < puntos.Count - 1; i++)
                {
                    g.DrawLine(
                        pen,
                        convertirX(puntos[i].X),
                        convertirY(puntos[i].Y),
                        convertirX(puntos[i + 1].X),
                        convertirY(puntos[i + 1].Y)
                    );
                }
            }
        }

        private void DibujarNiveles(
            Graphics g,
            List<NivelInterpolacion> niveles,
            Func<double, float> convertirX,
            Func<double, float> convertirY)
        {
            if (niveles == null)
                return;

            using (Font fuente = new Font("Segoe UI", 8))
            {
                for (int i = 1; i < niveles.Count; i++)
                {
                    NivelInterpolacion nivel = niveles[i];

                    Color color = coloresNiveles[
                        Math.Min(i, coloresNiveles.Length - 1)
                    ];

                    using (Pen pen = new Pen(color, 2))
                    using (Brush brush = new SolidBrush(color))
                    {
                        if (nivel.Puntos.Count > 1)
                        {
                            for (int j = 0;
                                 j < nivel.Puntos.Count - 1;
                                 j++)
                            {
                                PointF p1 = nivel.Puntos[j];
                                PointF p2 = nivel.Puntos[j + 1];

                                g.DrawLine(
                                    pen,
                                    convertirX(p1.X),
                                    convertirY(p1.Y),
                                    convertirX(p2.X),
                                    convertirY(p2.Y)
                                );
                            }
                        }

                        foreach (PointF punto in nivel.Puntos)
                        {
                            float x = convertirX(punto.X);
                            float y = convertirY(punto.Y);

                            g.FillEllipse(
                                brush,
                                x - 4, y - 4, 8, 8
                            );

                            g.DrawString(
                                "L" + nivel.Nivel,
                                fuente,
                                brush,
                                x + 5,
                                y + 5
                            );
                        }
                    }
                }
            }
        }

        private void DibujarPuntosControl(
            Graphics g,
            List<Punto2D> puntos,
            Func<double, float> convertirX,
            Func<double, float> convertirY)
        {
            using (Font fuente = new Font("Segoe UI", 9))
            using (Brush brush = new SolidBrush(ColorPoligonoControl))
            {
                for (int i = 0; i < puntos.Count; i++)
                {
                    float x = convertirX(puntos[i].X);
                    float y = convertirY(puntos[i].Y);

                    g.FillEllipse(
                        brush,
                        x - 5, y - 5, 10, 10
                    );

                    g.DrawString(
                        "P" + i,
                        fuente,
                        Brushes.Black,
                        x + 7,
                        y - 18
                    );
                }
            }
        }
    }
}

