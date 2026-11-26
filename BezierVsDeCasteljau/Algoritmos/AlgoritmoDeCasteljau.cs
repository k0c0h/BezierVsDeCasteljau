using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;

namespace BezierVsDeCasteljau.Algoritmos
{
    public class AlgoritmoDeCasteljau
    {
        public double TiempoEjecucionMs { get; private set; }

        public PointF CalcularPunto(List<PointF> puntosControl, float t)
        {
            if (puntosControl == null || puntosControl.Count == 0)
                return PointF.Empty;

            List<PointF> actual = new List<PointF>(puntosControl);

            while (actual.Count > 1)
            {
                actual = Interpolacion.InterpolarNivel(actual, t);
            }

            return actual[0];
        }

        public List<PointF> GenerarCurva(List<PointF> puntosControl, int pasos = 100)
        {
            List<PointF> curva = new List<PointF>();

            if (puntosControl == null || puntosControl.Count < 2 || pasos <= 0)
            {
                TiempoEjecucionMs = 0;
                return curva;
            }

            Stopwatch cronometro = Stopwatch.StartNew();

            for (int i = 0; i <= pasos; i++)
            {
                float t = (float)i / pasos;
                curva.Add(CalcularPunto(puntosControl, t));
            }

            cronometro.Stop();
            TiempoEjecucionMs = cronometro.Elapsed.TotalMilliseconds;

            return curva;
        }

        public List<NivelInterpolacion> ObtenerNivelesPasoAPaso(List<PointF> puntosControl, float t)
        {
            List<NivelInterpolacion> niveles = new List<NivelInterpolacion>();

            if (puntosControl == null || puntosControl.Count == 0)
                return niveles;

            List<PointF> actual = new List<PointF>(puntosControl);
            int numeroNivel = 0;

            niveles.Add(new NivelInterpolacion(numeroNivel, t, actual));

            while (actual.Count > 1)
            {
                numeroNivel++;
                actual = Interpolacion.InterpolarNivel(actual, t);
                niveles.Add(new NivelInterpolacion(numeroNivel, t, actual));
            }

            return niveles;
        }

        public void VisualizarNiveles(Graphics g, List<NivelInterpolacion> niveles)
        {
            if (g == null || niveles == null)
                return;

            Color[] paleta =
            {
                Color.Gray,
                Color.DodgerBlue,
                Color.MediumSeaGreen,
                Color.Orange,
                Color.Purple,
                Color.Red
            };

            for (int i = 0; i < niveles.Count; i++)
            {
                Color color = paleta[Math.Min(i, paleta.Length - 1)];
                niveles[i].Dibujar(g, color);
            }
        }
    }
}
