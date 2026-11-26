using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BezierVsDeCasteljau.Modelos;

namespace BezierVsDeCasteljau.Controladores
{
    public class GestorPuntos
    {
        private List<Punto2D> puntosControl;

        public GestorPuntos()
        {
            puntosControl = new List<Punto2D>();
        }

        // Devuelve la cantidad de puntos de control.
        public int CantidadPuntos
        {
            get { return puntosControl.Count; }
        }

        // Agrega un nuevo punto de control.
        public void AgregarPunto(double x, double y)
        {
            if (puntosControl.Count >= 4)
            {
                throw new InvalidOperationException(
                    "Una curva puede tener máximo 4 puntos de control.");
            }

            Punto2D nuevoPunto = new Punto2D(x, y);
            puntosControl.Add(nuevoPunto);
        }

        // Elimina un punto según su posición en la lista.
        public bool EliminarPunto(int indice)
        {
            if (indice < 0 || indice >= puntosControl.Count)
            {
                return false;
            }

            puntosControl.RemoveAt(indice);
            return true;
        }

        // Modifica las coordenadas de un punto.
        public bool ModificarPunto(int indice, double x, double y)
        {
            if (indice < 0 || indice >= puntosControl.Count)
            {
                return false;
            }

            puntosControl[indice].X = x;
            puntosControl[indice].Y = y;

            return true;
        }

        // Obtiene una copia de los puntos de control.
        public List<Punto2D> ObtenerPuntosControl()
        {
            return new List<Punto2D>(puntosControl);
        }

        // Elimina todos los puntos.
        public void LimpiarPuntos()
        {
            puntosControl.Clear();
        }

        // Construye una curva con los puntos actuales.
        public CurvaBezier CrearCurva()
        {
            if (puntosControl.Count < 2 || puntosControl.Count > 4)
            {
                throw new InvalidOperationException(
                    "Se necesitan entre 2 y 4 puntos de control.");
            }

            return new CurvaBezier(puntosControl);
        }
    }
}
