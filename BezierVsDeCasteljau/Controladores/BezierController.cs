using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BezierVsDeCasteljau.Modelos;
using BezierVsDeCasteljau.Algoritmos;
using BezierVsDeCasteljau.Utilidades;

namespace BezierVsDeCasteljau.Controladores
{
    public class BezierController
    {
        private GestorPuntos gestorPuntos;
        private BezierDirecto algoritmoDirecto;
        private GeneradorMuestras generadorMuestras;
        private ComparadorAlgoritmos comparador;
        private MedidorRendimiento medidor;

        public double TiempoPromedioDirecto { get; private set; }
        public double TiempoPromedioCasteljau { get; private set; }

        public BezierController()
        {
            gestorPuntos = new GestorPuntos();
            algoritmoDirecto = new BezierDirecto();
            generadorMuestras = new GeneradorMuestras();
            comparador = new ComparadorAlgoritmos();
            medidor = new MedidorRendimiento();
        }

        // Permite acceder al gestor de puntos.
        public GestorPuntos GestorPuntos
        {
            get { return gestorPuntos; }
        }

        // Crear una curva con los puntos registrados.
        public CurvaBezier CrearCurva()
        {
            return gestorPuntos.CrearCurva();
        }

        // Generar la curva utilizando Bézier directo.
        public List<Punto2D> CalcularBezierDirecto(
            CurvaBezier curva, int cantidadMuestras)
        {
            if (curva == null)
            {
                throw new ArgumentNullException(nameof(curva));
            }

            if (!new ValidadorDatos().ValidarMuestras(cantidadMuestras))
            {
                throw new ArgumentException(
                    "La cantidad de muestras no es válida.");
            }

            return algoritmoDirecto.GenerarCurva(
                curva, cantidadMuestras);
        }

        // Obtener los valores de t que se utilizarán en los cálculos.
        public List<double> ObtenerMuestras(int cantidadMuestras)
        {
            return generadorMuestras.GenerarMuestras(cantidadMuestras);
        }

        // Ejecutar y comparar ambos algoritmos.
        // El segundo algoritmo se recibe como delegado para conectarlo
        // cuando esté disponible la implementación de De Casteljau.
        public ResultadoComparacion EjecutarComparacion(
            CurvaBezier curva,
            int cantidadMuestras,
            Func<CurvaBezier, int, List<Punto2D>> calcularCasteljau,
            int repeticiones = 10)
        {
            if (curva == null)
            {
                throw new ArgumentNullException(nameof(curva));
            }

            if (calcularCasteljau == null)
            {
                throw new ArgumentNullException(nameof(calcularCasteljau));
            }

            ValidadorDatos validador = new ValidadorDatos();

            if (!validador.ValidarPuntos(curva.PuntosControl))
            {
                throw new ArgumentException(
                    "Los puntos de control no son válidos.");
            }

            if (!validador.ValidarMuestras(cantidadMuestras))
            {
                throw new ArgumentException(
                    "La cantidad de muestras no es válida.");
            }

            if (repeticiones < 10)
            {
                throw new ArgumentException(
                    "Se necesitan al menos 10 ejecuciones.");
            }

            // Medir Bézier directo.
            List<double> tiemposDirecto = medidor.MedirTiempos(
                () => algoritmoDirecto.GenerarCurva(
                    curva, cantidadMuestras),
                repeticiones);

            TiempoPromedioDirecto =
                medidor.CalcularPromedio(tiemposDirecto);

            // Medir De Casteljau.
            List<double> tiemposCasteljau = medidor.MedirTiempos(
                () => calcularCasteljau(
                    curva, cantidadMuestras),
                repeticiones);

            TiempoPromedioCasteljau =
                medidor.CalcularPromedio(tiemposCasteljau);

            // Obtener los puntos de ambos algoritmos para compararlos.
            List<Punto2D> puntosDirectos =
                algoritmoDirecto.GenerarCurva(
                    curva, cantidadMuestras);

            List<Punto2D> puntosCasteljau =
                calcularCasteljau(curva, cantidadMuestras);

            // Comparar los resultados numéricos.
            return comparador.Comparar(
                puntosDirectos, puntosCasteljau);
        }
    }
}
