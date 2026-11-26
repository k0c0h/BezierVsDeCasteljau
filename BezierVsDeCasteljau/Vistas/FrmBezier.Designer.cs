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
            this.btnLimpiarPuntos = new System.Windows.Forms.Button();
            this.dgvPuntos = new System.Windows.Forms.DataGridView();
            this.colIndice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtY = new System.Windows.Forms.TextBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.lblCoordenadaY = new System.Windows.Forms.Label();
            this.lblCoordenadaX = new System.Windows.Forms.Label();
            this.grpConfiguracion = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.numMuestras = new System.Windows.Forms.NumericUpDown();
            this.lblMuestras = new System.Windows.Forms.Label();
            this.lblGradoValor = new System.Windows.Forms.Label();
            this.lblGrado = new System.Windows.Forms.Label();
            this.grpVisualizacion = new System.Windows.Forms.GroupBox();
            this.lblPuntosControl = new System.Windows.Forms.Label();
            this.lblCasteljau = new System.Windows.Forms.Label();
            this.lblBezierDirecto = new System.Windows.Forms.Label();
            this.panelGrafico = new System.Windows.Forms.Panel();
            this.grpResultados = new System.Windows.Forms.GroupBox();
            this.tabResultados = new System.Windows.Forms.TabControl();
            this.tabComparacion = new System.Windows.Forms.TabPage();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.colMuestra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colXDirecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colYDirecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colXCasteljau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colYCasteljau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colError = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabInterpolaciones = new System.Windows.Forms.TabPage();
            this.dgvIteraciones = new System.Windows.Forms.DataGridView();
            this.lblErrorMaximo = new System.Windows.Forms.Label();
            this.lblErrorPromedio = new System.Windows.Forms.Label();
            this.lblTiempoCasteljau = new System.Windows.Forms.Label();
            this.lblTiempoDirecto = new System.Windows.Forms.Label();
            this.grpPuntos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuntos)).BeginInit();
            this.grpConfiguracion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMuestras)).BeginInit();
            this.grpVisualizacion.SuspendLayout();
            this.grpResultados.SuspendLayout();
            this.tabResultados.SuspendLayout();
            this.tabComparacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.tabInterpolaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIteraciones)).BeginInit();
            this.SuspendLayout();
            // 
            // grpPuntos
            // 
            this.grpPuntos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpPuntos.Controls.Add(this.btnLimpiarPuntos);
            this.grpPuntos.Controls.Add(this.dgvPuntos);
            this.grpPuntos.Controls.Add(this.btnEliminar);
            this.grpPuntos.Controls.Add(this.btnModificar);
            this.grpPuntos.Controls.Add(this.btnAgregar);
            this.grpPuntos.Controls.Add(this.txtY);
            this.grpPuntos.Controls.Add(this.txtX);
            this.grpPuntos.Controls.Add(this.lblCoordenadaY);
            this.grpPuntos.Controls.Add(this.lblCoordenadaX);
            this.grpPuntos.Location = new System.Drawing.Point(10, 10);
            this.grpPuntos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpPuntos.Name = "grpPuntos";
            this.grpPuntos.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpPuntos.Size = new System.Drawing.Size(360, 472);
            this.grpPuntos.TabIndex = 0;
            this.grpPuntos.TabStop = false;
            this.grpPuntos.Text = "Gestión de puntos de control";
            // 
            // btnLimpiarPuntos
            // 
            this.btnLimpiarPuntos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLimpiarPuntos.Location = new System.Drawing.Point(20, 412);
            this.btnLimpiarPuntos.Name = "btnLimpiarPuntos";
            this.btnLimpiarPuntos.Size = new System.Drawing.Size(150, 35);
            this.btnLimpiarPuntos.TabIndex = 8;
            this.btnLimpiarPuntos.Text = "Limpiar puntos";
            this.btnLimpiarPuntos.UseVisualStyleBackColor = true;
            this.btnLimpiarPuntos.Click += new System.EventHandler(this.btnLimpiarPuntos_Click);
            // 
            // dgvPuntos
            // 
            this.dgvPuntos.AllowUserToAddRows = false;
            this.dgvPuntos.AllowUserToDeleteRows = false;
            this.dgvPuntos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvPuntos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPuntos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPuntos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIndice,
            this.colX,
            this.colY});
            this.dgvPuntos.Location = new System.Drawing.Point(20, 235);
            this.dgvPuntos.MultiSelect = false;
            this.dgvPuntos.Name = "dgvPuntos";
            this.dgvPuntos.ReadOnly = true;
            this.dgvPuntos.RowHeadersWidth = 62;
            this.dgvPuntos.RowTemplate.Height = 28;
            this.dgvPuntos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPuntos.Size = new System.Drawing.Size(320, 162);
            this.dgvPuntos.TabIndex = 7;
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
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(20, 180);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(150, 38);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar punto";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(185, 125);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(150, 38);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Modificar punto";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(20, 125);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(150, 38);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar punto";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtY
            // 
            this.txtY.AcceptsReturn = true;
            this.txtY.Location = new System.Drawing.Point(185, 76);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(100, 31);
            this.txtY.TabIndex = 3;
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(185, 38);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 31);
            this.txtX.TabIndex = 2;
            // 
            // lblCoordenadaY
            // 
            this.lblCoordenadaY.AutoSize = true;
            this.lblCoordenadaY.Location = new System.Drawing.Point(20, 79);
            this.lblCoordenadaY.Name = "lblCoordenadaY";
            this.lblCoordenadaY.Size = new System.Drawing.Size(129, 25);
            this.lblCoordenadaY.TabIndex = 1;
            this.lblCoordenadaY.Text = "Coordenada Y:";
            // 
            // lblCoordenadaX
            // 
            this.lblCoordenadaX.AutoSize = true;
            this.lblCoordenadaX.Location = new System.Drawing.Point(20, 41);
            this.lblCoordenadaX.Name = "lblCoordenadaX";
            this.lblCoordenadaX.Size = new System.Drawing.Size(130, 25);
            this.lblCoordenadaX.TabIndex = 0;
            this.lblCoordenadaX.Text = "Coordenada X:";
            // 
            // grpConfiguracion
            // 
            this.grpConfiguracion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpConfiguracion.Controls.Add(this.btnLimpiar);
            this.grpConfiguracion.Controls.Add(this.btnCalcular);
            this.grpConfiguracion.Controls.Add(this.numMuestras);
            this.grpConfiguracion.Controls.Add(this.lblMuestras);
            this.grpConfiguracion.Controls.Add(this.lblGradoValor);
            this.grpConfiguracion.Controls.Add(this.lblGrado);
            this.grpConfiguracion.Location = new System.Drawing.Point(10, 489);
            this.grpConfiguracion.Name = "grpConfiguracion";
            this.grpConfiguracion.Size = new System.Drawing.Size(360, 201);
            this.grpConfiguracion.TabIndex = 1;
            this.grpConfiguracion.TabStop = false;
            this.grpConfiguracion.Text = "Configuración de la curva";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(193, 150);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(92, 40);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Reiniciar aplicación";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(20, 150);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(150, 40);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular curvas";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // numMuestras
            // 
            this.numMuestras.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numMuestras.Location = new System.Drawing.Point(165, 109);
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
            // lblMuestras
            // 
            this.lblMuestras.AutoSize = true;
            this.lblMuestras.Location = new System.Drawing.Point(20, 107);
            this.lblMuestras.Name = "lblMuestras";
            this.lblMuestras.Size = new System.Drawing.Size(189, 25);
            this.lblMuestras.TabIndex = 2;
            this.lblMuestras.Text = "Cantidad de muestras:";
            this.lblMuestras.Click += new System.EventHandler(this.lblMuestras_Click);
            // 
            // lblGradoValor
            // 
            this.lblGradoValor.AutoSize = true;
            this.lblGradoValor.Location = new System.Drawing.Point(20, 70);
            this.lblGradoValor.Name = "lblGradoValor";
            this.lblGradoValor.Size = new System.Drawing.Size(91, 25);
            this.lblGradoValor.TabIndex = 1;
            this.lblGradoValor.Text = "Sin definir";
            // 
            // lblGrado
            // 
            this.lblGrado.AutoSize = true;
            this.lblGrado.Location = new System.Drawing.Point(20, 38);
            this.lblGrado.Name = "lblGrado";
            this.lblGrado.Size = new System.Drawing.Size(155, 25);
            this.lblGrado.TabIndex = 0;
            this.lblGrado.Text = "Grado de la curva:";
            // 
            // grpVisualizacion
            // 
            this.grpVisualizacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpVisualizacion.Controls.Add(this.lblPuntosControl);
            this.grpVisualizacion.Controls.Add(this.lblCasteljau);
            this.grpVisualizacion.Controls.Add(this.lblBezierDirecto);
            this.grpVisualizacion.Controls.Add(this.panelGrafico);
            this.grpVisualizacion.Location = new System.Drawing.Point(380, 10);
            this.grpVisualizacion.Name = "grpVisualizacion";
            this.grpVisualizacion.Size = new System.Drawing.Size(960, 350);
            this.grpVisualizacion.TabIndex = 2;
            this.grpVisualizacion.TabStop = false;
            this.grpVisualizacion.Text = "Visualización de curvas Bézier";
            // 
            // lblPuntosControl
            // 
            this.lblPuntosControl.AutoSize = true;
            this.lblPuntosControl.Location = new System.Drawing.Point(435, 305);
            this.lblPuntosControl.Name = "lblPuntosControl";
            this.lblPuntosControl.Size = new System.Drawing.Size(169, 25);
            this.lblPuntosControl.TabIndex = 3;
            this.lblPuntosControl.Text = "Polígono de control";
            // 
            // lblCasteljau
            // 
            this.lblCasteljau.AutoSize = true;
            this.lblCasteljau.Location = new System.Drawing.Point(255, 305);
            this.lblCasteljau.Name = "lblCasteljau";
            this.lblCasteljau.Size = new System.Drawing.Size(109, 25);
            this.lblCasteljau.TabIndex = 2;
            this.lblCasteljau.Text = "De Casteljau";
            // 
            // lblBezierDirecto
            // 
            this.lblBezierDirecto.AutoSize = true;
            this.lblBezierDirecto.Location = new System.Drawing.Point(65, 305);
            this.lblBezierDirecto.Name = "lblBezierDirecto";
            this.lblBezierDirecto.Size = new System.Drawing.Size(118, 25);
            this.lblBezierDirecto.TabIndex = 1;
            this.lblBezierDirecto.Text = "Bézier directo";
            // 
            // panelGrafico
            // 
            this.panelGrafico.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGrafico.BackColor = System.Drawing.Color.White;
            this.panelGrafico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGrafico.Location = new System.Drawing.Point(20, 35);
            this.panelGrafico.Name = "panelGrafico";
            this.panelGrafico.Size = new System.Drawing.Size(920, 255);
            this.panelGrafico.TabIndex = 0;
            this.panelGrafico.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGrafico_Paint);
            // 
            // grpResultados
            // 
            this.grpResultados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpResultados.Controls.Add(this.tabResultados);
            this.grpResultados.Controls.Add(this.lblErrorMaximo);
            this.grpResultados.Controls.Add(this.lblErrorPromedio);
            this.grpResultados.Controls.Add(this.lblTiempoCasteljau);
            this.grpResultados.Controls.Add(this.lblTiempoDirecto);
            this.grpResultados.Location = new System.Drawing.Point(380, 430);
            this.grpResultados.Name = "grpResultados";
            this.grpResultados.Size = new System.Drawing.Size(960, 260);
            this.grpResultados.TabIndex = 3;
            this.grpResultados.TabStop = false;
            this.grpResultados.Text = "Resultados y comparación de algoritmos";
            // 
            // tabResultados
            // 
            this.tabResultados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabResultados.Controls.Add(this.tabComparacion);
            this.tabResultados.Controls.Add(this.tabInterpolaciones);
            this.tabResultados.Location = new System.Drawing.Point(270, 25);
            this.tabResultados.Name = "tabResultados";
            this.tabResultados.SelectedIndex = 0;
            this.tabResultados.Size = new System.Drawing.Size(670, 220);
            this.tabResultados.TabIndex = 5;
            // 
            // tabComparacion
            // 
            this.tabComparacion.Controls.Add(this.dgvResultados);
            this.tabComparacion.Location = new System.Drawing.Point(4, 34);
            this.tabComparacion.Name = "tabComparacion";
            this.tabComparacion.Padding = new System.Windows.Forms.Padding(3);
            this.tabComparacion.Size = new System.Drawing.Size(662, 182);
            this.tabComparacion.TabIndex = 0;
            this.tabComparacion.Text = "Comparación";
            this.tabComparacion.UseVisualStyleBackColor = true;
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
            this.dgvResultados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResultados.Location = new System.Drawing.Point(3, 3);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.ReadOnly = true;
            this.dgvResultados.RowHeadersWidth = 62;
            this.dgvResultados.RowTemplate.Height = 28;
            this.dgvResultados.Size = new System.Drawing.Size(656, 176);
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
            // tabInterpolaciones
            // 
            this.tabInterpolaciones.Controls.Add(this.dgvIteraciones);
            this.tabInterpolaciones.Location = new System.Drawing.Point(4, 34);
            this.tabInterpolaciones.Name = "tabInterpolaciones";
            this.tabInterpolaciones.Padding = new System.Windows.Forms.Padding(3);
            this.tabInterpolaciones.Size = new System.Drawing.Size(662, 182);
            this.tabInterpolaciones.TabIndex = 1;
            this.tabInterpolaciones.Text = "Interpolaciones De Casteljau";
            this.tabInterpolaciones.UseVisualStyleBackColor = true;
            // 
            // dgvIteraciones
            // 
            this.dgvIteraciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIteraciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIteraciones.Location = new System.Drawing.Point(3, 3);
            this.dgvIteraciones.Name = "dgvIteraciones";
            this.dgvIteraciones.RowHeadersWidth = 62;
            this.dgvIteraciones.RowTemplate.Height = 28;
            this.dgvIteraciones.Size = new System.Drawing.Size(656, 176);
            this.dgvIteraciones.TabIndex = 0;
            // 
            // lblErrorMaximo
            // 
            this.lblErrorMaximo.AutoSize = true;
            this.lblErrorMaximo.Location = new System.Drawing.Point(20, 225);
            this.lblErrorMaximo.Name = "lblErrorMaximo";
            this.lblErrorMaximo.Size = new System.Drawing.Size(142, 25);
            this.lblErrorMaximo.TabIndex = 3;
            this.lblErrorMaximo.Text = "Error máximo: --";
            // 
            // lblErrorPromedio
            // 
            this.lblErrorPromedio.AutoSize = true;
            this.lblErrorPromedio.Location = new System.Drawing.Point(20, 175);
            this.lblErrorPromedio.Name = "lblErrorPromedio";
            this.lblErrorPromedio.Size = new System.Drawing.Size(157, 25);
            this.lblErrorPromedio.TabIndex = 2;
            this.lblErrorPromedio.Text = "Error promedio: --";
            // 
            // lblTiempoCasteljau
            // 
            this.lblTiempoCasteljau.AutoSize = true;
            this.lblTiempoCasteljau.Location = new System.Drawing.Point(20, 125);
            this.lblTiempoCasteljau.Name = "lblTiempoCasteljau";
            this.lblTiempoCasteljau.Size = new System.Drawing.Size(226, 25);
            this.lblTiempoCasteljau.TabIndex = 1;
            this.lblTiempoCasteljau.Text = "Tiempo De Casteljau: -- ms";
            // 
            // lblTiempoDirecto
            // 
            this.lblTiempoDirecto.AutoSize = true;
            this.lblTiempoDirecto.Location = new System.Drawing.Point(20, 75);
            this.lblTiempoDirecto.Name = "lblTiempoDirecto";
            this.lblTiempoDirecto.Size = new System.Drawing.Size(235, 25);
            this.lblTiempoDirecto.TabIndex = 0;
            this.lblTiempoDirecto.Text = "Tiempo Bézier directo: -- ms";
            // 
            // FrmBezier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1350, 700);
            this.Controls.Add(this.grpResultados);
            this.Controls.Add(this.grpVisualizacion);
            this.Controls.Add(this.grpConfiguracion);
            this.Controls.Add(this.grpPuntos);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1100, 700);
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
            this.tabResultados.ResumeLayout(false);
            this.tabComparacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
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