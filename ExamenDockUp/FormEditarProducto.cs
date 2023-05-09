using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenDockUp
{
    public partial class frmEditarProducto : Form
    {
        private List<Productos> productosOriginales = new List<Productos>();
        private List<Productos> productos = new List<Productos>();
        private string _pathProductos = "";
        private int _index = -1;
        public List<Productos> ListaDeProductosOriginales {  get { return productosOriginales; } set { productosOriginales = value; } }
        public List<Productos> ListaProductos { get { return productos; } set { productos = value; } }
        public string PathProductos { get { return _pathProductos; } set { _pathProductos = value; } }
        public int Index { get { return _index; } set { _index = value; } }
        public frmEditarProducto()
        {
            InitializeComponent();
        }
        private int BuscarProductoCorrespondiente()
        {
            int Posicion = -1;

            Posicion = productosOriginales.FindIndex(x => x.Codigo == productos[_index].Codigo);

            return Posicion;
        }
        private void EditarDatosProductos()
        {
            int _indexListaOriginal = BuscarProductoCorrespondiente();

            productosOriginales[_indexListaOriginal].Nombre = txtNombre.Text;
            productosOriginales[_indexListaOriginal].Precio = Convert.ToDouble(txtPrecio.Text);
            productosOriginales[_indexListaOriginal].Cantidad = int.Parse(txtCantidad.Text);
            productosOriginales[_indexListaOriginal].Descripcion = rtxtDescripcion.Text;

            productos[_index].Nombre = txtNombre.Text;
            productos[_index].Precio = Convert.ToDouble(txtPrecio.Text);
            productos[_index].Cantidad = int.Parse(txtCantidad.Text);
            productos[_index].Descripcion = rtxtDescripcion.Text;
        }
        private void GuardarProductos()
        {
            string ProductosJson = JsonConvert.SerializeObject(ListaDeProductosOriginales.ToArray(), Formatting.Indented);
            File.WriteAllText(_pathProductos, ProductosJson);
            MessageBox.Show("Guardado Exitosamente");
        }
        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
                try
                {
                    string nombre = txtNombre.Text;
                    double precio = 0;
                    string descripcion = rtxtDescripcion.Text;
                    int cantidad = 0;

                    if (!double.TryParse(txtPrecio.Text, out precio))
                    {
                        throw new Exception("El precio introducido no es válido");
                    }
                    if (precio < 0)
                    {
                        throw new Exception("El Precio Indicado no es valido\nNo se manejan valores negativos");
                    }
                    if (txtPrecio.Text == null)
                    {
                        throw new Exception("El Campo del Precio esta Vacio!");
                    }
                    //Descripcion
                    if (string.IsNullOrEmpty(descripcion))
                    {
                        throw new Exception("Descripcion invalida");
                    }
                    //Cantidad
                    if (!int.TryParse(txtCantidad.Text, out cantidad))
                    {
                        throw new Exception("La cantidad introducida no es válida");
                    }
                    if (cantidad < 0)
                    {
                        throw new Exception("La Cantidad Indicada no es valida\nNo se manejan valores negativos");
                    }
                    //Nombre
                    if (string.IsNullOrEmpty(nombre))
                    {
                        throw new Exception("El Campo del nombre esta vacio!");
                    }

                    EditarDatosProductos();
                    GuardarProductos();
                    Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
        }
        private void frmEditarProducto_Load(object sender, EventArgs e)
        {
            txtNombre.Text = productos[_index].Nombre;
            txtCantidad.Text = productos[_index].Cantidad.ToString();
            rtxtDescripcion.Text = productos[_index].Descripcion;
            txtPrecio.Text = productos[_index].Precio.ToString();
        }
    }
}
