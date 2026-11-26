using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BezierVsDeCasteljau.Modelos;

namespace BezierVsDeCasteljau.Controladores
{
    public class ComparadorAlgoritmos
    {
        // Comparar los puntos generados por ambos algoritmos.
        public ResultadoComparacion Comparar(
            List<Punto2D> puntosDirecto,
            List<Punto2D> puntosDeCasteljau)
        {
            if (puntosDirecto == null || puntosDeCasteljau == null)
            {
                throw new ArgumentException(
                    "Las listas de puntos no pueden ser nulas.");
            }

            if (puntosDirecto.Count == 0 ||
                puntosDirecto.Count != puntosDeCasteljau.Count)
            {
                throw new ArgumentException(
                    "Ambos algoritmos deben generar la misma cantidad de puntos.");
            }

            ResultadoComparacion resultado =
                new ResultadoComparacion();

            double sumaErrores = 0;
            double errorMaximo = 0;

            for (int i = 0; i < puntosDirecto.Count; i++)
            {
                Punto2D directo = puntosDirecto[i];
                Punto2D casteljau = puntosDeCasteljau[i];

                if (directo == null || casteljau == null)
                {
                    throw new ArgumentException(
                        "Los puntos no pueden ser nulos.");
                }

                // Diferencias absolutas entre coordenadas.
                double diferenciaX =
                    Math.Abs(directo.X - casteljau.X);

                double diferenciaY =
                    Math.Abs(directo.Y - casteljau.Y);

                // Distancia euclidiana entre ambos resultados.
                double error = Math.Sqrt(
                    Math.Pow(diferenciaX, 2) +
                    Math.Pow(diferenciaY, 2)
                );

                resultado.DiferenciasX.Add(diferenciaX);
                resultado.DiferenciasY.Add(diferenciaY);
                resultado.ErroresPuntos.Add(error);

                sumaErrores += error;

                if (error > errorMaximo)
                {
                    errorMaximo = error;
                }
            }

            // Calcular error promedio y máximo.
            resultado.ErrorPromedio =
                sumaErrores / puntosDirecto.Count;

            resultado.ErrorMaximo = errorMaximo;

            return resultado;
        }
    }
}
