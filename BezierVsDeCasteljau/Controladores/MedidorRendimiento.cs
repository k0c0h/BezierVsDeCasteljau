using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace BezierVsDeCasteljau.Controladores
{
    public class MedidorRendimiento
    {
        // Mide el tiempo de ejecución de una operación.
        public List<double> MedirTiempos<T>(
            Func<T> operacion, int repeticiones = 10)
        {
            if (operacion == null)
            {
                throw new ArgumentNullException(nameof(operacion));
            }

            if (repeticiones < 10)
            {
                throw new ArgumentException(
                    "Se necesitan al menos 10 ejecuciones.");
            }

            List<double> tiempos = new List<double>();

            // Ejecución inicial para preparar el algoritmo.
            // Este tiempo no se incluye en las mediciones.
            operacion();

            for (int i = 0; i < repeticiones; i++)
            {
                Stopwatch cronometro = new Stopwatch();

                cronometro.Start();

                // Se ejecuta únicamente el cálculo del algoritmo.
                // No se debe realizar ningún dibujo aquí.
                operacion();

                cronometro.Stop();

                tiempos.Add(cronometro.Elapsed.TotalMilliseconds);
            }

            return tiempos;
        }

        // Calcular el tiempo promedio.
        public double CalcularPromedio(List<double> tiempos)
        {
            ValidarLista(tiempos);

            double suma = 0;

            foreach (double tiempo in tiempos)
            {
                suma += tiempo;
            }

            return suma / tiempos.Count;
        }

        // Obtener el menor tiempo registrado.
        public double ObtenerMinimo(List<double> tiempos)
        {
            ValidarLista(tiempos);

            double minimo = tiempos[0];

            foreach (double tiempo in tiempos)
            {
                if (tiempo < minimo)
                {
                    minimo = tiempo;
                }
            }

            return minimo;
        }

        // Obtener el mayor tiempo registrado.
        public double ObtenerMaximo(List<double> tiempos)
        {
            ValidarLista(tiempos);

            double maximo = tiempos[0];

            foreach (double tiempo in tiempos)
            {
                if (tiempo > maximo)
                {
                    maximo = tiempo;
                }
            }

            return maximo;
        }

        // Validar la lista de tiempos.
        private void ValidarLista(List<double> tiempos)
        {
            if (tiempos == null || tiempos.Count == 0)
            {
                throw new ArgumentException(
                    "La lista de tiempos está vacía.");
            }
        }
    }
}

