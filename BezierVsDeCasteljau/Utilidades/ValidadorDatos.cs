using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BezierVsDeCasteljau.Modelos;

namespace BezierVsDeCasteljau.Utilidades
{
    public class ValidadorDatos
    {
        // Validar una coordenada.
        public bool ValidarCoordenada(string valor, out double resultado)
        {
            resultado = 0;

            if (string.IsNullOrWhiteSpace(valor))
            {
                return false;
            }

            return double.TryParse(
                valor.Replace(',', '.'),
                System.Globalization.NumberStyles.Float,
                System.Globalization.CultureInfo.InvariantCulture,
                out resultado
            ) && !double.IsNaN(resultado)
              && !double.IsInfinity(resultado);
        }

        // Validar la cantidad de puntos de control.
        public bool ValidarCantidadPuntos(int cantidad)
        {
            return cantidad >= 2 && cantidad <= 4;
        }

        // Validar que todos los puntos tengan coordenadas válidas.
        public bool ValidarPuntos(List<Punto2D> puntos)
        {
            if (puntos == null || !ValidarCantidadPuntos(puntos.Count))
            {
                return false;
            }

            foreach (Punto2D punto in puntos)
            {
                if (punto == null ||
                    double.IsNaN(punto.X) ||
                    double.IsNaN(punto.Y) ||
                    double.IsInfinity(punto.X) ||
                    double.IsInfinity(punto.Y))
                {
                    return false;
                }
            }

            return true;
        }

        // Validar la cantidad de muestras.
        public bool ValidarMuestras(int muestras)
        {
            return muestras >= 2 && muestras <= 10000;
        }

        // Validar un valor de t.
        public bool ValidarParametro(double t)
        {
            return !double.IsNaN(t) &&
                   !double.IsInfinity(t) &&
                   t >= 0 && t <= 1;
        }
    }
}

