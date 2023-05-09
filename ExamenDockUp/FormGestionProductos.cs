using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;//importante
using ExamenDockUp;
using Newtonsoft.Json;
using Microsoft.Office.Interop.Excel;
using Vender_Bosquejo_2;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.Office.Core;
using System.CodeDom;
using System.Text.RegularExpressions;

namespace borrador
{
    public partial class FormGestionDeProductos : Form
    {
        private string _pathProductos = "";
        private static List<Productos> productos = new List<Productos>();
        private List<Productos> _productosDisponibles = new List<Productos>();
        private int n = -1;
        private frmEditarProducto EditarProductos = new frmEditarProducto();
        public List<Productos> ListaProductos { get { return productos; } set { productos = value; } }
        public string PathProductos { get { return _pathProductos; } set { _pathProductos = value; } }
        
        public FormGestionDeProductos()
        {
            InitializeComponent();
        }

        private void GuardarProductos()
        {
            string jsonProductos = JsonConvert.SerializeObject(ListaProductos.ToArray(), Formatting.Indented);
            txtCodigo.Text = ((productos.Count() + 1).ToString()).PadLeft(5, '0');
            File.WriteAllText(_pathProductos, jsonProductos);
        }
        private int ContarProductosDisponibles()
        {
            int Contador = 0;
            Contador = productos.Count(x => x.Eliminado == false);

            return Contador;
        }
        private void ListaProductosDisponibles()
        {
            _productosDisponibles.Clear();
            _productosDisponibles = productos.Where(_producto => _producto.Eliminado == false).ToList();
        }
        private int BuscarProductoCorrespondiente()
        {
            //CONTEXTO: en la tabla solo se muestran los productos de la lista llamada 
            //productos Disponibles (La cual esta compuesta por productos que no han sido eliminados)

            //Esta funcion nos sirve para identificar la posicion del producto seleccionado en la tabla 
            //y su correspondiente en la lista original (la cual esta compuesta por todos los productos;
            //incluyendo los que ya fueron "Eliminados".
            //Asi pues al encontrar dicha posicion se retorna

            //Se utiliza para modificar lo del check box en tiempo real
            //y para saber que producto debemos "Eliminar".

            int Posicion = -1;

            Posicion = productos.FindIndex(x => x.Codigo == dtgvProductos[0,n].Value.ToString());

            return Posicion;
        }
        private void BorrarProducto()
        {
            int Posicion = BuscarProductoCorrespondiente();
            productos[Posicion].Eliminado = true;
            productos[Posicion].Disponible = false;
            _productosDisponibles.RemoveAt(n);
            MessageBox.Show("El Producto ha sido Eliminado Correctamente", "Producto Eliminado");
        }

        private void LlenarTablaProductos()
        {
            //Funcion para llenar la tabla con la lista de productos disponibles sin 
            //modificacion alguna. Se llama entonces para cuando no se ha reorganizado
            //o filtrado a traves del txt del buscador

            dtgvProductos.Rows.Clear();
            if (productos.Count != 0 && ContarProductosDisponibles() != 0)
            {
                dtgvProductos.Rows.Add(ContarProductosDisponibles());
                ListaProductosDisponibles();

                for (int i = 0; i < ContarProductosDisponibles(); i++)
                {
                    for (int j = 0; j < dtgvProductos.Columns.Count; j++)
                    {
                        if (j == 0) dtgvProductos[j, i].Value = _productosDisponibles[i].Codigo;
                        else if (j == 1) dtgvProductos[j, i].Value = _productosDisponibles[i].Nombre;
                        else if (j == 2) dtgvProductos[j, i].Value = _productosDisponibles[i].Descripcion;
                        else if (j == 3) dtgvProductos[j, i].Value = _productosDisponibles[i].Precio;
                        else if (j == 4) dtgvProductos[j, i].Value = _productosDisponibles[i].Cantidad;
                        else if (j == 5) dtgvProductos[j, i].Value = _productosDisponibles[i].Disponible;
                    }
                }
            }
        }

        private void LlenarTablaProductos(List<Productos> ListaDeProductos)
        {
            //Funcion para llenar la tabla con la lista de productos disponibles CON 
            //modificaciones. Se llama entonces para cuando se ha reorganizado
            //o filtrado a traves del txt del buscador
            //Por lo cual es necesario pasarle por parametros cual es la lista que
            //debe mostrar

            dtgvProductos.Rows.Clear();
            if (productos.Count != 0 && ListaDeProductos.Count != 0)
            {
                dtgvProductos.Rows.Add(ListaDeProductos.Count);

                for (int i = 0; i < ListaDeProductos.Count; i++)
                {
                    for (int j = 0; j < dtgvProductos.Columns.Count; j++)
                    {
                        if (j == 0) dtgvProductos[j, i].Value = ListaDeProductos[i].Codigo;
                        else if (j == 1) dtgvProductos[j, i].Value = ListaDeProductos[i].Nombre;
                        else if (j == 2) dtgvProductos[j, i].Value = ListaDeProductos[i].Descripcion;
                        else if (j == 3) dtgvProductos[j, i].Value = ListaDeProductos[i].Precio;
                        else if (j == 4) dtgvProductos[j, i].Value = ListaDeProductos[i].Cantidad;
                        else if (j == 5) dtgvProductos[j, i].Value = ListaDeProductos[i].Disponible;
                    }
                }
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo = txtCodigo.Text;
                string nombre = txtNombre.Text;
                double precio;
                string descripcion = txtDescripcion.Text;
                long cantidad = 0;
                

                //Precio

                if (txtPrecio.Text.Contains(".")) { txtPrecio.Text = txtPrecio.Text.Replace(".", ","); }

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
                if (!long.TryParse(txtCantidad.Text, out cantidad))
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
                int n = dtgvProductos.Rows.Add();
                
                Productos prod = new Productos(codigo, nombre, descripcion, cantidad, precio);
                productos.Add(prod);
                _productosDisponibles.Add(prod);
                MessageBox.Show($"Producto Agregado:\n\nCodigo: {txtCodigo.Text}.\n\nNombre: {txtNombre.Text}.\n\nDescripcion: {txtDescripcion.Text}.\n\nPrecio: {txtPrecio.Text}.\n\nCantidad: {txtCantidad.Text}.\n\n");
                txtCodigo.Text = ((productos.Count() + 1).ToString()).PadLeft(5, '0');
                dtgvProductos.Rows[n].Cells[0].Value = codigo;
                dtgvProductos.Rows[n].Cells[1].Value = nombre;
                dtgvProductos.Rows[n].Cells[2].Value = descripcion;
                dtgvProductos.Rows[n].Cells[3].Value = precio;
                dtgvProductos.Rows[n].Cells[4].Value = cantidad;
                dtgvProductos.Rows[n].Cells[5].Value = true;
                GuardarProductos();
                
                txtPrecio.Clear();
                txtNombre.Clear();
                txtDescripcion.Clear();
                txtCantidad.Clear();
                dtgvProductos.CurrentCell = dtgvProductos[0, n];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dtgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            n = e.RowIndex; //indice de la seleccion

            if (n != -1)
            {
                if (e.ColumnIndex == 6)
                {
                    EditarProductos.PathProductos = _pathProductos;
                    EditarProductos.Index = n;
                    EditarProductos.ListaProductos = _productosDisponibles;
                    EditarProductos.ListaDeProductosOriginales = productos;
                    EditarProductos.ShowDialog();
                    LlenarTablaProductos(_productosDisponibles);
                    dtgvProductos.CurrentCell = dtgvProductos[e.ColumnIndex, n];
                    
                }
                if (e.ColumnIndex == 7)
                {
                    try
                    {
                        if (dtgvProductos.Rows.Count >= 0)
                        {
                            if (MessageBox.Show($"¿Esta Seguro que desea Eliminar al Producto Indicado?\n\n {productos[BuscarProductoCorrespondiente()].Data_Codigo()}", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                            {
                                BorrarProducto();
                                LlenarTablaProductos(_productosDisponibles);
                                n = 0;
                            }
                        }
                        else
                        {
                            throw new Exception("No se pueden eliminar más artículos.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    GuardarProductos();
                }
            }
        }
        #region Importar y Exportar
        private int EspaciosVaciosImportar(string[] Linea)
        {
            int EspaciosVacios = 0;

            for (int i = 0; i < Linea.Length; i++)
            {
                if (string.IsNullOrEmpty(Linea[i])) EspaciosVacios++;
            }

            return EspaciosVacios;
        }
        private void btnImportar_Click(object sender, EventArgs e)
        {
            DireccionImportar.Filter = "Archivos Csv (*.csv)|*.csv";
            if (DireccionImportar.ShowDialog() == DialogResult.OK)
            {
                string Direccion = DireccionImportar.FileName;
                try
                {
                    if (!File.Exists(Direccion)) //compruebo que este el documento 
                    {
                        throw new Exception("El Archivo Indicado no se ha Encontrado o no es Valido");
                    }
                    else
                    {
                        List<Productos> ProductosImportados = new List<Productos>();

                        string codigo = "";
                        string nombre = "";
                        string descripcion = "";
                        double precio = 0;
                        long cantidad = 0;

                        bool SobreEscribirDatos = false;
                        int ContadorDeFilas = 1;
                        int EspaciosVacios = 0;

                        StreamReader archivo = new StreamReader(Direccion);
                        string linea;

                        DialogResult Encabezados = MessageBox.Show("Las Columnas de Su Tabla de Productos Poseen Encabezado?\nEn caso Afirmativo se omitira la primera fila de la Tabla", "Formato de la Tabla", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                        if (DialogResult.Cancel != Encabezados)
                        {
                            if (DialogResult.Yes == Encabezados)
                            {
                                archivo.ReadLine();
                            }

                            DialogResult SobreEscribir = MessageBox.Show("Desea Sobreescribir los Datos Anteriores?\nEn caso Afirmativo se eliminaran los productos anteriores\nsiendo reemplazados por los que van a ser Importados", "Formato de Guardado", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                            if (DialogResult.Cancel != SobreEscribir)
                            {
                                if (DialogResult.Yes == SobreEscribir)
                                {
                                    SobreEscribirDatos = true;
                                }

                                while ((linea = archivo.ReadLine()) != null)
                                {
                                    //delimita cada campo del csv

                                    string[] contenido = linea.Split(';');

                                    if (contenido.Length == 5 || contenido.Length == 4)
                                    {
                                        if (contenido.Length == 4)
                                        {
                                            if (string.IsNullOrEmpty(contenido[3]))
                                            {
                                                throw new Exception($"Falta Asignar un Precio en la fila {ContadorDeFilas}.");
                                            }
                                            else if (!double.TryParse(contenido[2], out precio))
                                            {
                                                throw new Exception($"El precio introducido en la fila {ContadorDeFilas} es Incorrecto\nPara el Manejo de Precios solo se Admiten numeros.");
                                            }
                                            else if (precio < 0)
                                            {
                                                throw new Exception($"El Precio Indicado en la fila {ContadorDeFilas} es Incorrecto\nNo se manejan valores negativos");
                                            }
                                            else if (string.IsNullOrEmpty(contenido[3]))
                                            {
                                                throw new Exception($"Falta Asignar la Cantidad en la fila {ContadorDeFilas}.");
                                            }
                                            else if (!long.TryParse(contenido[3], out cantidad))
                                            {
                                                throw new Exception($"La cantidad introducida en la fila {ContadorDeFilas} no es válida\nEl Formato de la Cantidad debe ser en numeros");
                                            }
                                            else if (cantidad < 0)
                                            {
                                                throw new Exception($"La Cantidad Indicada en la fila {ContadorDeFilas} no es valida\nNo se manejan valores negativos");
                                            }
                                            else
                                            {
                                                EspaciosVacios += EspaciosVaciosImportar(contenido);
                                                nombre = contenido[0];
                                                descripcion = contenido[1];

                                                if (SobreEscribirDatos == true) codigo = (ContadorDeFilas.ToString()).PadLeft(5, '0');
                                                else if (ProductosImportados.Count == 0) codigo = ((productos.Count + 1).ToString()).PadLeft(5, '0');
                                                else codigo = ((productos.Count + ProductosImportados.Count + 1).ToString()).PadLeft(5, '0');

                                                ProductosImportados.Add(new Productos(codigo, nombre, descripcion, cantidad, precio));
                                                ContadorDeFilas++;
                                            }
                                        }
                                        else
                                        {
                                            if (string.IsNullOrEmpty(contenido[3]))
                                            {
                                                throw new Exception($"Falta Asignar un Precio en la fila {ContadorDeFilas}.");
                                            }
                                            else if (!double.TryParse(contenido[3], out precio))
                                            {
                                                throw new Exception($"El precio introducido en la fila {ContadorDeFilas} es Incorrecto\nPara el Manejo de Precios solo se Admiten numeros.");
                                            }
                                            else if (precio < 0)
                                            {
                                                throw new Exception($"El Precio Indicado en la fila {ContadorDeFilas} es Incorrecto\nNo se manejan valores negativos");
                                            }
                                            else if (string.IsNullOrEmpty(contenido[4]))
                                            {
                                                throw new Exception($"Falta Asignar la Cantidad en la fila {ContadorDeFilas}.");
                                            }
                                            else if (!long.TryParse(contenido[4], out cantidad))
                                            {
                                                throw new Exception($"La cantidad introducida en la fila {ContadorDeFilas} no es válida\nEl Formato de la Cantidad debe ser en numeros");
                                            }
                                            else if (cantidad < 0)
                                            {
                                                throw new Exception($"La Cantidad Indicada en la fila {ContadorDeFilas} no es valida\nNo se manejan valores negativos");
                                            }
                                            else
                                            {
                                                EspaciosVacios += EspaciosVaciosImportar(contenido);
                                                nombre = contenido[1];
                                                descripcion = contenido[2];

                                                if (SobreEscribirDatos == true) codigo = (ContadorDeFilas.ToString()).PadLeft(5, '0');
                                                else if (ProductosImportados.Count == 0) codigo = ((productos.Count + 1).ToString()).PadLeft(5, '0');
                                                else codigo = ((productos.Count + ProductosImportados.Count + 1).ToString()).PadLeft(5, '0');

                                                ProductosImportados.Add(new Productos(codigo, nombre, descripcion, cantidad, precio));
                                                ContadorDeFilas++;
                                            }
                                        }
                                    }
                                    else throw new Exception("El Numero de Columnas de la Tabla no es Valido\n" +
                                        "Se Manejan unicamente tablas de 4 o 5 Columnas\n\nPara el Caso de Tablas de 4 Columnas;\n" +
                                        "Los Datos deben organizarse de la Siguiente Manera:\n\n1. Nombre - 2. Descripcion - 3. Precio - 4. Cantidad\n\n" +
                                        "Para el Caso de Tablas de 5 Columnas;\nse considera que la columna 1 corresponde a los \n" +
                                        "codigos de los Productos, por ende el orden\nde las Columnas pasa a ser el Siguiente:\n\n" +
                                        "2. Nombre - 3. Descripcion - 4. Precio - 5. Cantidad\n\nNota: Para este ultimo caso; los codigos Indicados\n" +
                                        "en la tabla a Importar no seran tomados en cuenta\npara mantener una coherencia y un buen\nfuncionamiento dentro del programa");
                                }

                                if (SobreEscribirDatos == true)
                                {
                                    productos.Clear();
                                    productos = ProductosImportados;
                                }

                                else if (SobreEscribirDatos == false)
                                {
                                    for (int i = 0; i < ProductosImportados.Count; i++)
                                    {
                                        productos.Add(ProductosImportados[i]);
                                    }
                                }

                                ////cierro el archivo
                                MessageBox.Show("Productos Importados");
                                if (EspaciosVacios == 1) MessageBox.Show($"En la Tabla Importada se ha Encotrado {EspaciosVacios} Celda Vacia");
                                else MessageBox.Show($"En la Tabla Importada se han Encotrado {EspaciosVacios} Celdas Vacias");
                                archivo.Close();
                                LlenarTablaProductos();
                                GuardarProductos();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ExportarExcel(dtgvProductos);
            
        }
        private void ExportarExcel(DataGridView dataDeProductos)
        {
            Microsoft.Office.Interop.Excel.Application Productos = new Microsoft.Office.Interop.Excel.Application();

            Productos.Application.Workbooks.Add(true);

            int IndiceDeColumna = 0;
            foreach (DataGridViewColumn col in dataDeProductos.Columns) //Para las columnas 
            {
                if (col.Name == "Disponible") break;
                IndiceDeColumna++;
                Productos.Cells[1, IndiceDeColumna] = col.Name;
            }

            int IndiceDeFila = 0;
            foreach (DataGridViewRow row in dataDeProductos.Rows)//Para las filas 
            {
                IndiceDeFila++;
                IndiceDeColumna = 0;

                foreach (DataGridViewColumn col in dataDeProductos.Columns)
                {
                    if (col.Name == "Disponible") break;
                    IndiceDeColumna++;
                    Productos.Cells[IndiceDeFila + 1, IndiceDeColumna] = row.Cells[col.Name].Value;
                }
            }
            Productos.Visible = true;
        }
        #endregion
        private void Form2_Load(object sender, EventArgs e)
        {//using systen.io

            /*Con este condicional; al cargarse la ventana se escribe el codigo correspondiente al siguiente
             porducto a crear*/

            if (productos.Count == 0)
            {
                txtCodigo.Text = ("1".PadLeft(5, '0'));
            }
            else
            {
                txtCodigo.Text = ((productos.Count() + 1).ToString()).PadLeft(5, '0');
            }

            //Con este otro se crean las filas necesarias para mostrar los productos que hay
            LlenarTablaProductos();

            txtBuscador.Text = "";
        }
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void dtgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Evento para marcar o desmarcar el checkbox de Disponible
            if (e.ColumnIndex == 5) 
            { 
                if (n != -1)
                {
                    if (Convert.ToBoolean(dtgvProductos[5, n].Value) == true)
                    {
                        dtgvProductos[5, n].Value = false;
                        _productosDisponibles[n].Disponible = false;
                        productos[BuscarProductoCorrespondiente()].Disponible = false;
                    }
                    else
                    {
                        dtgvProductos[5, n].Value = true;
                        _productosDisponibles[n].Disponible = true;
                        productos[BuscarProductoCorrespondiente()].Disponible = true;
                    }
                    GuardarProductos();
                } 
            }
        }


        private void btnOrdenarCodigo_Click(object sender, EventArgs e)
        {
            List<Productos> ListaCodigo = (from itemC in _productosDisponibles
                                               orderby itemC.Codigo ascending
                                               select itemC).ToList<Productos>();
            _productosDisponibles = ListaCodigo.ToList();
            LlenarTablaProductos(_productosDisponibles);
            //LlenarTablaProductosNueva(_productosDisponibles);
        }





        private void btnOrdenarNombre_Click(object sender, EventArgs e)
        {
            List<Productos> ListaAsendente = new List<Productos>();

            var orden = dtgvProductos.Columns[1].SortMode;
            switch (orden)
            {
                case (DataGridViewColumnSortMode)SortOrder.None:

                case (DataGridViewColumnSortMode)SortOrder.Ascending:

                    ListaAsendente = (from ValorL in _productosDisponibles
                                      orderby ValorL.Nombre descending
                                      select ValorL).ToList<Productos>();
                    _productosDisponibles = ListaAsendente;
                    //LlenarTablaProductosNueva(_productosDisponibles);
                    LlenarTablaProductos(ListaAsendente);
                    dtgvProductos.Columns[1].SortMode = (DataGridViewColumnSortMode)SortOrder.Descending;
                    break;

                case (DataGridViewColumnSortMode)SortOrder.Descending:
                    ListaAsendente = (from ValorL in _productosDisponibles
                                      orderby ValorL.Nombre ascending
                                      select ValorL).ToList<Productos>();
                    _productosDisponibles = ListaAsendente;
                    LlenarTablaProductos(ListaAsendente);
                    //LlenarTablaProductosNueva(_productosDisponibles);
                    dtgvProductos.Columns[1].SortMode = (DataGridViewColumnSortMode)SortOrder.Ascending;
                    break;
            }
        }

        /*private void LlenarTablaProductosNueva(List<Productos> _productosDisponibles)
        {
            dtgvProductos.Rows.Clear();
            dtgvProductos.Rows.Add(ContarProductosDisponibles());

            for (int i = 0; i < ContarProductosDisponibles(); i++)
            {
                for (int j = 0; j < dtgvProductos.Columns.Count; j++)
                {
                    if (j == 0)
                    {
                        dtgvProductos[j, i].Value = _productosDisponibles[i].Codigo;
                    }else if (j == 1) 
                    { 
                        dtgvProductos[j, i].Value = _productosDisponibles[i].Nombre;
                    }else if (j == 2) 
                    {
                        dtgvProductos[j, i].Value = _productosDisponibles[i].Descripcion;
                    }else if (j == 3)
                    { 
                        dtgvProductos[j, i].Value = _productosDisponibles[i].Precio;
                    }else if (j == 4)
                    {
                        dtgvProductos[j, i].Value = _productosDisponibles[i].Cantidad; 
                    }else if (j == 5)
                    {
                        dtgvProductos[j, i].Value = _productosDisponibles[i].Disponible;
                    }  
                }     
            }
            GuardarProductos();
        }*/
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string ValorABuscar = txtBuscador.Text.Trim().ToUpper();

            List<Productos> ListaFiltradaBuscador = (from producto in productos
                                                     where producto.Nombre.ToUpper().StartsWith(ValorABuscar)|| producto.Codigo.ToUpper().StartsWith(ValorABuscar) || producto.Descripcion.ToUpper().StartsWith(ValorABuscar)  && producto.Eliminado == false
                                                    select producto).ToList();

            if (ListaFiltradaBuscador.Count > 0)
            {
                _productosDisponibles = ListaFiltradaBuscador;
                LlenarTablaProductos(_productosDisponibles);
            }
        }
    }
}
