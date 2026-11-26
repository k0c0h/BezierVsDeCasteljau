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

namespace BezierVsDeCasteljau.Vistas
{
    public partial class FrmBezier : Form
    {
        private BezierController controller;
        private DibujadorBezier dibujador;

        private List<Punto2D> puntosCurvaDirecta;
        private List<Punto2D> puntosCurvaCasteljau;

        public FrmBezier()
        {
            InitializeComponent();

            controller = new BezierController();
            dibujador = new DibujadorBezier();

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
                CurvaBezier curva = controller.CrearCurva();

                int muestras = (int)numMuestras.Value;

                // Calcular Bézier directo.
                puntosCurvaDirecta =
                    controller.CalcularBezierDirecto(curva, muestras);

                // Medir rendimiento del algoritmo directo.
                MedidorRendimiento medidor = new MedidorRendimiento();

                List<double> tiemposDirecto = medidor.MedirTiempos(
                    () => controller.CalcularBezierDirecto(curva, muestras),
                    10
                );

                double promedioDirecto =
                    medidor.CalcularPromedio(tiemposDirecto);

                lblTiempoDirecto.Text =
                    "Tiempo Bézier directo: " +
                    promedioDirecto.ToString("F6") + " ms";

                // De Casteljau se integrará cuando esté disponible
                // el algoritmo del integrante 2.
                puntosCurvaCasteljau.Clear();

                lblTiempoCasteljau.Text =
                    "Tiempo De Casteljau: Pendiente";

                lblErrorPromedio.Text =
                    "Error promedio: Pendiente";

                lblErrorMaximo.Text =
                    "Error máximo: Pendiente";

                MostrarResultadosDirectos();

                panelGrafico.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error al calcular la curva",
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

                Punto2D punto = puntosCurvaDirecta[i];

                dgvResultados.Rows.Add(
                    i + 1,
                    t.ToString("F4"),
                    punto.X.ToString("F4"),
                    punto.Y.ToString("F4"),
                    "--",
                    "--",
                    "--"
                );
            }
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

