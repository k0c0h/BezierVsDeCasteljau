using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BezierVsDeCasteljau.Utilidades
{
    public class GeneradorMuestras
    {
        // Generar valores de t desde 0 hasta 1.
        public List<double> GenerarMuestras(int cantidad)
        {
            if (cantidad < 2 || cantidad > 10000)
            {
                throw new ArgumentException(
                    "La cantidad de muestras debe estar entre 2 y 10000.");
            }

            List<double> muestras = new List<double>();

            for (int i = 0; i < cantidad; i++)
            {
                double t = (double)i / (cantidad - 1);
                muestras.Add(t);
            }

            return muestras;
        }
    }
}
