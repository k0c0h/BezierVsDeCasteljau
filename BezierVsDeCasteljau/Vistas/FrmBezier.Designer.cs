namespace BezierVsDeCasteljau.Vistas
{
    partial class FrmBezier
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpPuntos = new System.Windows.Forms.GroupBox();
            this.lblCoordenadaX = new System.Windows.Forms.Label();
            this.lblCoordenadaY = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvPuntos = new System.Windows.Forms.DataGridView();
            this.btnLimpiarPuntos = new System.Windows.Forms.Button();
            this.colIndice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpConfiguracion = new System.Windows.Forms.GroupBox();
            this.lblGrado = new System.Windows.Forms.Label();
            this.lblGradoValor = new System.Windows.Forms.Label();
            this.lblMuestras = new System.Windows.Forms.Label();
            this.numMuestras = new System.Windows.Forms.NumericUpDown();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.grpVisualizacion = new System.Windows.Forms.GroupBox();
            this.panelGrafico = new System.Windows.Forms.Panel();
            this.lblBezierDirecto = new System.Windows.Forms.Label();
            this.lblCasteljau = new System.Windows.Forms.Label();
            this.lblPuntosControl = new System.Windows.Forms.Label();
            this.grpResultados = new System.Windows.Forms.GroupBox();
            this.lblTiempoDirecto = new System.Windows.Forms.Label();
            this.lblTiempoCasteljau = new System.Windows.Forms.Label();
            this.lblErrorPromedio = new System.Windows.Forms.Label();
            this.lblErrorMaximo = new System.Windows.Forms.Label();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.colMuestra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colXDirecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colYDirecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colXCasteljau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colYCasteljau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colError = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabResultados = new System.Windows.Forms.TabControl();
            this.tabComparacion = new System.Windows.Forms.TabPage();
            this.tabInterpolaciones = new System.Windows.Forms.TabPage();
            this.dgvIteraciones = new System.Windows.Forms.DataGridView();
            this.grpPuntos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuntos)).BeginInit();
            this.grpConfiguracion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMuestras)).BeginInit();
            this.grpVisualizacion.SuspendLayout();
            this.grpResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.tabResultados.SuspendLayout();
            this.tabComparacion.SuspendLayout();
            this.tabInterpolaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIteraciones)).BeginInit();
            this.SuspendLayout();
            // 
            // grpPuntos
            // 
            this.grpPuntos.Controls.Add(this.btnLimpiarPuntos);
            this.grpPuntos.Controls.Add(this.dgvPuntos);
            this.grpPuntos.Controls.Add(this.btnEliminar);
            this.grpPuntos.Controls.Add(this.btnModificar);
            this.grpPuntos.Controls.Add(this.btnAgregar);
            this.grpPuntos.Controls.Add(this.txtY);
            this.grpPuntos.Controls.Add(this.txtX);
            this.grpPuntos.Controls.Add(this.lblCoordenadaY);
            this.grpPuntos.Controls.Add(this.lblCoordenadaX);
            this.grpPuntos.Location = new System.Drawing.Point(14, 38);
            this.grpPuntos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpPuntos.Name = "grpPuntos";
            this.grpPuntos.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpPuntos.Size = new System.Drawing.Size(300, 513);
            this.grpPuntos.TabIndex = 0;
            this.grpPuntos.TabStop = false;
            this.grpPuntos.Text = "Gestión de puntos de control";
            // 
            // lblCoordenadaX
            // 
            this.lblCoordenadaX.AutoSize = true;
            this.lblCoordenadaX.Location = new System.Drawing.Point(26, 62);
            this.lblCoordenadaX.Name = "lblCoordenadaX";
            this.lblCoordenadaX.Size = new System.Drawing.Size(130, 25);
            this.lblCoordenadaX.TabIndex = 0;
            this.lblCoordenadaX.Text = "Coordenada X:";
            // 
            // lblCoordenadaY
            // 
            this.lblCoordenadaY.AutoSize = true;
            this.lblCoordenadaY.Location = new System.Drawing.Point(26, 118);
            this.lblCoordenadaY.Name = "lblCoordenadaY";
            this.lblCoordenadaY.Size = new System.Drawing.Size(129, 25);
            this.lblCoordenadaY.TabIndex = 1;
            this.lblCoordenadaY.Text = "Coordenada Y:";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(92, 62);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 31);
            this.txtX.TabIndex = 2;
            // 
            // txtY
            // 
            this.txtY.AcceptsReturn = true;
            this.txtY.Location = new System.Drawing.Point(92, 118);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(100, 31);
            this.txtY.TabIndex = 3;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(31, 183);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar punto";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(116, 182);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Modificar punto";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(31, 233);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar punto";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // dgvPuntos
            // 
            this.dgvPuntos.AllowUserToAddRows = false;
            this.dgvPuntos.AllowUserToDeleteRows = false;
            this.dgvPuntos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPuntos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPuntos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIndice,
            this.colX,
            this.colY});
            this.dgvPuntos.Location = new System.Drawing.Point(31, 283);
            this.dgvPuntos.MultiSelect = false;
            this.dgvPuntos.Name = "dgvPuntos";
            this.dgvPuntos.ReadOnly = true;
            this.dgvPuntos.RowHeadersWidth = 62;
            this.dgvPuntos.RowTemplate.Height = 28;
            this.dgvPuntos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPuntos.Size = new System.Drawing.Size(240, 150);
            this.dgvPuntos.TabIndex = 7;
            // 
            // btnLimpiarPuntos
            // 
            this.btnLimpiarPuntos.Location = new System.Drawing.Point(31, 467);
            this.btnLimpiarPuntos.Name = "btnLimpiarPuntos";
            this.btnLimpiarPuntos.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiarPuntos.TabIndex = 8;
            this.btnLimpiarPuntos.Text = "Limpiar puntos";
            this.btnLimpiarPuntos.UseVisualStyleBackColor = true;
            // 
            // colIndice
            // 
            this.colIndice.HeaderText = "N.º";
            this.colIndice.MinimumWidth = 8;
            this.colIndice.Name = "colIndice";
            this.colIndice.ReadOnly = true;
            // 
            // colX
            // 
            this.colX.HeaderText = "X";
            this.colX.MinimumWidth = 8;
            this.colX.Name = "colX";
            this.colX.ReadOnly = true;
            // 
            // colY
            // 
            this.colY.HeaderText = "Y";
            this.colY.MinimumWidth = 8;
            this.colY.Name = "colY";
            this.colY.ReadOnly = true;
            // 
            // grpConfiguracion
            // 
            this.grpConfiguracion.Controls.Add(this.btnLimpiar);
            this.grpConfiguracion.Controls.Add(this.btnCalcular);
            this.grpConfiguracion.Controls.Add(this.numMuestras);
            this.grpConfiguracion.Controls.Add(this.lblMuestras);
            this.grpConfiguracion.Controls.Add(this.lblGradoValor);
            this.grpConfiguracion.Controls.Add(this.lblGrado);
            this.grpConfiguracion.Location = new System.Drawing.Point(14, 578);
            this.grpConfiguracion.Name = "grpConfiguracion";
            this.grpConfiguracion.Size = new System.Drawing.Size(300, 367);
            this.grpConfiguracion.TabIndex = 1;
            this.grpConfiguracion.TabStop = false;
            this.grpConfiguracion.Text = "Configuración de la curva";
            // 
            // lblGrado
            // 
            this.lblGrado.AutoSize = true;
            this.lblGrado.Location = new System.Drawing.Point(17, 49);
            this.lblGrado.Name = "lblGrado";
            this.lblGrado.Size = new System.Drawing.Size(155, 25);
            this.lblGrado.TabIndex = 0;
            this.lblGrado.Text = "Grado de la curva:";
            // 
            // lblGradoValor
            // 
            this.lblGradoValor.AutoSize = true;
            this.lblGradoValor.Location = new System.Drawing.Point(17, 108);
            this.lblGradoValor.Name = "lblGradoValor";
            this.lblGradoValor.Size = new System.Drawing.Size(91, 25);
            this.lblGradoValor.TabIndex = 1;
            this.lblGradoValor.Text = "Sin definir";
            // 
            // lblMuestras
            // 
            this.lblMuestras.AutoSize = true;
            this.lblMuestras.Location = new System.Drawing.Point(17, 173);
            this.lblMuestras.Name = "lblMuestras";
            this.lblMuestras.Size = new System.Drawing.Size(189, 25);
            this.lblMuestras.TabIndex = 2;
            this.lblMuestras.Text = "Cantidad de muestras:";
            // 
            // numMuestras
            // 
            this.numMuestras.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numMuestras.Location = new System.Drawing.Point(116, 173);
            this.numMuestras.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numMuestras.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numMuestras.Name = "numMuestras";
            this.numMuestras.Size = new System.Drawing.Size(120, 31);
            this.numMuestras.TabIndex = 3;
            this.numMuestras.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(22, 230);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular curvas";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(22, 278);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Reiniciar aplicación";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // grpVisualizacion
            // 
            this.grpVisualizacion.Controls.Add(this.lblPuntosControl);
            this.grpVisualizacion.Controls.Add(this.lblCasteljau);
            this.grpVisualizacion.Controls.Add(this.lblBezierDirecto);
            this.grpVisualizacion.Controls.Add(this.panelGrafico);
            this.grpVisualizacion.Location = new System.Drawing.Point(321, 38);
            this.grpVisualizacion.Name = "grpVisualizacion";
            this.grpVisualizacion.Size = new System.Drawing.Size(1108, 407);
            this.grpVisualizacion.TabIndex = 2;
            this.grpVisualizacion.TabStop = false;
            this.grpVisualizacion.Text = "Visualización de curvas Bézier";
            // 
            // panelGrafico
            // 
            this.panelGrafico.BackColor = System.Drawing.Color.White;
            this.panelGrafico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGrafico.Location = new System.Drawing.Point(39, 51);
            this.panelGrafico.Name = "panelGrafico";
            this.panelGrafico.Size = new System.Drawing.Size(557, 271);
            this.panelGrafico.TabIndex = 0;
            // 
            // lblBezierDirecto
            // 
            this.lblBezierDirecto.AutoSize = true;
            this.lblBezierDirecto.Location = new System.Drawing.Point(39, 358);
            this.lblBezierDirecto.Name = "lblBezierDirecto";
            this.lblBezierDirecto.Size = new System.Drawing.Size(118, 25);
            this.lblBezierDirecto.TabIndex = 1;
            this.lblBezierDirecto.Text = "Bézier directo";
            // 
            // lblCasteljau
            // 
            this.lblCasteljau.AutoSize = true;
            this.lblCasteljau.Location = new System.Drawing.Point(234, 358);
            this.lblCasteljau.Name = "lblCasteljau";
            this.lblCasteljau.Size = new System.Drawing.Size(109, 25);
            this.lblCasteljau.TabIndex = 2;
            this.lblCasteljau.Text = "De Casteljau";
            // 
            // lblPuntosControl
            // 
            this.lblPuntosControl.AutoSize = true;
            this.lblPuntosControl.Location = new System.Drawing.Point(452, 358);
            this.lblPuntosControl.Name = "lblPuntosControl";
            this.lblPuntosControl.Size = new System.Drawing.Size(169, 25);
            this.lblPuntosControl.TabIndex = 3;
            this.lblPuntosControl.Text = "Polígono de control";
            // 
            // grpResultados
            // 
            this.grpResultados.Controls.Add(this.tabResultados);
            this.grpResultados.Controls.Add(this.lblErrorMaximo);
            this.grpResultados.Controls.Add(this.lblErrorPromedio);
            this.grpResultados.Controls.Add(this.lblTiempoCasteljau);
            this.grpResultados.Controls.Add(this.lblTiempoDirecto);
            this.grpResultados.Location = new System.Drawing.Point(321, 451);
            this.grpResultados.Name = "grpResultados";
            this.grpResultados.Size = new System.Drawing.Size(1131, 494);
            this.grpResultados.TabIndex = 3;
            this.grpResultados.TabStop = false;
            this.grpResultados.Text = "Resultados y comparación de algoritmos";
            // 
            // lblTiempoDirecto
            // 
            this.lblTiempoDirecto.AutoSize = true;
            this.lblTiempoDirecto.Location = new System.Drawing.Point(34, 49);
            this.lblTiempoDirecto.Name = "lblTiempoDirecto";
            this.lblTiempoDirecto.Size = new System.Drawing.Size(235, 25);
            this.lblTiempoDirecto.TabIndex = 0;
            this.lblTiempoDirecto.Text = "Tiempo Bézier directo: -- ms";
            // 
            // lblTiempoCasteljau
            // 
            this.lblTiempoCasteljau.AutoSize = true;
            this.lblTiempoCasteljau.Location = new System.Drawing.Point(34, 89);
            this.lblTiempoCasteljau.Name = "lblTiempoCasteljau";
            this.lblTiempoCasteljau.Size = new System.Drawing.Size(226, 25);
            this.lblTiempoCasteljau.TabIndex = 1;
            this.lblTiempoCasteljau.Text = "Tiempo De Casteljau: -- ms";
            // 
            // lblErrorPromedio
            // 
            this.lblErrorPromedio.AutoSize = true;
            this.lblErrorPromedio.Location = new System.Drawing.Point(39, 125);
            this.lblErrorPromedio.Name = "lblErrorPromedio";
            this.lblErrorPromedio.Size = new System.Drawing.Size(157, 25);
            this.lblErrorPromedio.TabIndex = 2;
            this.lblErrorPromedio.Text = "Error promedio: --";
            // 
            // lblErrorMaximo
            // 
            this.lblErrorMaximo.AutoSize = true;
            this.lblErrorMaximo.Location = new System.Drawing.Point(39, 155);
            this.lblErrorMaximo.Name = "lblErrorMaximo";
            this.lblErrorMaximo.Size = new System.Drawing.Size(142, 25);
            this.lblErrorMaximo.TabIndex = 3;
            this.lblErrorMaximo.Text = "Error máximo: --";
            // 
            // dgvResultados
            // 
            this.dgvResultados.AllowUserToAddRows = false;
            this.dgvResultados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMuestra,
            this.colT,
            this.colXDirecto,
            this.colYDirecto,
            this.colXCasteljau,
            this.colYCasteljau,
            this.colError});
            this.dgvResultados.Location = new System.Drawing.Point(15, 15);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.ReadOnly = true;
            this.dgvResultados.RowHeadersWidth = 62;
            this.dgvResultados.RowTemplate.Height = 28;
            this.dgvResultados.Size = new System.Drawing.Size(344, 150);
            this.dgvResultados.TabIndex = 4;
            // 
            // colMuestra
            // 
            this.colMuestra.HeaderText = "Muestra";
            this.colMuestra.MinimumWidth = 8;
            this.colMuestra.Name = "colMuestra";
            this.colMuestra.ReadOnly = true;
            // 
            // colT
            // 
            this.colT.HeaderText = "Parámetro t";
            this.colT.MinimumWidth = 8;
            this.colT.Name = "colT";
            this.colT.ReadOnly = true;
            // 
            // colXDirecto
            // 
            this.colXDirecto.HeaderText = "X directo";
            this.colXDirecto.MinimumWidth = 8;
            this.colXDirecto.Name = "colXDirecto";
            this.colXDirecto.ReadOnly = true;
            // 
            // colYDirecto
            // 
            this.colYDirecto.HeaderText = "Y directo";
            this.colYDirecto.MinimumWidth = 8;
            this.colYDirecto.Name = "colYDirecto";
            this.colYDirecto.ReadOnly = true;
            // 
            // colXCasteljau
            // 
            this.colXCasteljau.HeaderText = "X De Casteljau";
            this.colXCasteljau.MinimumWidth = 8;
            this.colXCasteljau.Name = "colXCasteljau";
            this.colXCasteljau.ReadOnly = true;
            // 
            // colYCasteljau
            // 
            this.colYCasteljau.HeaderText = "Y De Casteljau";
            this.colYCasteljau.MinimumWidth = 8;
            this.colYCasteljau.Name = "colYCasteljau";
            this.colYCasteljau.ReadOnly = true;
            // 
            // colError
            // 
            this.colError.HeaderText = "Error";
            this.colError.MinimumWidth = 8;
            this.colError.Name = "colError";
            this.colError.ReadOnly = true;
            // 
            // tabResultados
            // 
            this.tabResultados.Controls.Add(this.tabComparacion);
            this.tabResultados.Controls.Add(this.tabInterpolaciones);
            this.tabResultados.Location = new System.Drawing.Point(25, 186);
            this.tabResultados.Name = "tabResultados";
            this.tabResultados.SelectedIndex = 0;
            this.tabResultados.Size = new System.Drawing.Size(495, 242);
            this.tabResultados.TabIndex = 5;
            // 
            // tabComparacion
            // 
            this.tabComparacion.Controls.Add(this.dgvResultados);
            this.tabComparacion.Location = new System.Drawing.Point(4, 34);
            this.tabComparacion.Name = "tabComparacion";
            this.tabComparacion.Padding = new System.Windows.Forms.Padding(3);
            this.tabComparacion.Size = new System.Drawing.Size(487, 204);
            this.tabComparacion.TabIndex = 0;
            this.tabComparacion.Text = "Comparación";
            this.tabComparacion.UseVisualStyleBackColor = true;
            // 
            // tabInterpolaciones
            // 
            this.tabInterpolaciones.Controls.Add(this.dgvIteraciones);
            this.tabInterpolaciones.Location = new System.Drawing.Point(4, 34);
            this.tabInterpolaciones.Name = "tabInterpolaciones";
            this.tabInterpolaciones.Padding = new System.Windows.Forms.Padding(3);
            this.tabInterpolaciones.Size = new System.Drawing.Size(487, 204);
            this.tabInterpolaciones.TabIndex = 1;
            this.tabInterpolaciones.Text = "Interpolaciones De Casteljau";
            this.tabInterpolaciones.UseVisualStyleBackColor = true;
            // 
            // dgvIteraciones
            // 
            this.dgvIteraciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIteraciones.Location = new System.Drawing.Point(33, 28);
            this.dgvIteraciones.Name = "dgvIteraciones";
            this.dgvIteraciones.RowHeadersWidth = 62;
            this.dgvIteraciones.RowTemplate.Height = 28;
            this.dgvIteraciones.Size = new System.Drawing.Size(240, 150);
            this.dgvIteraciones.TabIndex = 0;
            // 
            // FrmBezier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1501, 999);
            this.Controls.Add(this.grpResultados);
            this.Controls.Add(this.grpVisualizacion);
            this.Controls.Add(this.grpConfiguracion);
            this.Controls.Add(this.grpPuntos);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1109, 861);
            this.Name = "FrmBezier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bézier vs. De Casteljau";
            this.grpPuntos.ResumeLayout(false);
            this.grpPuntos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuntos)).EndInit();
            this.grpConfiguracion.ResumeLayout(false);
            this.grpConfiguracion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMuestras)).EndInit();
            this.grpVisualizacion.ResumeLayout(false);
            this.grpVisualizacion.PerformLayout();
            this.grpResultados.ResumeLayout(false);
            this.grpResultados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.tabResultados.ResumeLayout(false);
            this.tabComparacion.ResumeLayout(false);
            this.tabInterpolaciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIteraciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPuntos;
        private System.Windows.Forms.Button btnLimpiarPuntos;
        private System.Windows.Forms.DataGridView dgvPuntos;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label lblCoordenadaY;
        private System.Windows.Forms.Label lblCoordenadaX;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIndice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colX;
        private System.Windows.Forms.DataGridViewTextBoxColumn colY;
        private System.Windows.Forms.GroupBox grpConfiguracion;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.NumericUpDown numMuestras;
        private System.Windows.Forms.Label lblMuestras;
        private System.Windows.Forms.Label lblGradoValor;
        private System.Windows.Forms.Label lblGrado;
        private System.Windows.Forms.GroupBox grpVisualizacion;
        private System.Windows.Forms.Label lblPuntosControl;
        private System.Windows.Forms.Label lblCasteljau;
        private System.Windows.Forms.Label lblBezierDirecto;
        private System.Windows.Forms.Panel panelGrafico;
        private System.Windows.Forms.GroupBox grpResultados;
        private System.Windows.Forms.Label lblErrorMaximo;
        private System.Windows.Forms.Label lblErrorPromedio;
        private System.Windows.Forms.Label lblTiempoCasteljau;
        private System.Windows.Forms.Label lblTiempoDirecto;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMuestra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colXDirecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colYDirecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colXCasteljau;
        private System.Windows.Forms.DataGridViewTextBoxColumn colYCasteljau;
        private System.Windows.Forms.DataGridViewTextBoxColumn colError;
        private System.Windows.Forms.TabControl tabResultados;
        private System.Windows.Forms.TabPage tabComparacion;
        private System.Windows.Forms.TabPage tabInterpolaciones;
        private System.Windows.Forms.DataGridView dgvIteraciones;
    }
}