using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using BezierVsDeCasteljau.Modelos;
using BezierVsDeCasteljau.Controladores;
using BezierVsDeCasteljau.Dibujo;
using BezierVsDeCasteljau.Utilidades;
using BezierVsDeCasteljau.Algoritmos;

namespace BezierVsDeCasteljau.Vistas
{
    public partial class FrmBezier : Form
    {
        private BezierController controller;
        private DibujadorBezier dibujador;

        private List<Punto2D> puntosCurvaDirecta;
        private List<Punto2D> puntosCurvaCasteljau;
        private AlgoritmoDeCasteljau algoritmoDeCasteljau;
        private ComparadorAlgoritmos comparador;
        private MedidorRendimiento medidor;

        public FrmBezier()
        {
            InitializeComponent();

            controller = new BezierController();
            dibujador = new DibujadorBezier();
            algoritmoDeCasteljau = new AlgoritmoDeCasteljau();
            comparador = new ComparadorAlgoritmos();
            medidor = new MedidorRendimiento();
            ConfigurarTablaIteraciones();

            puntosCurvaDirecta = new List<Punto2D>();
            puntosCurvaCasteljau = new List<Punto2D>();

            // Eventos de los botones.
            btnAgregar.Click += btnAgregar_Click;
            btnModificar.Click += btnModificar_Click;
            btnEliminar.Click += btnEliminar_Click;
            btnLimpiarPuntos.Click += btnLimpiarPuntos_Click;
            btnCalcular.Click += btnCalcular_Click;
            btnLimpiar.Click += btnLimpiar_Click;

            // Evento para dibujar el plano.
            panelGrafico.Paint += panelGrafico_Paint;

            ConfigurarTablaPuntos();
            ConfigurarTablaResultados();

            lblGradoValor.Text = "Sin definir";
        }

        // --------------------------------------------------
        // CONFIGURACIÓN DE TABLAS
        // --------------------------------------------------

        private void ConfigurarTablaPuntos()
        {
            dgvPuntos.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvPuntos.MultiSelect = false;
            dgvPuntos.ReadOnly = true;
            dgvPuntos.AllowUserToAddRows = false;
            dgvPuntos.AllowUserToDeleteRows = false;
            dgvPuntos.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ConfigurarTablaResultados()
        {
            dgvResultados.ReadOnly = true;
            dgvResultados.AllowUserToAddRows = false;
            dgvResultados.AllowUserToDeleteRows = false;
            dgvResultados.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }

        // --------------------------------------------------
        // VALIDACIÓN DE COORDENADAS
        // --------------------------------------------------

        private bool ConvertirNumero(string valor, out double numero)
        {
            numero = 0;

            if (string.IsNullOrWhiteSpace(valor))
                return false;

            valor = valor.Trim().Replace(',', '.');

            return double.TryParse(
                valor,
                NumberStyles.Float,
                CultureInfo.InvariantCulture,
                out numero
            ) &&
            !double.IsNaN(numero) &&
            !double.IsInfinity(numero);
        }

        private bool ObtenerCoordenadas(out double x, out double y)
        {
            x = 0;
            y = 0;

            if (!ConvertirNumero(txtX.Text, out x))
            {
                MessageBox.Show(
                    "Ingrese una coordenada X válida.",
                    "Dato incorrecto",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtX.Focus();
                return false;
            }

            if (!ConvertirNumero(txtY.Text, out y))
            {
                MessageBox.Show(
                    "Ingrese una coordenada Y válida.",
                    "Dato incorrecto",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtY.Focus();
                return false;
            }

            return true;
        }

        // --------------------------------------------------
        // AGREGAR PUNTO
        // --------------------------------------------------

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            double x, y;

            if (!ObtenerCoordenadas(out x, out y))
                return;

            try
            {
                controller.GestorPuntos.AgregarPunto(x, y);

                ActualizarTablaPuntos();
                LimpiarResultados();

                txtX.Clear();
                txtY.Clear();
                txtX.Focus();

                panelGrafico.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "No se pudo agregar el punto",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        // --------------------------------------------------
        // MODIFICAR PUNTO
        // --------------------------------------------------

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvPuntos.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Seleccione un punto de la tabla.",
                    "Modificar punto",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                return;
            }

            double x, y;

            if (!ObtenerCoordenadas(out x, out y))
                return;

            try
            {
                int indice = Convert.ToInt32(
                    dgvPuntos.SelectedRows[0].Cells["colIndice"].Value
                );

                controller.GestorPuntos.ModificarPunto(indice, x, y);

                ActualizarTablaPuntos();
                LimpiarResultados();

                panelGrafico.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "No se pudo modificar el punto",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private List<PointF> ConvertirAPuntosF(List<Punto2D> puntos)
        {
            List<PointF> resultado = new List<PointF>();

            foreach (Punto2D punto in puntos)
            {
                resultado.Add(new PointF(
                    (float)punto.X,
                    (float)punto.Y
                ));
            }

            return resultado;
        }

        private List<Punto2D> ConvertirAPuntos2D(List<PointF> puntos)
        {
            List<Punto2D> resultado = new List<Punto2D>();

            foreach (PointF punto in puntos)
            {
                resultado.Add(new Punto2D(
                    punto.X,
                    punto.Y
                ));
            }

            return resultado;
        }

        // --------------------------------------------------
        // ELIMINAR PUNTO
        // --------------------------------------------------

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPuntos.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Seleccione un punto para eliminar.",
                    "Eliminar punto",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                return;
            }

            try
            {
                int indice = Convert.ToInt32(
                    dgvPuntos.SelectedRows[0].Cells["colIndice"].Value
                );

                controller.GestorPuntos.EliminarPunto(indice);

                ActualizarTablaPuntos();
                LimpiarResultados();

                panelGrafico.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "No se pudo eliminar el punto",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        // --------------------------------------------------
        // LIMPIAR PUNTOS
        // --------------------------------------------------

        private void btnLimpiarPuntos_Click(object sender, EventArgs e)
        {
            controller.GestorPuntos.LimpiarPuntos();

            ActualizarTablaPuntos();
            LimpiarResultados();

            txtX.Clear();
            txtY.Clear();

            panelGrafico.Invalidate();
        }

        // --------------------------------------------------
        // ACTUALIZAR TABLA DE PUNTOS
        // --------------------------------------------------

        private void ActualizarTablaPuntos()
        {
            dgvPuntos.Rows.Clear();

            List<Punto2D> puntos =
                controller.GestorPuntos.ObtenerPuntosControl();

            for (int i = 0; i < puntos.Count; i++)
            {
                dgvPuntos.Rows.Add(
                    i,
                    puntos[i].X.ToString("F2"),
                    puntos[i].Y.ToString("F2")
                );
            }

            ActualizarGrado();
        }

        private void ActualizarGrado()
        {
            int cantidad = controller.GestorPuntos.CantidadPuntos;

            if (cantidad < 2)
            {
                lblGradoValor.Text = "Sin definir";
            }
            else
            {
                lblGradoValor.Text = (cantidad - 1).ToString();
            }
        }

        // --------------------------------------------------
        // CALCULAR CURVA
        // --------------------------------------------------


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener la curva y la cantidad de muestras.
                CurvaBezier curva = controller.CrearCurva();
                int muestras = (int)numMuestras.Value;

                // Obtener los puntos de control.
                List<Punto2D> puntosControl =
                    controller.GestorPuntos.ObtenerPuntosControl();

                // Convertir los puntos para utilizar De Casteljau.
                List<PointF> puntosControlF =
                    ConvertirAPuntosF(puntosControl);

                // -----------------------------------------
                // MEDIR BEZIER DIRECTO
                // -----------------------------------------

                List<double> tiemposDirecto = medidor.MedirTiempos(
                    () => controller.CalcularBezierDirecto(curva, muestras),
                    10
                );

                double promedioDirecto =
                    medidor.CalcularPromedio(tiemposDirecto);

                // -----------------------------------------
                // MEDIR DE CASTELJAU
                // -----------------------------------------

                // De Casteljau genera pasos + 1 puntos.
                // Por eso utilizamos muestras - 1.
                List<double> tiemposCasteljau = medidor.MedirTiempos(
                    () => algoritmoDeCasteljau.GenerarCurva(
                        puntosControlF,
                        muestras - 1
                    ),
                    10
                );

                double promedioCasteljau =
                    medidor.CalcularPromedio(tiemposCasteljau);

                // -----------------------------------------
                // OBTENER RESULTADOS DE AMBOS ALGORITMOS
                // -----------------------------------------

                puntosCurvaDirecta =
                    controller.CalcularBezierDirecto(curva, muestras);

                List<PointF> curvaCasteljauF =
                    algoritmoDeCasteljau.GenerarCurva(
                        puntosControlF,
                        muestras - 1
                    );

                puntosCurvaCasteljau =
                    ConvertirAPuntos2D(curvaCasteljauF);

                // -----------------------------------------
                // COMPARAR RESULTADOS
                // -----------------------------------------

                ResultadoComparacion resultado =
                    comparador.Comparar(
                        puntosCurvaDirecta,
                        puntosCurvaCasteljau
                    );

                // -----------------------------------------
                // MOSTRAR TIEMPOS Y ERRORES
                // -----------------------------------------

                lblTiempoDirecto.Text =
                    "Tiempo Bézier directo: " +
                    promedioDirecto.ToString("F6") + " ms";

                lblTiempoCasteljau.Text =
                    "Tiempo De Casteljau: " +
                    promedioCasteljau.ToString("F6") + " ms";

                lblErrorPromedio.Text =
                    "Error promedio: " +
                    resultado.ErrorPromedio.ToString("F8");

                lblErrorMaximo.Text =
                    "Error máximo: " +
                    resultado.ErrorMaximo.ToString("F8");

                // Mostrar comparación numérica.
                MostrarResultadosDirectos();

                // Mostrar las interpolaciones para t = 0.5.
                MostrarInterpolaciones(puntosControlF, 0.5f);

                // Actualizar dibujo.
                panelGrafico.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error al calcular las curvas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }


        // --------------------------------------------------
        // MOSTRAR RESULTADOS DIRECTOS
        // --------------------------------------------------

        private void MostrarResultadosDirectos()
        {
            dgvResultados.Rows.Clear();

            for (int i = 0; i < puntosCurvaDirecta.Count; i++)
            {
                double t = (double)i /
                    (puntosCurvaDirecta.Count - 1);

                Punto2D directo = puntosCurvaDirecta[i];
                Punto2D casteljau = puntosCurvaCasteljau[i];

                double diferenciaX =
                    Math.Abs(directo.X - casteljau.X);

                double diferenciaY =
                    Math.Abs(directo.Y - casteljau.Y);

                double error = Math.Sqrt(
                    diferenciaX * diferenciaX +
                    diferenciaY * diferenciaY
                );

                dgvResultados.Rows.Add(
                    i + 1,
                    t.ToString("F4"),
                    directo.X.ToString("F4"),
                    directo.Y.ToString("F4"),
                    casteljau.X.ToString("F4"),
                    casteljau.Y.ToString("F4"),
                    error.ToString("F8")
                );
            }
        }


        private void MostrarInterpolaciones(
    List<PointF> puntosControl,
    float t)
        {
            dgvIteraciones.Rows.Clear();

            List<NivelInterpolacion> niveles =
                algoritmoDeCasteljau.ObtenerNivelesPasoAPaso(
                    puntosControl,
                    t
                );

            foreach (NivelInterpolacion nivel in niveles)
            {
                for (int i = 0; i < nivel.Puntos.Count; i++)
                {
                    PointF punto = nivel.Puntos[i];

                    dgvIteraciones.Rows.Add(
                        nivel.Nivel,
                        i,
                        punto.X.ToString("F4"),
                        punto.Y.ToString("F4")
                    );
                }
            }
        }


        private void ConfigurarTablaIteraciones()
        {
            dgvIteraciones.Columns.Clear();

            dgvIteraciones.Columns.Add("colNivel", "Nivel");
            dgvIteraciones.Columns.Add("colPunto", "Punto");
            dgvIteraciones.Columns.Add("colXIteracion", "X");
            dgvIteraciones.Columns.Add("colYIteracion", "Y");

            dgvIteraciones.ReadOnly = true;
            dgvIteraciones.AllowUserToAddRows = false;
            dgvIteraciones.AllowUserToDeleteRows = false;
            dgvIteraciones.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }

        // --------------------------------------------------
        // LIMPIAR APLICACIÓN
        // --------------------------------------------------

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            controller.GestorPuntos.LimpiarPuntos();

            ActualizarTablaPuntos();
            LimpiarResultados();

            txtX.Clear();
            txtY.Clear();

            numMuestras.Value = 100;

            panelGrafico.Invalidate();
        }

        private void LimpiarResultados()
        {
            puntosCurvaDirecta.Clear();
            puntosCurvaCasteljau.Clear();

            dgvResultados.Rows.Clear();

            lblTiempoDirecto.Text =
                "Tiempo Bézier directo: -- ms";

            lblTiempoCasteljau.Text =
                "Tiempo De Casteljau: -- ms";

            lblErrorPromedio.Text =
                "Error promedio: --";

            lblErrorMaximo.Text =
                "Error máximo: --";
        }

        // --------------------------------------------------
        // DIBUJAR PLANO Y CURVAS
        // --------------------------------------------------

        private void panelGrafico_Paint(object sender, PaintEventArgs e)
        {
            List<Punto2D> puntosControl =
                controller.GestorPuntos.ObtenerPuntosControl();

            dibujador.Dibujar(
                e.Graphics,
                panelGrafico.ClientSize.Width,
                panelGrafico.ClientSize.Height,
                puntosControl,
                puntosCurvaDirecta,
                puntosCurvaCasteljau
            );
        }

        private void lblMuestras_Click(object sender, EventArgs e)
        {

        }
    }
}

