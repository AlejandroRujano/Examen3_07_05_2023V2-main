namespace ExamenDockUp
{
    partial class frmEditarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditarProducto));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtxtDescripcion = new System.Windows.Forms.RichTextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.ptrGuardar = new System.Windows.Forms.PictureBox();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrGuardar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Controls.Add(this.rtxtDescripcion);
            this.groupBox1.Controls.Add(this.lblCantidad);
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.ptrGuardar);
            this.groupBox1.Controls.Add(this.btnGuardarCambios);
            this.groupBox1.Controls.Add(this.lblPrecio);
            this.groupBox1.Controls.Add(this.lblDescripcion);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 422);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Del Producto";
            // 
            // rtxtDescripcion
            // 
            this.rtxtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtDescripcion.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.rtxtDescripcion.Location = new System.Drawing.Point(17, 255);
            this.rtxtDescripcion.Name = "rtxtDescripcion";
            this.rtxtDescripcion.Size = new System.Drawing.Size(245, 96);
            this.rtxtDescripcion.TabIndex = 4;
            this.rtxtDescripcion.Text = "";
            // 
            // lblCantidad
            // 
            this.lblCantidad.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblCantidad.Location = new System.Drawing.Point(92, 165);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(100, 21);
            this.lblCantidad.TabIndex = 9;
            this.lblCantidad.Text = "Cantidad";
            this.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(17, 189);
            this.txtCantidad.MaxLength = 11;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(245, 28);
            this.txtCantidad.TabIndex = 3;
            // 
            // ptrGuardar
            // 
            this.ptrGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptrGuardar.Image = global::ExamenDockUp.Properties.Resources.check;
            this.ptrGuardar.Location = new System.Drawing.Point(180, 370);
            this.ptrGuardar.Name = "ptrGuardar";
            this.ptrGuardar.Size = new System.Drawing.Size(38, 39);
            this.ptrGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptrGuardar.TabIndex = 7;
            this.ptrGuardar.TabStop = false;
            this.ptrGuardar.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.BackColor = System.Drawing.Color.White;
            this.btnGuardarCambios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuardarCambios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarCambios.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnGuardarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCambios.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCambios.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnGuardarCambios.Location = new System.Drawing.Point(96, 376);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(78, 33);
            this.btnGuardarCambios.TabIndex = 5;
            this.btnGuardarCambios.Text = "Guardar ";
            this.btnGuardarCambios.UseVisualStyleBackColor = false;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // lblPrecio
            // 
            this.lblPrecio.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblPrecio.Location = new System.Drawing.Point(92, 99);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(100, 21);
            this.lblPrecio.TabIndex = 5;
            this.lblPrecio.Text = "Precio";
            this.lblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblDescripcion.Location = new System.Drawing.Point(92, 231);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(100, 21);
            this.lblDescripcion.TabIndex = 4;
            this.lblDescripcion.Text = "Descripción";
            this.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombre
            // 
            this.lblNombre.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblNombre.Location = new System.Drawing.Point(92, 35);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(100, 21);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(17, 123);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(245, 28);
            this.txtPrecio.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(17, 59);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(245, 28);
            this.txtNombre.TabIndex = 0;
            // 
            // frmEditarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(304, 443);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(320, 482);
            this.MinimumSize = new System.Drawing.Size(320, 482);
            this.Name = "frmEditarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Producto";
            this.Load += new System.EventHandler(this.frmEditarProducto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrGuardar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.PictureBox ptrGuardar;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.RichTextBox rtxtDescripcion;
    }
}