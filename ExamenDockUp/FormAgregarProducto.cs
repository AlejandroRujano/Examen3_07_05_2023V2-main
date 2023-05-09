using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using borrador;
using DatosEmpresa;
using Newtonsoft.Json;
using System.Collections;
using System.IO;
using ExamenDockUp;

namespace Vender_Bosquejo_2
{
    public partial class FormAgregarProducto : Form
    {
        private int n = -1;
        private int m = -1;
        private long _cantidadSeleccionada = 0;
        private double _precioBase = 0;
        private double _precioFinal = 0;
        private List<Productos> _compras = new List<Productos>(); //Carrito del Comprador
        private List<Productos> _productos = new List<Productos>(); //Productos Disponibles
        private DataGridView CopiaPreview = new DataGridView();
        private Label lblBase = new Label();
        private Label lblFinal = new Label();
        public double PrecioBase { get { return _precioBase; } set { _precioBase = value; } }
        public double PrecioFinal { get { return _precioFinal; } set { _precioFinal = value; } }
        public long CantidadSeleccionada { get { return _cantidadSeleccionada; } set { _cantidadSeleccionada=value; } }
        public List<Productos> Productos { get { return _productos; } set { _productos = value; } }
        public List<Productos> ComprasCliente { get { return _compras; } set { _compras = value; } }
        public DataGridView DataGrid { get { return CopiaPreview; } set { CopiaPreview = value; } }
        public Label lblPrecioBase { get { return lblBase; } set { lblBase = value; } }
        public Label lblPrecioFinal { get { return lblFinal; } set { lblFinal = value; } }
        public FormAgregarProducto()
        {
            InitializeComponent();
            Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - Width, 0);
        }
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private int ProductoRepetido()
        {
            //Esta funcion nos sirve para reconocer si el siguiente producto que se va a anadir 
            //al carrito ya esta repetido, por lo cual se revisa la tabla de productos;
            //en caso de que si este repetido, retorna la posicion en la lista de productos disponibles
            //del producto que se debe evitar copiar de nuevo en la tabla

            int Posicion = -1;
            for (int i = 0; i < CopiaPreview.Rows.Count; i++)
            {
                if (CopiaPreview[0, i].Value.ToString() == _productos[n].Codigo) 
                { 
                    Posicion = i;
                    break;
                }
            }
            return Posicion;
        }
        private void SumarFila()
        {
            _precioBase = 0;
            foreach (DataGridViewRow row in CopiaPreview.Rows)
            {
                _precioBase += Convert.ToDouble(row.Cells["PrecioTotal"].Value);
            }
            lblBase.Text = Convert.ToString(_precioBase);
        }
        private void CalcularIva()
        {            
            double Porcentaje = 0;
            Porcentaje = (_precioBase * 16) / 100;
            _precioFinal = Porcentaje + _precioBase;
            lblPrecioFinal.Text = Convert.ToString(_precioFinal);            
        }
        private void RefrescarTabla()
        {
            dtgvListaDeProductos.Rows.Clear();
            if (Productos.Count != 0)
            {
                dtgvListaDeProductos.Rows.Add(Productos.Count);

                for (int i = 0; i < Productos.Count; i++)
                {
                    for (int j = 0; j < dtgvListaDeProductos.Columns.Count; j++)
                    {
                        if (j == 0) dtgvListaDeProductos[j, i].Value = _productos[i].Codigo;
                        else if (j == 1) dtgvListaDeProductos[j, i].Value = _productos[i].Nombre;
                        else if (j == 2) dtgvListaDeProductos[j, i].Value = _productos[i].Descripcion;
                        else if (j == 3) dtgvListaDeProductos[j, i].Value = _productos[i].Precio;
                        else if (j == 4) dtgvListaDeProductos[j, i].Value = _productos[i].Cantidad;
                    }
                }

            }
            else MessageBox.Show("No existe Producto alguno para mostrar", "Inexistencia de Productos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        private void FormAgregarProducto_Load(object sender, EventArgs e)
        {
            n = -1;
            lblPosicion.Visible = false;
            RefrescarTabla();
            txtCantidad.Text = "0";
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(n != -1)
            {
                try
                {
                    if (string.IsNullOrEmpty(txtCantidad.Text)) { throw new Exception("El campo de cantidad no puede quedar vacio"); }
                    if (!long.TryParse(txtCantidad.Text, out _cantidadSeleccionada))
                    {
                        throw new Exception("El formato de la Cantidad es Incorrecto.\nNo se permite el uso de Caracteres");
                    }
                    if (_cantidadSeleccionada <= 0) { throw new Exception("No puede aniadir una cantidad que no existe"); }
                    if (_cantidadSeleccionada > _productos[n].Cantidad) { throw new Exception("No hay suficiente Inventario del Producto Seleccionado"); }

                    //Estos long son para evitar un bug con las cantidades

                    long RespaldoCantidadInventario = _productos[n].Cantidad;
                    long RespaldoCantidadSeleccionada = _cantidadSeleccionada;

                    if (ProductoRepetido() == -1)
                    {
                        _compras.Add(new Productos(_productos[n].Codigo, _productos[n].Nombre, _productos[n].Descripcion, _cantidadSeleccionada, _productos[n].Precio));
                        int aux = CopiaPreview.Rows.Add();
                        CopiaPreview[0, aux].Value = _productos[n].Codigo;
                        CopiaPreview[1, aux].Value = _productos[n].Nombre;
                        CopiaPreview[2, aux].Value = _productos[n].Descripcion;
                        CopiaPreview[3, aux].Value = _productos[n].Precio;
                        CopiaPreview[4, aux].Value = _cantidadSeleccionada;
                        CopiaPreview[5, aux].Value = _cantidadSeleccionada * _productos[n].Precio;
                    }
                    else
                    {
                        long NuevaCantidad = _cantidadSeleccionada + Convert.ToInt64(CopiaPreview[4, ProductoRepetido()].Value);
                        CopiaPreview[4, ProductoRepetido()].Value = NuevaCantidad;
                        CopiaPreview[5, ProductoRepetido()].Value = Convert.ToInt32(NuevaCantidad) * _productos[n].Precio;
                        _compras[ProductoRepetido()].Cantidad = NuevaCantidad;
                    }
                    _productos[n].Cantidad = _productos[n].Cantidad - _cantidadSeleccionada;
                    RefrescarTabla();
                    dtgvListaDeProductos.CurrentCell = dtgvListaDeProductos[m, n];
                    SumarFila();
                    CalcularIva();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else MessageBox.Show("No ha Seleccionado Producto Alguno a Agregar","Por Favor Seleccione Algun Producto",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
        }

        private void dtgvListaDeProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            n = e.RowIndex;
            m = e.ColumnIndex;
            lblPosicion.Visible = true;
            lblPosicion.Text = $"Numero de Fila del Producto Seleccionado: {e.RowIndex + 1}";
        }
        private void txtCantidad_Enter(object sender, EventArgs e)
        {
            txtCantidad.Text = "";
        }
    }
}
