using System.Collections.Generic;
using System.Drawing;

namespace BezierVsDeCasteljau.Algoritmos
{
    public class NivelInterpolacion
    {
        public int Nivel { get; set; }
        public float T { get; set; }
        public List<PointF> Puntos { get; set; }

        public NivelInterpolacion(int nivel, float t, List<PointF> puntos)
        {
            Nivel = nivel;
            T = t;
            Puntos = new List<PointF>(puntos);
        }

        public void Dibujar(Graphics g, Color color)
        {
            if (g == null || Puntos == null || Puntos.Count == 0)
                return;

            using (Pen pen = new Pen(color, 1.5f))
            using (Brush brush = new SolidBrush(color))
            {
                if (Puntos.Count > 1)
                {
                    g.DrawLines(pen, Puntos.ToArray());
                }

                foreach (PointF p in Puntos)
                {
                    g.FillEllipse(brush, p.X - 3.5f, p.Y - 3.5f, 7f, 7f);
                }
            }
        }
    }
}
