using System.Windows.Forms;

namespace Vender_Bosquejo_2
{
    partial class FormVender
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVender));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOrdenarNombre = new System.Windows.Forms.Button();
            this.btnOrdenarCodigo = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPosicion = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblRegresar = new System.Windows.Forms.Label();
            this.lblDatosCliente = new System.Windows.Forms.Label();
            this.lblDatosDelCliente = new System.Windows.Forms.Label();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.lblDatosVendedor = new System.Windows.Forms.Label();
            this.btnListaProductos = new System.Windows.Forms.Button();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblPrecioBase = new System.Windows.Forms.Label();
            this.lblBase = new System.Windows.Forms.Label();
            this.lblFinal = new System.Windows.Forms.Label();
            this.lblFechaActual = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.cbBoxClientes = new System.Windows.Forms.ComboBox();
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.lblPrecioFinal = new System.Windows.Forms.Label();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.dtgvPreview = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sumar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Restar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Borrar = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnOrdenarNombre);
            this.panel1.Controls.Add(this.btnOrdenarCodigo);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblPosicion);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblRegresar);
            this.panel1.Controls.Add(this.lblDatosCliente);
            this.panel1.Controls.Add(this.lblDatosDelCliente);
            this.panel1.Controls.Add(this.lblVendedor);
            this.panel1.Controls.Add(this.lblDatosVendedor);
            this.panel1.Controls.Add(this.btnListaProductos);
            this.panel1.Controls.Add(this.lblCliente);
            this.panel1.Controls.Add(this.lblPrecioBase);
            this.panel1.Controls.Add(this.lblBase);
            this.panel1.Controls.Add(this.lblFinal);
            this.panel1.Controls.Add(this.lblFechaActual);
            this.panel1.Controls.Add(this.lblFecha);
            this.panel1.Controls.Add(this.cbBoxClientes);
            this.panel1.Controls.Add(this.btnNuevoCliente);
            this.panel1.Controls.Add(this.lblPrecioFinal);
            this.panel1.Controls.Add(this.btnFacturar);
            this.panel1.Controls.Add(this.dtgvPreview);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1160, 677);
            this.panel1.TabIndex = 0;
            // 
            // btnOrdenarNombre
            // 
            this.btnOrdenarNombre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrdenarNombre.Location = new System.Drawing.Point(262, 195);
            this.btnOrdenarNombre.Name = "btnOrdenarNombre";
            this.btnOrdenarNombre.Size = new System.Drawing.Size(82, 26);
            this.btnOrdenarNombre.TabIndex = 88;
            this.btnOrdenarNombre.Text = "Nombre";
            this.btnOrdenarNombre.UseVisualStyleBackColor = true;
            this.btnOrdenarNombre.Click += new System.EventHandler(this.btnOrdenarNombre_Click);
            // 
            // btnOrdenarCodigo
            // 
            this.btnOrdenarCodigo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrdenarCodigo.Location = new System.Drawing.Point(100, 193);
            this.btnOrdenarCodigo.Name = "btnOrdenarCodigo";
            this.btnOrdenarCodigo.Size = new System.Drawing.Size(74, 28);
            this.btnOrdenarCodigo.TabIndex = 87;
            this.btnOrdenarCodigo.Text = "Codigo";
            this.btnOrdenarCodigo.UseVisualStyleBackColor = true;
            this.btnOrdenarCodigo.Click += new System.EventHandler(this.btnOrdenarCodigo_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::ExamenDockUp.Properties.Resources.AZ1;
            this.pictureBox4.Location = new System.Drawing.Point(203, 186);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(53, 35);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 82;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.btnOrdenarNombre_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::ExamenDockUp.Properties.Resources.ordenar_Codigo1;
            this.pictureBox3.Location = new System.Drawing.Point(39, 185);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(51, 36);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 81;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.btnOrdenarCodigo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 78;
            this.label2.Text = "Ordernar por :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 77;
            this.label1.Text = "Ordenar por :";
            // 
            // lblPosicion
            // 
            this.lblPosicion.AutoSize = true;
            this.lblPosicion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPosicion.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosicion.Location = new System.Drawing.Point(176, 632);
            this.lblPosicion.Name = "lblPosicion";
            this.lblPosicion.Padding = new System.Windows.Forms.Padding(4);
            this.lblPosicion.Size = new System.Drawing.Size(160, 31);
            this.lblPosicion.TabIndex = 76;
            this.lblPosicion.Text = "Posicion del index";
            this.lblPosicion.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::ExamenDockUp.Properties.Resources.Factura;
            this.pictureBox2.Location = new System.Drawing.Point(1086, 625);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 75;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.btnFacturar_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::ExamenDockUp.Properties.Resources.Regresar1;
            this.pictureBox1.Location = new System.Drawing.Point(11, 626);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 73;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.lblRegresar_Click);
            // 
            // lblRegresar
            // 
            this.lblRegresar.AutoSize = true;
            this.lblRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRegresar.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblRegresar.Location = new System.Drawing.Point(54, 634);
            this.lblRegresar.Name = "lblRegresar";
            this.lblRegresar.Size = new System.Drawing.Size(76, 21);
            this.lblRegresar.TabIndex = 72;
            this.lblRegresar.Text = "Regresar";
            this.lblRegresar.Click += new System.EventHandler(this.lblRegresar_Click);
            // 
            // lblDatosCliente
            // 
            this.lblDatosCliente.AutoSize = true;
            this.lblDatosCliente.Location = new System.Drawing.Point(555, 65);
            this.lblDatosCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatosCliente.Name = "lblDatosCliente";
            this.lblDatosCliente.Size = new System.Drawing.Size(88, 20);
            this.lblDatosCliente.TabIndex = 71;
            this.lblDatosCliente.Text = "Sin Asignar";
            // 
            // lblDatosDelCliente
            // 
            this.lblDatosDelCliente.AutoSize = true;
            this.lblDatosDelCliente.Location = new System.Drawing.Point(541, 39);
            this.lblDatosDelCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatosDelCliente.Name = "lblDatosDelCliente";
            this.lblDatosDelCliente.Size = new System.Drawing.Size(131, 20);
            this.lblDatosDelCliente.TabIndex = 70;
            this.lblDatosDelCliente.Text = "Datos del Cliente:";
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Location = new System.Drawing.Point(307, 65);
            this.lblVendedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(94, 20);
            this.lblVendedor.TabIndex = 69;
            this.lblVendedor.Text = "lblVendedor";
            // 
            // lblDatosVendedor
            // 
            this.lblDatosVendedor.AutoSize = true;
            this.lblDatosVendedor.Location = new System.Drawing.Point(304, 39);
            this.lblDatosVendedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatosVendedor.Name = "lblDatosVendedor";
            this.lblDatosVendedor.Size = new System.Drawing.Size(151, 20);
            this.lblDatosVendedor.TabIndex = 68;
            this.lblDatosVendedor.Text = "Datos del Vendedor:";
            // 
            // btnListaProductos
            // 
            this.btnListaProductos.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnListaProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListaProductos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListaProductos.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaProductos.ForeColor = System.Drawing.Color.White;
            this.btnListaProductos.Location = new System.Drawing.Point(781, 68);
            this.btnListaProductos.Margin = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.btnListaProductos.Name = "btnListaProductos";
            this.btnListaProductos.Size = new System.Drawing.Size(246, 41);
            this.btnListaProductos.TabIndex = 57;
            this.btnListaProductos.Text = "Lista de Productos";
            this.btnListaProductos.UseVisualStyleBackColor = false;
            this.btnListaProductos.Click += new System.EventHandler(this.btnListaProductos_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(16, 3);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(61, 20);
            this.lblCliente.TabIndex = 67;
            this.lblCliente.Text = "Cliente:";
            // 
            // lblPrecioBase
            // 
            this.lblPrecioBase.AutoSize = true;
            this.lblPrecioBase.Location = new System.Drawing.Point(583, 635);
            this.lblPrecioBase.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPrecioBase.Name = "lblPrecioBase";
            this.lblPrecioBase.Size = new System.Drawing.Size(93, 20);
            this.lblPrecioBase.TabIndex = 66;
            this.lblPrecioBase.Text = "Precio Base:";
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Location = new System.Drawing.Point(683, 636);
            this.lblBase.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(59, 20);
            this.lblBase.TabIndex = 65;
            this.lblBase.Text = "lblBase";
            // 
            // lblFinal
            // 
            this.lblFinal.AutoSize = true;
            this.lblFinal.Location = new System.Drawing.Point(746, 636);
            this.lblFinal.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(93, 20);
            this.lblFinal.TabIndex = 64;
            this.lblFinal.Text = "Precio Final:";
            // 
            // lblFechaActual
            // 
            this.lblFechaActual.AutoSize = true;
            this.lblFechaActual.Location = new System.Drawing.Point(852, 23);
            this.lblFechaActual.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFechaActual.Name = "lblFechaActual";
            this.lblFechaActual.Size = new System.Drawing.Size(111, 20);
            this.lblFechaActual.TabIndex = 63;
            this.lblFechaActual.Text = "lblFechaActual";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(784, 23);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(53, 20);
            this.lblFecha.TabIndex = 62;
            this.lblFecha.Text = "Fecha:";
            // 
            // cbBoxClientes
            // 
            this.cbBoxClientes.FormattingEnabled = true;
            this.cbBoxClientes.Location = new System.Drawing.Point(26, 39);
            this.cbBoxClientes.Margin = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.cbBoxClientes.Name = "cbBoxClientes";
            this.cbBoxClientes.Size = new System.Drawing.Size(223, 26);
            this.cbBoxClientes.TabIndex = 55;
            this.cbBoxClientes.Text = "Seleccionar";
            this.cbBoxClientes.SelectedIndexChanged += new System.EventHandler(this.cbBoxClientes_SelectedIndexChanged);
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNuevoCliente.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNuevoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoCliente.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoCliente.ForeColor = System.Drawing.Color.White;
            this.btnNuevoCliente.Location = new System.Drawing.Point(27, 85);
            this.btnNuevoCliente.Margin = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(197, 44);
            this.btnNuevoCliente.TabIndex = 56;
            this.btnNuevoCliente.Text = "Crear Nuevo Cliente";
            this.btnNuevoCliente.UseVisualStyleBackColor = false;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // lblPrecioFinal
            // 
            this.lblPrecioFinal.AutoSize = true;
            this.lblPrecioFinal.Location = new System.Drawing.Point(846, 637);
            this.lblPrecioFinal.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPrecioFinal.Name = "lblPrecioFinal";
            this.lblPrecioFinal.Size = new System.Drawing.Size(59, 20);
            this.lblPrecioFinal.TabIndex = 60;
            this.lblPrecioFinal.Text = "lblFinal";
            // 
            // btnFacturar
            // 
            this.btnFacturar.BackColor = System.Drawing.Color.YellowGreen;
            this.btnFacturar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFacturar.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.btnFacturar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.YellowGreen;
            this.btnFacturar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            this.btnFacturar.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturar.ForeColor = System.Drawing.Color.White;
            this.btnFacturar.Location = new System.Drawing.Point(932, 632);
            this.btnFacturar.Margin = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(147, 33);
            this.btnFacturar.TabIndex = 61;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.UseVisualStyleBackColor = false;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click_1);
            // 
            // dtgvPreview
            // 
            this.dtgvPreview.AllowUserToAddRows = false;
            this.dtgvPreview.AllowUserToResizeColumns = false;
            this.dtgvPreview.AllowUserToResizeRows = false;
            this.dtgvPreview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvPreview.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dtgvPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgvPreview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dtgvPreview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvPreview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvPreview.ColumnHeadersHeight = 36;
            this.dtgvPreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvPreview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Descripcion,
            this.Precio,
            this.Cantidad,
            this.PrecioTotal,
            this.Sumar,
            this.Restar,
            this.Borrar});
            this.dtgvPreview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtgvPreview.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dtgvPreview.Location = new System.Drawing.Point(27, 227);
            this.dtgvPreview.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvPreview.MultiSelect = false;
            this.dtgvPreview.Name = "dtgvPreview";
            this.dtgvPreview.ReadOnly = true;
            this.dtgvPreview.RowHeadersVisible = false;
            this.dtgvPreview.RowHeadersWidth = 20;
            this.dtgvPreview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            this.dtgvPreview.RowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dtgvPreview.RowTemplate.Height = 32;
            this.dtgvPreview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtgvPreview.Size = new System.Drawing.Size(1103, 391);
            this.dtgvPreview.TabIndex = 58;
            this.dtgvPreview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvPreview_CellContentClick);
            this.dtgvPreview.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgvPreview_CellMouseClick);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle12.NullValue")));
            dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(1);
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewImageColumn1.HeaderText = "Borrar";
            this.dataGridViewImageColumn1.Image = global::ExamenDockUp.Properties.Resources.Eliminar;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 70;
            // 
            // Codigo
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            this.Codigo.DefaultCellStyle = dataGridViewCellStyle2;
            this.Codigo.FillWeight = 50F;
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Nombre
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(3);
            this.Nombre.DefaultCellStyle = dataGridViewCellStyle3;
            this.Nombre.FillWeight = 99.88752F;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Descripcion
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(3);
            this.Descripcion.DefaultCellStyle = dataGridViewCellStyle4;
            this.Descripcion.FillWeight = 99.88752F;
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Precio
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(3);
            this.Precio.DefaultCellStyle = dataGridViewCellStyle5;
            this.Precio.FillWeight = 99.88752F;
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Cantidad
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(3);
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle6;
            this.Cantidad.FillWeight = 99.88752F;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // PrecioTotal
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(3);
            this.PrecioTotal.DefaultCellStyle = dataGridViewCellStyle7;
            this.PrecioTotal.FillWeight = 99.88752F;
            this.PrecioTotal.HeaderText = "Precio Total";
            this.PrecioTotal.MinimumWidth = 8;
            this.PrecioTotal.Name = "PrecioTotal";
            this.PrecioTotal.ReadOnly = true;
            this.PrecioTotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Sumar
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle8.NullValue")));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            this.Sumar.DefaultCellStyle = dataGridViewCellStyle8;
            this.Sumar.FillWeight = 40F;
            this.Sumar.HeaderText = "Sumar";
            this.Sumar.Image = global::ExamenDockUp.Properties.Resources.sumar_agregar_compra;
            this.Sumar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Sumar.Name = "Sumar";
            this.Sumar.ReadOnly = true;
            // 
            // Restar
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle9.NullValue")));
            this.Restar.DefaultCellStyle = dataGridViewCellStyle9;
            this.Restar.FillWeight = 40F;
            this.Restar.HeaderText = "Restar";
            this.Restar.Image = global::ExamenDockUp.Properties.Resources.menos;
            this.Restar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Restar.Name = "Restar";
            this.Restar.ReadOnly = true;
            // 
            // Borrar
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle10.NullValue")));
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(1);
            this.Borrar.DefaultCellStyle = dataGridViewCellStyle10;
            this.Borrar.FillWeight = 40F;
            this.Borrar.HeaderText = "Borrar";
            this.Borrar.Image = global::ExamenDockUp.Properties.Resources.image1;
            this.Borrar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Borrar.Name = "Borrar";
            this.Borrar.ReadOnly = true;
            // 
            // FormVender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1184, 701);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.MaximumSize = new System.Drawing.Size(1200, 988);
            this.MinimumSize = new System.Drawing.Size(1200, 740);
            this.Name = "FormVender";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Vender";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormVender_FormClosing);
            this.Load += new System.EventHandler(this.FormVenderV2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label lblRegresar;
        private Label lblDatosCliente;
        private Label lblDatosDelCliente;
        private Label lblVendedor;
        private Label lblDatosVendedor;
        private Button btnListaProductos;
        private Label lblCliente;
        private Label lblPrecioBase;
        private Label lblBase;
        private Label lblFinal;
        private Label lblFechaActual;
        private Label lblFecha;
        private ComboBox cbBoxClientes;
        private Button btnNuevoCliente;
        private Label lblPrecioFinal;
        private Button btnFacturar;
        private DataGridView dtgvPreview;
        private Label lblPosicion;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private DataGridViewImageColumn dataGridViewImageColumn1;
        private Button btnOrdenarNombre;
        private Button btnOrdenarCodigo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn PrecioTotal;
        private DataGridViewImageColumn Sumar;
        private DataGridViewImageColumn Restar;
        private DataGridViewImageColumn Borrar;
    }
}