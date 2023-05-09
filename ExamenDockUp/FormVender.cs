using borrador;
using DatosEmpresa;
using ExamenDockUp;
using Microsoft.Office.Interop.Excel;
using Microsoft.Vbe.Interop;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vender_Bosquejo_2
{
    public partial class FormVender : Form
    {
        private int n = -1;
        private int NumeroDeFacturas = -1;
        private double _precioBase = 0;
        private double _precioFinal = 0;
        private double _porcentaje = 0;
        private long _cantidadSeleccionada = 0;
        private List<Cliente> _clientes = new List<Cliente>();
        private List<Factura> _Facturas = new List<Factura>();
        private List<Productos> _compras = new List<Productos>(); //Carrito del Comprador
        private List<Productos> _productosDisponibles = new List<Productos>(); //Productos disponibles
        private List<Productos> _productosListaOriginal = new List<Productos>(); //Todos los productos, contando hasta los ya "Eliminados"
        private List<string> _datosEmpresa = new List<string>();
        private Usuario _vendedor = new Usuario();
        private FormFactura Factura = new FormFactura();
        private FormAgregarProducto ListaDeProductos = new FormAgregarProducto();
        private FormAgregarCliente AgregarCliente = new FormAgregarCliente();
        private string _pathFacturas = "";
        private string _pathClientes = "";
        private string _pathProductos = "";
        private string _pathDatosEmpresa = "";
        public FormVender()
        {
            InitializeComponent();
            Location = new System.Drawing.Point(0, Screen.PrimaryScreen.WorkingArea.Height - Height);
        }
        public List<string> DatosEmpresa { get { return _datosEmpresa; } set { _datosEmpresa = value; } }
        public List<Productos> Productos { get { return _productosListaOriginal; } set { _productosListaOriginal = value; } }
        public List<Cliente> Clientes { get { return _clientes; } set { _clientes = value; } }
        public Usuario Vendedor { get { return _vendedor; } set { _vendedor = value; } }
        public string PathClientes { get { return _pathClientes; } set { _pathClientes = value; } }
        public string PathFacturas { get { return _pathFacturas; } set { _pathFacturas = value; } }
        public string PathProductos { get { return _pathProductos; } set { _pathProductos = value; } }
        public string PathDatosEmpresa { get { return _pathDatosEmpresa; } set { _pathDatosEmpresa = value;} }
        private void LeerListaDeFacturas()
        {
            try { _Facturas = JsonConvert.DeserializeObject<List<Factura>>(File.ReadAllText(_pathFacturas)); }
            catch { }
        }
        private void ConectarInformacion()
        {
            //Se le pasan los Datos Necesarios a la Ventana de Agregar Producto
            ListaDeProductos.Productos = ListaProductosDisponibles();
            ListaDeProductos.ComprasCliente = _compras;
            ListaDeProductos.CantidadSeleccionada = _cantidadSeleccionada;
            ListaDeProductos.PrecioBase = _precioBase;
            ListaDeProductos.PrecioFinal = _precioFinal;

            //Aqui Le pasamos referencia de la tabla y de los Label de los Precios a
            //la ventana de Agregar Producto; con el objetivo de que se pueda modificar
            //el contenido de cada una desde la siguiente ventana(Agregar Producto)

            ListaDeProductos.DataGrid = dtgvPreview;
            ListaDeProductos.lblPrecioBase = lblBase;
            ListaDeProductos.lblPrecioFinal = lblPrecioFinal;

            //Aqui se pasan los datos necesarios para hacer la factura
            //y en caso de que se facture, se manda a limpiar el carrito de compras,
            //El combo box de clientes, etc...

            Factura.Vendedor = _vendedor;
            Factura.ProductosOriginales = _productosListaOriginal;
            Factura.ProductosDisponibles = _productosDisponibles;
            Factura.Compras = _compras;
            Factura.Path = _pathFacturas;
            Factura.DatosEmpresa = _datosEmpresa;
            Factura.CBClientes = cbBoxClientes;
            Factura.DataPreview = dtgvPreview;
            Factura.PathProductos = _pathProductos;
            Factura.Facturas = _Facturas;

            AgregarCliente.ListaClientes = _clientes;
            AgregarCliente.PathClientes = _pathClientes;
        }
        private List<Productos> ListaProductosDisponibles()
        {
            //Cada vez que se llame a la funcion, se limpia la lista de productos disponibles

            _productosDisponibles.Clear();

            _productosDisponibles = _productosListaOriginal.Where(_producto => _producto.Disponible == true).ToList();

            /*for (int i = 0; i < _productosListaOriginal.Count; i++)
            {
                if (_productosListaOriginal[i].Disponible == true)
                {
                    _productosDisponibles.Add(_productosListaOriginal[i]);
                    //_productosDisponibles.Add(new Productos(productos[i]._codigo, productos[i]._nombre, productos[i]._descripcion, productos[i]._cantidad, productos[i]._precio));
                }
            }*/

            //Luego de revisar cuales productos estan disponibles de la lista original;
            //osea que tengan marcados el check box de disponible en la ventana de gestion de productos
            //se guardan en la lista de productos disponibles y se retorna

            //NOTA: Me acabo de dar cuenta que el return es innecesario XD; ya que dentro del for
            //directamente se esta llenando la lista que vamos a utilizar

            return _productosDisponibles;
        }
        private void ReiniciarDatosCliente() //Combo Box Clientes
        {
            LlenarComboBoxClientes();
            cbBoxClientes.SelectedIndex = -1;
            cbBoxClientes.Text = "Seleccionar";
            lblDatosCliente.Text = "No Seleccionado";
        }
        private void ReiniciarPrecios()
        {
            _precioBase = 0;
            _precioFinal = 0;
            lblBase.Text = _precioBase.ToString();
            lblPrecioFinal.Text = _precioFinal.ToString();
        }
        private void LlenarComboBoxClientes()
        {
            cbBoxClientes.Items.Clear();
            for(int i=0; i<_clientes.Count; i++)
            {
                cbBoxClientes.Items.Add(_clientes[i].Identificacion());
            }
        }
        private void CantidadesSeleccionadas()
        {
            //Esta Funcion se utiliza para evitar un bug que habia con las cantidades
            //Esta funcion es llamada luego de que se cierre la ventana de agregar producto
            //y sirve para asignar que cantidades se seleccionaron para cada producto del carrito

            for(int i = 0; i < ListaDeProductos.ComprasCliente.Count; i++)
            {
                _compras[i].Cantidad = ListaDeProductos.ComprasCliente[i].Cantidad;
            }
        }
        private void btnListaProductos_Click(object sender, EventArgs e)
        {
            ListaDeProductos.ComprasCliente = _compras;
            ListaDeProductos.ShowDialog();
            //SumarColumnas();
            LlenarTablaProductos(_compras);
            CantidadesSeleccionadas();
            SumarFila();
            CalcularIva();
        }       
        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            int RespaldoCantidadDeClientes = _clientes.Count;
            AgregarCliente.ShowDialog();

            //Si en la ventana de agregar cliente; se crea algun cliente; se procede a mostrar sus
            //datos en los Label y en el Combo Box

            if(RespaldoCantidadDeClientes != _clientes.Count)
            {
                LlenarComboBoxClientes();
                cbBoxClientes.SelectedIndex = _clientes.Count - 1;
                lblDatosCliente.Text = _clientes[cbBoxClientes.SelectedIndex].Identificacion();
            }
        }
        private void FormVenderV2_Load(object sender, EventArgs e)
        {
            LeerListaDeFacturas();
            ConectarInformacion();
            n = -1;
            NumeroDeFacturas = _Facturas.Count;

            lblVendedor.Text = $"{_vendedor.Nombre} {_vendedor.Apellido}";
            lblFechaActual.Text = $"{ DateTime.Now.Day}/{ DateTime.Now.Month}/{ DateTime.Now.Year}";            
            lblBase.Text = _precioBase.ToString();
            lblPrecioFinal.Text = _precioFinal.ToString();
            lblPosicion.Visible = false;

            _compras.Clear();
            dtgvPreview.Rows.Clear();

            ReiniciarDatosCliente();
            ReiniciarPrecios();
        }
        private void SumarFila()
        {
            _precioBase = 0;
            foreach (DataGridViewRow row in dtgvPreview.Rows)
            {
                _precioBase += Convert.ToDouble(row.Cells["PrecioTotal"].Value);                
            }
            lblBase.Text = Convert.ToString(_precioBase);
        }

       /* private void SumarColumnas()
        {           
                foreach (DataGridViewRow row in dtgvPreview.Rows)
                {
                    row.Cells["PrecioTotal"].Value = Convert.ToDouble(row.Cells["Precio"].Value) * Convert.ToDouble(row.Cells["Cantidad"].Value);
                //MessageBox.Show($"{row.Cells["PrecioTotal"].Value}");
                }                           
        }*/
        private void CalcularIva()
        {           
            _porcentaje = (_precioBase * 16)/100;
            _precioFinal = _porcentaje + _precioBase;
            lblPrecioFinal.Text = Convert.ToString(_precioFinal);                        
        }
        private int ProductoCorrespondiente(List<Productos> ListaProductos)
        {
            //Esta funcion nos sirve para recorrer las listas y saber cual producto se va a borrar
            //Por eso es que se retorna un entero llamado Posicion
            //Asi pues sabiendo su posicion en la lista de productos disponibles
            //podemos devolver la cantidad seleccionada (Producto en el Carrito)
            //al Inventario de la Empresa (Lista de Productos Disponibles)

            int Posicion = -1;

            for (int i = 0; i < ListaProductos.Count; i++)
            {
                if (dtgvPreview[0, n].Value.ToString() == ListaProductos[i].Codigo)
                {
                    Posicion = i;
                    break;
                }
            }
            return Posicion;
        }
        private void AutoSeleccionadoDeUltimaFila()
        {
            dtgvPreview.CurrentCell = dtgvPreview[0, dtgvPreview.RowCount - 1];
            n = dtgvPreview.RowCount - 1;
            lblPosicion.Text = $"Numero de Fila del Producto Seleccionado: {n + 1}";
            lblPosicion.Visible = true;
        }
        private void EliminarProductoDelCarrito()
        {
            _productosDisponibles[ProductoCorrespondiente(_productosDisponibles)].Cantidad += _compras[n].Cantidad;
            _compras.RemoveAt(ProductoCorrespondiente(_compras));
            dtgvPreview.Rows.RemoveAt(n);
            SumarFila();
            CalcularIva();
            if (n > 0)
            {
                AutoSeleccionadoDeUltimaFila();
            }
            else if (n == 0) lblPosicion.Visible = false;
        }
        private void dtgvPreview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            n = e.RowIndex;
            lblPosicion.Visible = true;
            lblPosicion.Text = $"Numero de Fila del Producto Seleccionado: {e.RowIndex + 1}";
            //columna de borrar
            if (e.ColumnIndex == 8)
            {

                try
                {
                    if (n != -1 && dtgvPreview.Rows.Count > 0)
                    {
                        if (MessageBox.Show($"¿Esta Seguro que desea Eliminar al Producto Indicado?\n\n {_compras[ProductoCorrespondiente(_compras)].Data_Codigo()}", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            EliminarProductoDelCarrito();
                        }
                    }
                    else if (n == -1)
                    {
                        throw new Exception("No se ha Seleccionado Ningun Producto a Eliminar");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                //Borrar el precio del producto al borrar el producto
                /*foreach (DataGridViewRow row in dtgvPreview.Rows)
                {
                    PrecioBase -= Convert.ToDouble(row.Cells["PrecioTotal"].Value);
                }*/
                //lblBase.Text = Convert.ToString(_precioBase);

                /*foreach (DataGridViewRow row in dtgvPreview.Rows)
                {
                    PrecioFinal -= Convert.ToDouble(row.Cells["PrecioTotal"].Value);
                }
                //lblPrecioFinal.Text = Convert.ToString(_precioFinal);
                */
            }
        }
        private void btnFacturar_Click_1(object sender, EventArgs e)
        {
            if (_compras.Count > 0)
            {
                if (_datosEmpresa.Count != 0)
                {
                    if(cbBoxClientes.SelectedIndex != -1)
                    {
                        if (DialogResult.Yes == MessageBox.Show("El Cliente es un Contribuidor Especial?", "Retenciones", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
                        {
                            Factura.Retencion = 75;
                        }
                        else Factura.Retencion = 0;
                        Factura.Compras = _compras;
                        Factura.Impuesto = _porcentaje;
                        Factura.SubTotal = _precioBase;
                        Factura.Total = _precioFinal;
                        Factura.Cliente = _clientes[cbBoxClientes.SelectedIndex];
                        Factura.lblPrecio = lblBase;
                        Factura.lblPrecioTotal = lblPrecioFinal;
                        Factura.PathDatosEmpresa = _pathDatosEmpresa;
                        Factura.ShowDialog();
                    }
                    else MessageBox.Show("No se ha Seleccionado al Cliente a Facturar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show("No se han definido los Datos de la Empresa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("No se ha Seleccionado producto Alguno a Vender", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void cbBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbBoxClientes.SelectedIndex != -1)
            {
                lblDatosCliente.Text = _clientes[cbBoxClientes.SelectedIndex].Identificacion();
            }
            else
            {
                lblDatosCliente.Text = "No Seleccionado";
            }
        }

        private void lblRegresar_Click(object sender, EventArgs e)
        {
            this.Close();            
        }

        private void FormVender_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Cuando se cierra esta ventana se verifica que el numero de facturas no haya cambiado
            //Osea que no se haya facturado; en caso de que si se haya facturado, dejamos las cantidades
            //de los productos tal cual como se hayan restado

            if(NumeroDeFacturas == _Facturas.Count)
            {
                for(int i=0; i<_productosDisponibles.Count; i++)
                {
                    for(int j=0; j<_compras.Count; j++)
                    {
                        if (_compras[j].Codigo == _productosDisponibles[i].Codigo)
                        {
                            _productosDisponibles[i].Cantidad += _compras[j].Cantidad;
                        }
                    }
                }
            }
        }

        private void btnOrdenarCodigo_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> DataOrden = (from item in dtgvPreview.Rows.Cast<DataGridViewRow>()
                                               orderby item.Cells[0].Value ascending
                                               select item).ToList<DataGridViewRow>();
            dtgvPreview.Sort(dtgvPreview.Columns[0], ListSortDirection.Ascending);

        }
        private void LlenarTablaProductos(List<Productos> ListaDeProductos)
        {
            //Funcion para llenar la tabla con la lista de productos disponibles CON 
            //modificaciones. Se llama entonces para cuando se ha reorganizado
            //o filtrado a traves del txt del buscador
            //Por lo cual es necesario pasarle por parametros cual es la lista que
            //debe mostrar

            dtgvPreview.Rows.Clear();
            if (_productosListaOriginal.Count != 0 && ListaDeProductos.Count != 0)
            {
                dtgvPreview.Rows.Add(ListaDeProductos.Count);

                for (int i = 0; i < ListaDeProductos.Count; i++)
                {
                    for (int j = 0; j < dtgvPreview.Columns.Count; j++)
                    {
                        if (j == 0) dtgvPreview[j, i].Value = ListaDeProductos[i].Codigo;
                        else if (j == 1) dtgvPreview[j, i].Value = ListaDeProductos[i].Nombre;
                        else if (j == 2) dtgvPreview[j, i].Value = ListaDeProductos[i].Descripcion;
                        else if (j == 3) dtgvPreview[j, i].Value = ListaDeProductos[i].Precio;
                        else if (j == 4) dtgvPreview[j, i].Value = ListaDeProductos[i].Cantidad;
                        else if (j == 5) dtgvPreview[j, i].Value = ListaDeProductos[i].Precio * ListaDeProductos[i].Cantidad;
                    }
                }
            }
        }
        private void btnOrdenarNombre_Click(object sender, EventArgs e)
        {
            List<Productos> ListaAsendente = new List<Productos>();

            var orden = dtgvPreview.Columns[1].SortMode;
            switch (orden)
            {
                case (DataGridViewColumnSortMode)SortOrder.None:

                case (DataGridViewColumnSortMode)SortOrder.Ascending:

                    ListaAsendente = (from ValorL in _compras
                                      orderby ValorL.Nombre descending
                                      select ValorL).ToList<Productos>();
                    _compras = ListaAsendente;
                    //LlenarTablaProductosNueva(_productosDisponibles);
                    LlenarTablaProductos(_compras);
                    dtgvPreview.Columns[1].SortMode = (DataGridViewColumnSortMode)SortOrder.Descending;
                    break;

                case (DataGridViewColumnSortMode)SortOrder.Descending:
                    ListaAsendente = (from ValorL in _compras
                                      orderby ValorL.Nombre ascending
                                      select ValorL).ToList<Productos>();
                    _compras = ListaAsendente;
                    LlenarTablaProductos(_compras);
                    //LlenarTablaProductosNueva(_productosDisponibles);
                    dtgvPreview.Columns[1].SortMode = (DataGridViewColumnSortMode)SortOrder.Ascending;
                    break;
            }
        }

        private void dtgvPreview_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            n = e.RowIndex;
            if(e.ColumnIndex == 6 && n != -1)
            {
                if(e.Button == MouseButtons.Left)
                {
                    if (_productosDisponibles[ProductoCorrespondiente(_productosDisponibles)].Cantidad > 0)
                    {
                        dtgvPreview[6, n].Style.SelectionBackColor = Color.GreenYellow;

                        _compras[ProductoCorrespondiente(_compras)].Cantidad = _compras[ProductoCorrespondiente(_compras)].Cantidad + 1;

                        _productosDisponibles[ProductoCorrespondiente(_productosDisponibles)].Cantidad -= 1;

                        dtgvPreview[4, n].Value = _compras[ProductoCorrespondiente(_compras)].Cantidad;
                    }
                    else MessageBox.Show("No hay Cantidad suficiente en el\nInventario para Agregar al Carrito", "Inventario Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if(e.Button == MouseButtons.Right)
                {
                    if (_productosDisponibles[ProductoCorrespondiente(_productosDisponibles)].Cantidad >= 10)
                    {
                        dtgvPreview[6, n].Style.SelectionBackColor = Color.YellowGreen;

                        dtgvPreview.CurrentCell = dtgvPreview[6, n];

                        _compras[ProductoCorrespondiente(_compras)].Cantidad = _compras[ProductoCorrespondiente(_compras)].Cantidad + 10;

                        _productosDisponibles[ProductoCorrespondiente(_productosDisponibles)].Cantidad -= 10;

                        dtgvPreview[4, n].Value = _compras[ProductoCorrespondiente(_compras)].Cantidad;
                    }
                    else MessageBox.Show("No hay Cantidad suficiente en el\nInventario para Agregar al Carrito", "Inventario Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                dtgvPreview[5, n].Value = _compras[ProductoCorrespondiente(_compras)].Cantidad * _compras[ProductoCorrespondiente(_compras)].Precio;
                
                SumarFila();
                CalcularIva();
            }
            else if(e.ColumnIndex == 7 && n!= -1)
            {
                if(e.Button == MouseButtons.Left) 
                {
                    if (_compras[ProductoCorrespondiente(_compras)].Cantidad > 1)
                    {
                        dtgvPreview[7, n].Style.SelectionBackColor = Color.IndianRed;

                        _compras[ProductoCorrespondiente(_compras)].Cantidad = _compras[ProductoCorrespondiente(_compras)].Cantidad - 1;

                        _productosDisponibles[ProductoCorrespondiente(_productosDisponibles)].Cantidad += 1;

                        dtgvPreview[4, n].Value = _compras[ProductoCorrespondiente(_compras)].Cantidad;
                    }
                    else if (_compras[ProductoCorrespondiente(_compras)].Cantidad == 1)
                    {
                        if(DialogResult.Yes == MessageBox.Show("Debido a que la cantidad deseada a eliminar\nEs Igual a la cantidad disponible en el carrito de\nCompras se procedera a eliminar el producto\n\nEsta de Acuerdo?","Desea Eliminar el Producto del Carrito", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
                        {
                            EliminarProductoDelCarrito();
                        }
                    }
                }
                else if(e.Button == MouseButtons.Right) 
                {
                    if (_compras[ProductoCorrespondiente(_compras)].Cantidad > 10)
                    {
                        dtgvPreview[7, n].Style.SelectionBackColor = Color.Crimson;

                        dtgvPreview.CurrentCell = dtgvPreview[7, n];

                        _compras[ProductoCorrespondiente(_compras)].Cantidad = _compras[ProductoCorrespondiente(_compras)].Cantidad - 10;

                        _productosDisponibles[ProductoCorrespondiente(_productosDisponibles)].Cantidad += 10;

                        dtgvPreview[4, n].Value = _compras[ProductoCorrespondiente(_compras)].Cantidad;
                    }
                    else if (_compras[ProductoCorrespondiente(_compras)].Cantidad <= 10)
                    {
                        if (DialogResult.Yes == MessageBox.Show("Debido a que la cantidad deseada a eliminar\nEs Mayor o igual a la cantidad disponible en el carrito de\nCompras se procedera a eliminar el producto\n\nEsta de Acuerdo?", "Desea Eliminar el Producto del Carrito", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
                        {
                            EliminarProductoDelCarrito();
                        }
                    }
                }
                dtgvPreview[5, n].Value = _compras[ProductoCorrespondiente(_compras)].Cantidad * _compras[ProductoCorrespondiente(_compras)].Precio;
               
                SumarFila();
                CalcularIva();
            }
        }
    }
}