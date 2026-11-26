using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using BezierVsDeCasteljau.Modelos;

namespace BezierVsDeCasteljau.Dibujo
{
    public class DibujadorBezier
    {
        private const float Margen = 35;

        public void Dibujar(
            Graphics g,
            int ancho,
            int alto,
            List<Punto2D> puntosControl,
            List<Punto2D> curvaDirecta,
            List<Punto2D> curvaCasteljau)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(Color.White);

            if (puntosControl == null || puntosControl.Count == 0)
            {
                g.DrawString(
                    "Agregue puntos de control para visualizar la curva.",
                    new Font("Segoe UI", 10),
                    Brushes.Gray,
                    15,
                    15
                );

                return;
            }

            double minX = double.PositiveInfinity;
            double maxX = double.NegativeInfinity;
            double minY = double.PositiveInfinity;
            double maxY = double.NegativeInfinity;

            // Obtener límites considerando todos los puntos.
            ObtenerLimites(puntosControl, ref minX, ref maxX, ref minY, ref maxY);
            ObtenerLimites(curvaDirecta, ref minX, ref maxX, ref minY, ref maxY);
            ObtenerLimites(curvaCasteljau, ref minX, ref maxX, ref minY, ref maxY);

            double rangoX = Math.Max(maxX - minX, 1);
            double rangoY = Math.Max(maxY - minY, 1);

            minX -= rangoX * 0.15;
            maxX += rangoX * 0.15;
            minY -= rangoY * 0.15;
            maxY += rangoY * 0.15;

            // Convertir coordenadas matemáticas a coordenadas de pantalla.
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
            DibujarEjes(g, ancho, alto, minX, maxX, minY, maxY,
                convertirX, convertirY);

            DibujarPoligonoControl(
                g, puntosControl, convertirX, convertirY);

            DibujarCurva(
                g, curvaDirecta, convertirX, convertirY,
                Color.DodgerBlue, 3);

            DibujarCurva(
                g, curvaCasteljau, convertirX, convertirY,
                Color.SeaGreen, 2);

            DibujarPuntosControl(
                g, puntosControl, convertirX, convertirY);
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

            foreach (Punto2D p in puntos)
            {
                if (p == null)
                    continue;

                minX = Math.Min(minX, p.X);
                maxX = Math.Max(maxX, p.X);
                minY = Math.Min(minY, p.Y);
                maxY = Math.Max(maxY, p.Y);
            }
        }

        private void DibujarCuadricula(
            Graphics g, int ancho, int alto)
        {
            using (Pen pen = new Pen(Color.Gainsboro))
            {
                for (int i = 0; i <= 10; i++)
                {
                    float x = Margen +
                        i * (ancho - 2 * Margen) / 10f;

                    float y = Margen +
                        i * (alto - 2 * Margen) / 10f;

                    g.DrawLine(pen, x, Margen, x, alto - Margen);
                    g.DrawLine(pen, Margen, y, ancho - Margen, y);
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
                    g.DrawLine(pen, Margen, y0, ancho - Margen, y0);
                }

                if (minX <= 0 && maxX >= 0)
                {
                    float x0 = convertirX(0);
                    g.DrawLine(pen, x0, Margen, x0, alto - Margen);
                }
            }
        }

        private void DibujarPoligonoControl(
            Graphics g,
            List<Punto2D> puntos,
            Func<double, float> convertirX,
            Func<double, float> convertirY)
        {
            if (puntos.Count < 2)
                return;

            using (Pen pen = new Pen(Color.DarkOrange, 1.5f))
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

        private void DibujarPuntosControl(
            Graphics g,
            List<Punto2D> puntos,
            Func<double, float> convertirX,
            Func<double, float> convertirY)
        {
            for (int i = 0; i < puntos.Count; i++)
            {
                float x = convertirX(puntos[i].X);
                float y = convertirY(puntos[i].Y);

                g.FillEllipse(
                    Brushes.DarkOrange,
                    x - 5, y - 5, 10, 10
                );

                g.DrawString(
                    "P" + i,
                    new Font("Segoe UI", 9),
                    Brushes.Black,
                    x + 7,
                    y - 18
                );
            }
        }
    }
}
