using System.Windows.Forms;

namespace DatosEmpresa
{
    partial class FormGestionDatosEmpresa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestionDatosEmpresa));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRegresar = new System.Windows.Forms.Label();
            this.PicRegresar = new System.Windows.Forms.PictureBox();
            this.PictureInfo = new System.Windows.Forms.PictureBox();
            this.dtgvEmpleados = new System.Windows.Forms.DataGridView();
            this.lblPosicion = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRif = new System.Windows.Forms.TextBox();
            this.txtNomEmpresa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAgregarVen = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Borrar = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicRegresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.dataGridViewImageColumn1.Frozen = true;
            this.dataGridViewImageColumn1.HeaderText = "Editar";
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 70;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblRegresar);
            this.panel1.Controls.Add(this.PicRegresar);
            this.panel1.Controls.Add(this.PictureInfo);
            this.panel1.Controls.Add(this.dtgvEmpleados);
            this.panel1.Controls.Add(this.lblPosicion);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnAgregarVen);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(959, 439);
            this.panel1.TabIndex = 6;
            // 
            // lblRegresar
            // 
            this.lblRegresar.AutoSize = true;
            this.lblRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRegresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblRegresar.Location = new System.Drawing.Point(53, 393);
            this.lblRegresar.Name = "lblRegresar";
            this.lblRegresar.Size = new System.Drawing.Size(71, 20);
            this.lblRegresar.TabIndex = 8;
            this.lblRegresar.Text = "Regresar";
            this.lblRegresar.Click += new System.EventHandler(this.PicRegresar_Click);
            // 
            // PicRegresar
            // 
            this.PicRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicRegresar.Image = global::ExamenDockUp.Properties.Resources.Regresar1;
            this.PicRegresar.Location = new System.Drawing.Point(13, 385);
            this.PicRegresar.Name = "PicRegresar";
            this.PicRegresar.Size = new System.Drawing.Size(40, 40);
            this.PicRegresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicRegresar.TabIndex = 49;
            this.PicRegresar.TabStop = false;
            this.PicRegresar.Click += new System.EventHandler(this.PicRegresar_Click);
            // 
            // PictureInfo
            // 
            this.PictureInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureInfo.Image = global::ExamenDockUp.Properties.Resources.Interrogacion;
            this.PictureInfo.Location = new System.Drawing.Point(172, 21);
            this.PictureInfo.Name = "PictureInfo";
            this.PictureInfo.Size = new System.Drawing.Size(36, 36);
            this.PictureInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureInfo.TabIndex = 48;
            this.PictureInfo.TabStop = false;
            this.PictureInfo.Click += new System.EventHandler(this.PictureInfo_Click);
            // 
            // dtgvEmpleados
            // 
            this.dtgvEmpleados.AllowUserToAddRows = false;
            this.dtgvEmpleados.AllowUserToDeleteRows = false;
            this.dtgvEmpleados.AllowUserToResizeColumns = false;
            this.dtgvEmpleados.AllowUserToResizeRows = false;
            this.dtgvEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvEmpleados.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dtgvEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgvEmpleados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dtgvEmpleados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvEmpleados.ColumnHeadersHeight = 36;
            this.dtgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Apellido,
            this.Cedula,
            this.Editar,
            this.Borrar});
            this.dtgvEmpleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtgvEmpleados.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dtgvEmpleados.Location = new System.Drawing.Point(14, 68);
            this.dtgvEmpleados.MultiSelect = false;
            this.dtgvEmpleados.Name = "dtgvEmpleados";
            this.dtgvEmpleados.ReadOnly = true;
            this.dtgvEmpleados.RowHeadersVisible = false;
            this.dtgvEmpleados.RowHeadersWidth = 20;
            this.dtgvEmpleados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.dtgvEmpleados.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgvEmpleados.RowTemplate.Height = 32;
            this.dtgvEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtgvEmpleados.Size = new System.Drawing.Size(656, 307);
            this.dtgvEmpleados.TabIndex = 1;
            this.dtgvEmpleados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvEmpleados_CellClick);
            // 
            // lblPosicion
            // 
            this.lblPosicion.AutoSize = true;
            this.lblPosicion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPosicion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPosicion.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosicion.Location = new System.Drawing.Point(154, 393);
            this.lblPosicion.Name = "lblPosicion";
            this.lblPosicion.Padding = new System.Windows.Forms.Padding(4);
            this.lblPosicion.Size = new System.Drawing.Size(116, 26);
            this.lblPosicion.TabIndex = 46;
            this.lblPosicion.Text = "Posicion del index";
            this.lblPosicion.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::ExamenDockUp.Properties.Resources.Suma;
            this.pictureBox1.Location = new System.Drawing.Point(630, 383);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.btnAgregarVen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 21);
            this.label1.TabIndex = 43;
            this.label1.Text = "Lista de Empleados";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtCorreo);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtRif);
            this.groupBox1.Controls.Add(this.txtNomEmpresa);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(685, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 383);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la Empresa";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label8.Location = new System.Drawing.Point(6, 263);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(2);
            this.label8.Size = new System.Drawing.Size(140, 25);
            this.label8.TabIndex = 19;
            this.label8.Text = "Correo Electronico";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.txtCorreo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCorreo.Location = new System.Drawing.Point(15, 289);
            this.txtCorreo.MaxLength = 255;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(227, 25);
            this.txtCorreo.TabIndex = 5;
            this.txtCorreo.Text = "No Asignado";
            this.txtCorreo.Enter += new System.EventHandler(this.txtCorreo_Enter);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.txtDireccion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDireccion.Location = new System.Drawing.Point(15, 213);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(227, 25);
            this.txtDireccion.TabIndex = 4;
            this.txtDireccion.Text = "No Asignada";
            this.txtDireccion.Enter += new System.EventHandler(this.txtDireccion_Enter);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.RosyBrown;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(68, 336);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(127, 32);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar Datos";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardarDatosEmpresa_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.Location = new System.Drawing.Point(6, 187);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(2);
            this.label5.Size = new System.Drawing.Size(78, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Direccion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label7.Location = new System.Drawing.Point(6, 113);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(6, 2, 8, 2);
            this.label7.Size = new System.Drawing.Size(43, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Rif";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRif
            // 
            this.txtRif.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.txtRif.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtRif.Location = new System.Drawing.Point(15, 139);
            this.txtRif.Name = "txtRif";
            this.txtRif.Size = new System.Drawing.Size(227, 25);
            this.txtRif.TabIndex = 3;
            this.txtRif.Text = "No Asignado";
            this.txtRif.Enter += new System.EventHandler(this.txtRif_Enter);
            // 
            // txtNomEmpresa
            // 
            this.txtNomEmpresa.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.txtNomEmpresa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtNomEmpresa.Location = new System.Drawing.Point(15, 65);
            this.txtNomEmpresa.Name = "txtNomEmpresa";
            this.txtNomEmpresa.Size = new System.Drawing.Size(227, 25);
            this.txtNomEmpresa.TabIndex = 2;
            this.txtNomEmpresa.Text = "TuProductoOnline";
            this.txtNomEmpresa.Enter += new System.EventHandler(this.txtNomEmpresa_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.label6.Location = new System.Drawing.Point(42, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.Location = new System.Drawing.Point(6, 39);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(2);
            this.label4.Size = new System.Drawing.Size(169, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nombre de la Empresa";
            // 
            // btnAgregarVen
            // 
            this.btnAgregarVen.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAgregarVen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarVen.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAgregarVen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAgregarVen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnAgregarVen.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarVen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregarVen.Location = new System.Drawing.Point(464, 390);
            this.btnAgregarVen.Margin = new System.Windows.Forms.Padding(0);
            this.btnAgregarVen.Name = "btnAgregarVen";
            this.btnAgregarVen.Size = new System.Drawing.Size(151, 31);
            this.btnAgregarVen.TabIndex = 1;
            this.btnAgregarVen.Text = "Agregar Vendedor";
            this.btnAgregarVen.UseVisualStyleBackColor = false;
            this.btnAgregarVen.Click += new System.EventHandler(this.btnAgregarVen_Click);
            // 
            // dataGridViewImageColumn2
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle8.NullValue")));
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(1);
            this.dataGridViewImageColumn2.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewImageColumn2.FillWeight = 52.00856F;
            this.dataGridViewImageColumn2.HeaderText = "Editar";
            this.dataGridViewImageColumn2.Image = global::ExamenDockUp.Properties.Resources.editar;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Width = 68;
            // 
            // dataGridViewImageColumn3
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle9.NullValue")));
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(1);
            this.dataGridViewImageColumn3.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewImageColumn3.FillWeight = 34.63952F;
            this.dataGridViewImageColumn3.HeaderText = "Borrar";
            this.dataGridViewImageColumn3.Image = global::ExamenDockUp.Properties.Resources.Eliminar;
            this.dataGridViewImageColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn3.MinimumWidth = 6;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.ReadOnly = true;
            this.dataGridViewImageColumn3.Width = 60;
            // 
            // Nombre
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            this.Nombre.DefaultCellStyle = dataGridViewCellStyle2;
            this.Nombre.FillWeight = 88.3683F;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Apellido
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(3);
            this.Apellido.DefaultCellStyle = dataGridViewCellStyle3;
            this.Apellido.FillWeight = 87.66776F;
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.MinimumWidth = 6;
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            this.Apellido.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Cedula
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomLeft;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(3);
            this.Cedula.DefaultCellStyle = dataGridViewCellStyle4;
            this.Cedula.FillWeight = 134.2088F;
            this.Cedula.HeaderText = "Cedula de Identidad";
            this.Cedula.MinimumWidth = 6;
            this.Cedula.Name = "Cedula";
            this.Cedula.ReadOnly = true;
            this.Cedula.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Editar
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle5.NullValue")));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(1);
            this.Editar.DefaultCellStyle = dataGridViewCellStyle5;
            this.Editar.FillWeight = 34.22592F;
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = global::ExamenDockUp.Properties.Resources.editar;
            this.Editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Editar.MinimumWidth = 6;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            // 
            // Borrar
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle6.NullValue")));
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(1);
            this.Borrar.DefaultCellStyle = dataGridViewCellStyle6;
            this.Borrar.FillWeight = 34.63952F;
            this.Borrar.HeaderText = "Borrar";
            this.Borrar.Image = global::ExamenDockUp.Properties.Resources.image1;
            this.Borrar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Borrar.MinimumWidth = 6;
            this.Borrar.Name = "Borrar";
            this.Borrar.ReadOnly = true;
            // 
            // FormGestionDatosEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(984, 462);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.linkLabel1);
            this.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1000, 501);
            this.MinimumSize = new System.Drawing.Size(1000, 501);
            this.Name = "FormGestionDatosEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos de la Empresa";
            this.Load += new System.EventHandler(this.FormGestionEmpresa_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicRegresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private LinkLabel linkLabel1;
        private DataGridViewImageColumn dataGridViewImageColumn1;
        private Panel panel1;
        private DataGridView dtgvEmpleados;
        private Label lblPosicion;
        private PictureBox pictureBox1;
        private Label label1;
        private GroupBox groupBox1;
        private Label label8;
        private TextBox txtCorreo;
        private TextBox txtDireccion;
        private Button btnGuardar;
        private Label label5;
        private Label label7;
        private TextBox txtRif;
        private TextBox txtNomEmpresa;
        private Label label6;
        private Label label4;
        private Button btnAgregarVen;
        private PictureBox PictureInfo;
        private DataGridViewImageColumn dataGridViewImageColumn2;
        private PictureBox PicRegresar;
        private Label lblRegresar;
        private DataGridViewImageColumn dataGridViewImageColumn3;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Cedula;
        private DataGridViewImageColumn Editar;
        private DataGridViewImageColumn Borrar;
    }
}