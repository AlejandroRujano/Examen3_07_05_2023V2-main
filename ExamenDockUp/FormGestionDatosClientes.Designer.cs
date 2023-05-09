using System.Windows.Forms;

namespace DatosEmpresa
{
    partial class FormGestionDatosClientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestionDatosClientes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.dtgvClientes = new System.Windows.Forms.DataGridView();
            this.btnExportar = new System.Windows.Forms.Button();
            this.picbExportar = new System.Windows.Forms.PictureBox();
            this.btnImportar = new System.Windows.Forms.Button();
            this.picbImportar = new System.Windows.Forms.PictureBox();
            this.lblRegresar = new System.Windows.Forms.Label();
            this.PicRegresar = new System.Windows.Forms.PictureBox();
            this.lblPosicion = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DireccionImportar = new System.Windows.Forms.OpenFileDialog();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Borrar = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbExportar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbImportar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicRegresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(255, 73);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 20);
            this.linkLabel1.TabIndex = 5;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn1.FillWeight = 108.9028F;
            this.dataGridViewImageColumn1.HeaderText = "Editar";
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 70;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnAgregarCliente);
            this.panel1.Controls.Add(this.dtgvClientes);
            this.panel1.Controls.Add(this.btnExportar);
            this.panel1.Controls.Add(this.picbExportar);
            this.panel1.Controls.Add(this.btnImportar);
            this.panel1.Controls.Add(this.picbImportar);
            this.panel1.Controls.Add(this.lblRegresar);
            this.panel1.Controls.Add(this.PicRegresar);
            this.panel1.Controls.Add(this.lblPosicion);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 400);
            this.panel1.TabIndex = 30;
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAgregarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarCliente.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAgregarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAgregarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnAgregarCliente.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregarCliente.Location = new System.Drawing.Point(644, 353);
            this.btnAgregarCliente.Margin = new System.Windows.Forms.Padding(0);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(151, 31);
            this.btnAgregarCliente.TabIndex = 57;
            this.btnAgregarCliente.Text = "Agregar Cliente";
            this.btnAgregarCliente.UseVisualStyleBackColor = false;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // dtgvClientes
            // 
            this.dtgvClientes.AllowUserToAddRows = false;
            this.dtgvClientes.AllowUserToDeleteRows = false;
            this.dtgvClientes.AllowUserToResizeColumns = false;
            this.dtgvClientes.AllowUserToResizeRows = false;
            this.dtgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvClientes.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dtgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgvClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dtgvClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvClientes.ColumnHeadersHeight = 36;
            this.dtgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Apellido,
            this.Cedula,
            this.Telefono,
            this.Editar,
            this.Borrar});
            this.dtgvClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtgvClientes.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dtgvClientes.Location = new System.Drawing.Point(11, 60);
            this.dtgvClientes.MultiSelect = false;
            this.dtgvClientes.Name = "dtgvClientes";
            this.dtgvClientes.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dtgvClientes.RowHeadersVisible = false;
            this.dtgvClientes.RowHeadersWidth = 62;
            this.dtgvClientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.dtgvClientes.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dtgvClientes.RowTemplate.Height = 32;
            this.dtgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtgvClientes.Size = new System.Drawing.Size(833, 269);
            this.dtgvClientes.TabIndex = 56;
            this.dtgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvEmpleados_CellClick);
            // 
            // btnExportar
            // 
            this.btnExportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportar.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.Location = new System.Drawing.Point(694, 7);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(2);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(150, 40);
            this.btnExportar.TabIndex = 52;
            this.btnExportar.Text = "Exportar Clientes";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // picbExportar
            // 
            this.picbExportar.BackColor = System.Drawing.Color.Transparent;
            this.picbExportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbExportar.Image = global::ExamenDockUp.Properties.Resources.export_solid;
            this.picbExportar.Location = new System.Drawing.Point(644, 12);
            this.picbExportar.Name = "picbExportar";
            this.picbExportar.Size = new System.Drawing.Size(41, 31);
            this.picbExportar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbExportar.TabIndex = 55;
            this.picbExportar.TabStop = false;
            this.picbExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnImportar
            // 
            this.btnImportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImportar.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportar.Location = new System.Drawing.Point(454, 8);
            this.btnImportar.Margin = new System.Windows.Forms.Padding(2);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(150, 39);
            this.btnImportar.TabIndex = 53;
            this.btnImportar.Text = "Importar Clientes\r\n";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // picbImportar
            // 
            this.picbImportar.BackColor = System.Drawing.Color.Transparent;
            this.picbImportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbImportar.Image = global::ExamenDockUp.Properties.Resources.img_2646131;
            this.picbImportar.Location = new System.Drawing.Point(407, 15);
            this.picbImportar.Name = "picbImportar";
            this.picbImportar.Size = new System.Drawing.Size(42, 28);
            this.picbImportar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbImportar.TabIndex = 54;
            this.picbImportar.TabStop = false;
            this.picbImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // lblRegresar
            // 
            this.lblRegresar.AutoSize = true;
            this.lblRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRegresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblRegresar.Location = new System.Drawing.Point(51, 355);
            this.lblRegresar.Name = "lblRegresar";
            this.lblRegresar.Size = new System.Drawing.Size(71, 20);
            this.lblRegresar.TabIndex = 50;
            this.lblRegresar.Text = "Regresar";
            this.lblRegresar.Click += new System.EventHandler(this.PicRegresar_Click);
            // 
            // PicRegresar
            // 
            this.PicRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicRegresar.Image = global::ExamenDockUp.Properties.Resources.Regresar1;
            this.PicRegresar.Location = new System.Drawing.Point(11, 347);
            this.PicRegresar.Name = "PicRegresar";
            this.PicRegresar.Size = new System.Drawing.Size(40, 40);
            this.PicRegresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicRegresar.TabIndex = 51;
            this.PicRegresar.TabStop = false;
            this.PicRegresar.Click += new System.EventHandler(this.PicRegresar_Click);
            // 
            // lblPosicion
            // 
            this.lblPosicion.AutoSize = true;
            this.lblPosicion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPosicion.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosicion.Location = new System.Drawing.Point(216, 354);
            this.lblPosicion.Name = "lblPosicion";
            this.lblPosicion.Padding = new System.Windows.Forms.Padding(4);
            this.lblPosicion.Size = new System.Drawing.Size(131, 27);
            this.lblPosicion.TabIndex = 36;
            this.lblPosicion.Text = "Posicion del index";
            this.lblPosicion.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::ExamenDockUp.Properties.Resources.Suma;
            this.pictureBox1.Location = new System.Drawing.Point(804, 347);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 21);
            this.label1.TabIndex = 31;
            this.label1.Text = "Lista de Clientes";
            // 
            // DireccionImportar
            // 
            this.DireccionImportar.FileName = "Importar";
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle10.NullValue")));
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.dataGridViewImageColumn2.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewImageColumn2.FillWeight = 108.9028F;
            this.dataGridViewImageColumn2.HeaderText = "Editar";
            this.dataGridViewImageColumn2.Image = global::ExamenDockUp.Properties.Resources.editar;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn2.Width = 70;
            // 
            // dataGridViewImageColumn3
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle11.NullValue")));
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(1);
            this.dataGridViewImageColumn3.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewImageColumn3.FillWeight = 48.731F;
            this.dataGridViewImageColumn3.HeaderText = "Borrar";
            this.dataGridViewImageColumn3.Image = global::ExamenDockUp.Properties.Resources.Eliminar;
            this.dataGridViewImageColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.ReadOnly = true;
            this.dataGridViewImageColumn3.Width = 67;
            // 
            // Nombre
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            this.Nombre.DefaultCellStyle = dataGridViewCellStyle2;
            this.Nombre.FillWeight = 125.1748F;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Apellido
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(3);
            this.Apellido.DefaultCellStyle = dataGridViewCellStyle3;
            this.Apellido.FillWeight = 125.1748F;
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            this.Apellido.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Cedula
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(3);
            this.Cedula.DefaultCellStyle = dataGridViewCellStyle4;
            this.Cedula.FillWeight = 125.1748F;
            this.Cedula.HeaderText = "Cedula de Identidad";
            this.Cedula.Name = "Cedula";
            this.Cedula.ReadOnly = true;
            this.Cedula.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Telefono
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(3);
            this.Telefono.DefaultCellStyle = dataGridViewCellStyle5;
            this.Telefono.FillWeight = 125.1748F;
            this.Telefono.HeaderText = "N° de Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            this.Telefono.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Editar
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle6.NullValue")));
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Editar.DefaultCellStyle = dataGridViewCellStyle6;
            this.Editar.FillWeight = 50.57019F;
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = global::ExamenDockUp.Properties.Resources.editar;
            this.Editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            // 
            // Borrar
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle7.NullValue")));
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(1);
            this.Borrar.DefaultCellStyle = dataGridViewCellStyle7;
            this.Borrar.FillWeight = 48.731F;
            this.Borrar.HeaderText = "Borrar";
            this.Borrar.Image = global::ExamenDockUp.Properties.Resources.image2;
            this.Borrar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Borrar.Name = "Borrar";
            this.Borrar.ReadOnly = true;
            // 
            // FormGestionDatosClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(884, 424);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.linkLabel1);
            this.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(900, 463);
            this.MinimumSize = new System.Drawing.Size(900, 463);
            this.Name = "FormGestionDatosClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos de Clientes";
            this.Load += new System.EventHandler(this.FormGestionClientes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbExportar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbImportar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicRegresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private LinkLabel linkLabel1;
        private DataGridViewImageColumn dataGridViewImageColumn1;
        private Panel panel1;
        private Label lblPosicion;
        private PictureBox pictureBox1;
        private Label label1;
        private DataGridViewImageColumn dataGridViewImageColumn2;
        private Label lblRegresar;
        private PictureBox PicRegresar;
        private Button btnExportar;
        private PictureBox picbExportar;
        private Button btnImportar;
        private PictureBox picbImportar;
        private OpenFileDialog DireccionImportar;
        private DataGridView dtgvClientes;
        private DataGridViewImageColumn dataGridViewImageColumn3;
        private Button btnAgregarCliente;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Cedula;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewImageColumn Editar;
        private DataGridViewImageColumn Borrar;
    }
}