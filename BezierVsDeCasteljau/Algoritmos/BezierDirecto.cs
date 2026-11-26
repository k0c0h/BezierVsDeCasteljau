using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BezierVsDeCasteljau.Modelos;

namespace BezierVsDeCasteljau.Algoritmos
{
    public class BezierDirecto
    {
        // Calcula un punto de la curva para un valor de t.
        public Punto2D CalcularPunto(CurvaBezier curva, double t)
        {
            if (curva == null || curva.PuntosControl == null)
            {
                throw new ArgumentException("La curva no es válida.");
            }

            if (t < 0 || t > 1 || double.IsNaN(t))
            {
                throw new ArgumentOutOfRangeException(
                    nameof(t), "El valor de t debe estar entre 0 y 1.");
            }

            List<Punto2D> puntos = curva.PuntosControl;

            if (puntos.Count < 2 || puntos.Count > 4)
            {
                throw new ArgumentException(
                    "Se necesitan 2, 3 o 4 puntos de control.");
            }

            foreach (Punto2D punto in puntos)
            {
                if (punto == null)
                {
                    throw new ArgumentException(
                        "Los puntos de control no pueden ser nulos.");
                }
            }

            // Se selecciona la fórmula según la cantidad de puntos.
            if (puntos.Count == 2)
            {
                return CalcularLineal(puntos, t);
            }
            else if (puntos.Count == 3)
            {
                return CalcularCuadratica(puntos, t);
            }
            else
            {
                return CalcularCubica(puntos, t);
            }
        }

        // Bézier lineal: 2 puntos de control.
        private Punto2D CalcularLineal(List<Punto2D> p, double t)
        {
            double u = 1 - t;

            double x = u * p[0].X + t * p[1].X;
            double y = u * p[0].Y + t * p[1].Y;

            return new Punto2D(x, y);
        }

        // Bézier cuadrática: 3 puntos de control.
        private Punto2D CalcularCuadratica(List<Punto2D> p, double t)
        {
            double u = 1 - t;

            double a = u * u;
            double b = 2 * u * t;
            double c = t * t;

            double x = a * p[0].X
                     + b * p[1].X
                     + c * p[2].X;

            double y = a * p[0].Y
                     + b * p[1].Y
                     + c * p[2].Y;

            return new Punto2D(x, y);
        }

        // Bézier cúbica: 4 puntos de control.
        private Punto2D CalcularCubica(List<Punto2D> p, double t)
        {
            double u = 1 - t;

            double a = u * u * u;
            double b = 3 * u * u * t;
            double c = 3 * u * t * t;
            double d = t * t * t;

            double x = a * p[0].X
                     + b * p[1].X
                     + c * p[2].X
                     + d * p[3].X;

            double y = a * p[0].Y
                     + b * p[1].Y
                     + c * p[2].Y
                     + d * p[3].Y;

            return new Punto2D(x, y);
        }

        // Genera los puntos de la curva según las muestras.
        public List<Punto2D> GenerarCurva(CurvaBezier curva, int muestras)
        {
            if (muestras < 2)
            {
                throw new ArgumentException(
                    "La cantidad de muestras debe ser al menos 2.");
            }

            List<Punto2D> resultado = new List<Punto2D>();

            for (int i = 0; i < muestras; i++)
            {
                double t = (double)i / (muestras - 1);

                Punto2D punto = CalcularPunto(curva, t);

                resultado.Add(punto);
            }

            return resultado;
        }
    }
}
