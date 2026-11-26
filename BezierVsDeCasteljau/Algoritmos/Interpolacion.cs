using System.Collections.Generic;
using System.Drawing;

namespace BezierVsDeCasteljau.Algoritmos
{
    public static class Interpolacion
    {
        public static PointF Interpolar(PointF p0, PointF p1, float t)
        {
            float x = (1 - t) * p0.X + t * p1.X;
            float y = (1 - t) * p0.Y + t * p1.Y;
            return new PointF(x, y);
        }

        public static List<PointF> InterpolarNivel(List<PointF> puntos, float t)
        {
            List<PointF> resultado = new List<PointF>();

            if (puntos == null || puntos.Count < 2)
                return resultado;

            for (int i = 0; i < puntos.Count - 1; i++)
            {
                resultado.Add(Interpolar(puntos[i], puntos[i + 1], t));
            }

            return resultado;
        }
    }
}
