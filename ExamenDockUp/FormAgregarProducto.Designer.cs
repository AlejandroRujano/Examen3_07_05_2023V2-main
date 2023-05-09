using System.Windows.Forms;

namespace Vender_Bosquejo_2
{
    partial class FormAgregarProducto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgregarProducto));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPosicion = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblRegresar = new System.Windows.Forms.Label();
            this.picRegresar = new System.Windows.Forms.PictureBox();
            this.lblTituloLista = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.dtgvListaDeProductos = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRegresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListaDeProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblPosicion);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblRegresar);
            this.panel1.Controls.Add(this.picRegresar);
            this.panel1.Controls.Add(this.lblTituloLista);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.txtCantidad);
            this.panel1.Controls.Add(this.lblCantidad);
            this.panel1.Controls.Add(this.dtgvListaDeProductos);
            this.panel1.Location = new System.Drawing.Point(9, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 265);
            this.panel1.TabIndex = 0;
            // 
            // lblPosicion
            // 
            this.lblPosicion.AutoSize = true;
            this.lblPosicion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPosicion.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosicion.Location = new System.Drawing.Point(296, 8);
            this.lblPosicion.Name = "lblPosicion";
            this.lblPosicion.Padding = new System.Windows.Forms.Padding(4);
            this.lblPosicion.Size = new System.Drawing.Size(144, 30);
            this.lblPosicion.TabIndex = 65;
            this.lblPosicion.Text = "Posicion del index";
            this.lblPosicion.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::ExamenDockUp.Properties.Resources.Suma;
            this.pictureBox1.Location = new System.Drawing.Point(621, 219);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 64;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblRegresar
            // 
            this.lblRegresar.AutoSize = true;
            this.lblRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRegresar.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblRegresar.Location = new System.Drawing.Point(49, 229);
            this.lblRegresar.Name = "lblRegresar";
            this.lblRegresar.Size = new System.Drawing.Size(76, 21);
            this.lblRegresar.TabIndex = 63;
            this.lblRegresar.Text = "Regresar";
            this.lblRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // picRegresar
            // 
            this.picRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRegresar.Image = global::ExamenDockUp.Properties.Resources.Regresar1;
            this.picRegresar.Location = new System.Drawing.Point(7, 218);
            this.picRegresar.Name = "picRegresar";
            this.picRegresar.Size = new System.Drawing.Size(42, 42);
            this.picRegresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRegresar.TabIndex = 62;
            this.picRegresar.TabStop = false;
            this.picRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // lblTituloLista
            // 
            this.lblTituloLista.AutoSize = true;
            this.lblTituloLista.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloLista.Location = new System.Drawing.Point(13, 10);
            this.lblTituloLista.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloLista.Name = "lblTituloLista";
            this.lblTituloLista.Size = new System.Drawing.Size(149, 21);
            this.lblTituloLista.TabIndex = 61;
            this.lblTituloLista.Text = "Lista de Productos";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(482, 224);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(132, 31);
            this.btnAgregar.TabIndex = 60;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(270, 223);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(170, 26);
            this.txtCantidad.TabIndex = 58;
            this.txtCantidad.Text = "0";
            this.txtCantidad.Enter += new System.EventHandler(this.txtCantidad_Enter);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(187, 226);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(75, 20);
            this.lblCantidad.TabIndex = 59;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // dtgvListaDeProductos
            // 
            this.dtgvListaDeProductos.AllowUserToAddRows = false;
            this.dtgvListaDeProductos.AllowUserToResizeColumns = false;
            this.dtgvListaDeProductos.AllowUserToResizeRows = false;
            this.dtgvListaDeProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgvListaDeProductos.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dtgvListaDeProductos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgvListaDeProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvListaDeProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvListaDeProductos.ColumnHeadersHeight = 36;
            this.dtgvListaDeProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvListaDeProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Descripcion,
            this.Precio,
            this.Cantidad});
            this.dtgvListaDeProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtgvListaDeProductos.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dtgvListaDeProductos.Location = new System.Drawing.Point(7, 42);
            this.dtgvListaDeProductos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtgvListaDeProductos.MultiSelect = false;
            this.dtgvListaDeProductos.Name = "dtgvListaDeProductos";
            this.dtgvListaDeProductos.ReadOnly = true;
            this.dtgvListaDeProductos.RowHeadersVisible = false;
            this.dtgvListaDeProductos.RowHeadersWidth = 51;
            this.dtgvListaDeProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.dtgvListaDeProductos.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgvListaDeProductos.RowTemplate.Height = 32;
            this.dtgvListaDeProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtgvListaDeProductos.Size = new System.Drawing.Size(653, 170);
            this.dtgvListaDeProductos.TabIndex = 57;
            this.dtgvListaDeProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvListaDeProductos_CellContentClick);
            // 
            // Codigo
            // 
            this.Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            this.Codigo.DefaultCellStyle = dataGridViewCellStyle2;
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Codigo.Width = 120;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(3);
            this.Nombre.DefaultCellStyle = dataGridViewCellStyle3;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Nombre.Width = 120;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(3);
            this.Descripcion.DefaultCellStyle = dataGridViewCellStyle4;
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Descripcion.Width = 220;
            // 
            // Precio
            // 
            this.Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(3);
            this.Precio.DefaultCellStyle = dataGridViewCellStyle5;
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Precio.Width = 95;
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(3);
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle6;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Cantidad.Width = 95;
            // 
            // FormAgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(688, 281);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(708, 324);
            this.MinimumSize = new System.Drawing.Size(708, 324);
            this.Name = "FormAgregarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Agregar Producto";
            this.Load += new System.EventHandler(this.FormAgregarProducto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRegresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListaDeProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label lblPosicion;
        private PictureBox pictureBox1;
        private Label lblRegresar;
        private PictureBox picRegresar;
        private Label lblTituloLista;
        private Button btnAgregar;
        private TextBox txtCantidad;
        private Label lblCantidad;
        private DataGridView dtgvListaDeProductos;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cantidad;
    }
}