using Newtonsoft.Json;
using System;
using System.Data;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenDockUp;
using System.Text.RegularExpressions;

namespace DatosEmpresa
{
    public partial class FormGestionDatosClientes : Form
    {
        private string _pathClientes = "";
        private int aux = -1;
        private List<Cliente> _datosCliente = new List<Cliente>();
        private FormAgregarCliente Agregar = new FormAgregarCliente();
        public FormGestionDatosClientes()
        {
            InitializeComponent();
        }
        public string PathClientes { set { _pathClientes = value; } get { return _pathClientes; } }
        public List<Cliente> ListaClientes { get { return _datosCliente; } set { _datosCliente = value; } }
        private void GuardarClientes()
        {
            string empleadosJson = JsonConvert.SerializeObject(_datosCliente.ToArray(), Formatting.Indented);
            File.WriteAllText(_pathClientes, empleadosJson);
        }
        public static bool IsValidRIF(string rif)
        {
            return rif != null && Regex.IsMatch(rif, @"^[JVEG]\d+$");
        }
        private void ActualizarTabla()
        {
            dtgvClientes.Rows.Clear();

            if (_datosCliente.Count > 0) dtgvClientes.Rows.Add(_datosCliente.Count);

            LlenarTablaClientes();
        }
        private void AutoSeleccionadoDeUltimaFila()
        {
            dtgvClientes.CurrentCell = dtgvClientes[0, dtgvClientes.RowCount - 1];
            aux = dtgvClientes.RowCount - 1;
            lblPosicion.Text = $"Numero de Fila del Cliente Seleccionado: {aux + 1}";
            lblPosicion.Visible = true;
        }
        private void LlenarTablaClientes()
        {
            if (_datosCliente.Count > 0)
            {
                for (int i = 0; i < _datosCliente.Count; i++)
                {
                    for (int j = 0; j < dtgvClientes.Columns.Count; j++)
                    {
                        if (j == 0) dtgvClientes[j, i].Value = _datosCliente[i].Nombre;
                        else if (j == 1) dtgvClientes[j, i].Value = _datosCliente[i].Apellido;
                        else if (j == 2) dtgvClientes[j, i].Value = _datosCliente[i].Cedula;
                        else if (j == 3) dtgvClientes[j, i].Value = _datosCliente[i].NumeroDeTlf;
                    }
                }
            }
        }
        private void FormGestionClientes_Load(object sender, EventArgs e)
        {
            Agregar.PathClientes = _pathClientes;
            Agregar.ListaClientes = _datosCliente;
            lblPosicion.Visible = false;
            aux = -1;

            ActualizarTabla();
        }
       
        private void dtgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            aux = e.RowIndex;
            lblPosicion.Visible = true;
            lblPosicion.Text = $"Numero de Fila del Cliente Seleccionado: {e.RowIndex+1}";

            //Si la persona selecciona la columna de editar, abriremos dicha ventana
            if (e.ColumnIndex == 4 && aux!=-1) 
            {
                Agregar.Index = aux;
                Agregar.ShowDialog();
                ActualizarTabla();
                dtgvClientes.CurrentCell = dtgvClientes[e.ColumnIndex, aux];
            }
            //Si la persona selecciona la columna de BORRAR, borramos dicho cliente
            else if (e.ColumnIndex == 5) 
            {
                try
                {
                    if (aux != -1 && dtgvClientes.Rows.Count > 0)
                    {
                        if (MessageBox.Show($"Esta Seguro que desea Eliminar al Cliente Indicado?\n\n {_datosCliente[aux].DataEliminar()}", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            dtgvClientes.Rows.RemoveAt(aux);
                            _datosCliente.RemoveAt(aux);
                            GuardarClientes();
                            if (aux > 0)
                            {
                                AutoSeleccionadoDeUltimaFila();
                                //aux--;
                                //lblPosicion.Text = $"Numero de Fila del Cliente Seleccionado: {aux + 1}";
                            }
                            else lblPosicion.Visible = false;
                        }
                    }
                    else if (aux == -1)
                    {
                        throw new Exception("No se ha Seleccionado Ningun Cliente a Eliminar");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        private void ExportarExcel(DataGridView dataDeClientes)
        {
            Microsoft.Office.Interop.Excel.Application Clientes = new Microsoft.Office.Interop.Excel.Application();

            Clientes.Application.Workbooks.Add(true);

            int IndiceDeColumna = 0;
            foreach (DataGridViewColumn col in dataDeClientes.Columns) //Para las columnas 
            {
                if (col.Name == "Editar") break;
                IndiceDeColumna++;
                if(col.Name == "Numero") Clientes.Cells[1, IndiceDeColumna] = "Numero de Telefono";
                else Clientes.Cells[1, IndiceDeColumna] = col.Name;                        
            }

            int IndiceDeFila = 0;
            foreach (DataGridViewRow row in dataDeClientes.Rows)//Para las filas 
            {
                IndiceDeFila++;
                IndiceDeColumna = 0;

                foreach (DataGridViewColumn col in dataDeClientes.Columns)
                {
                    if (col.Name == "Editar") break;
                    IndiceDeColumna++;
                    Clientes.Cells[IndiceDeFila + 1, IndiceDeColumna] = row.Cells[col.Name].Value;
                }
            }
            Clientes.Visible = true;
        }
        private void PicRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            ExportarExcel(dtgvClientes);
        }
        private bool CedulaRepetida(string cedula)
        {
            bool Repetido = false;
            for (int i = 0; i < _datosCliente.Count; i++)
            {
                if (_datosCliente[i].Cedula == cedula)
                {
                    Repetido = true;
                    break;
                }
            }
            return Repetido;
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
                        List<Cliente> ClientesImportados = new List<Cliente>();

                        string nombre = "";
                        string apellido = "";
                        //long cedula = 0;
                        long telefono = 0;

                        bool SobreEscribirDatos = false;
                        int ContadorDeFilas = 1;
                        int EspaciosVacios = 0;

                        StreamReader archivo = new StreamReader(Direccion);
                        string linea;

                        DialogResult Encabezados = MessageBox.Show("Las Columnas de Su Tabla de Clientes Poseen Encabezado?\nEn caso Afirmativo se omitira la primera fila de la Tabla", "Formato de la Tabla", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                        if (DialogResult.Cancel != Encabezados)
                        {
                            if (DialogResult.Yes == Encabezados)
                            {
                                archivo.ReadLine();
                            }

                            DialogResult SobreEscribir = MessageBox.Show("Desea Sobreescribir los Datos Anteriores?\nEn caso Afirmativo se eliminaran los clientes anteriores\nsiendo reemplazados por los que van a ser Importados", "Formato de Guardado", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

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

                                    if (contenido.Length == 4)
                                    {
                                        if (string.IsNullOrEmpty(contenido[0]))
                                        {
                                            throw new Exception($"Falta Asignar un Nombre en la fila {ContadorDeFilas}.");
                                        }
                                        else if (string.IsNullOrEmpty(contenido[1]))
                                        {
                                            throw new Exception($"Falta Asignar un Apellido en la fila {ContadorDeFilas}.");
                                        }
                                        else if (string.IsNullOrEmpty(contenido[2]))
                                        {
                                            throw new Exception($"Falta Asignar una Cedula en la fila {ContadorDeFilas}.");
                                        }
                                        /*else if (!long.TryParse(contenido[2], out cedula))
                                        {
                                            throw new Exception($"La cedula introducida en la fila {ContadorDeFilas} no es válida\nEl Formato de la Cedula debe ser en numeros");
                                        }
                                        else if (cedula < 0)
                                        {
                                            throw new Exception($"La Cedula Indicada en la fila {ContadorDeFilas} no es valida\nNo se manejan valores negativos");
                                        }*/
                                        else if (!IsValidRIF(contenido[2]))
                                        {
                                            throw new Exception($"El campo del rif/Cedula no es correcto en la fila {ContadorDeFilas}\nDebe Contener solo numeros\n y alguna De las siguientes letras \nen Mayuscula: J, V, E, G");
                                        }
                                        else if (CedulaRepetida(contenido[2]) && !SobreEscribirDatos)
                                        {
                                            throw new Exception($"La Cedula Introducida en la fila {ContadorDeFilas}\nya esta registrada en la base de Datos");
                                        }
                                        else if (!string.IsNullOrEmpty(contenido[3]))
                                        {
                                            if (!long.TryParse(contenido[3], out telefono))
                                            {
                                                throw new Exception($"El numero de Telefono introducido en la fila {ContadorDeFilas} no es válido\nEl Formato del Telefono debe ser en numeros");
                                            }
                                            else if (telefono < 0)
                                            {
                                                throw new Exception($"El numero de Telefono Indicado en la fila {ContadorDeFilas} no es valido\nNo se manejan valores negativos");
                                            }
                                        }

                                        EspaciosVacios += EspaciosVaciosImportar(contenido);
                                        nombre = contenido[0];
                                        apellido = contenido[1];

                                        if (!string.IsNullOrEmpty(contenido[3]))
                                        {
                                            //MessageBox.Show($"{contenido[3]} {contenido[3][0]}");
                                            if (contenido[3][0]=='4' || contenido[3][0] == '2')
                                            {
                                                ClientesImportados.Add(new Cliente(nombre, apellido, contenido[2], $"0{contenido[3]}"));
                                            }
                                            else ClientesImportados.Add(new Cliente(nombre, apellido, contenido[2], contenido[3]));
                                        }
                                        else ClientesImportados.Add(new Cliente(nombre, apellido, contenido[2], ""));

                                        ContadorDeFilas++;
                                    }
                                    else throw new Exception("El Numero de Columnas de la Tabla no es Valido\n" +
                                        "Se Manejan unicamente tablas de 4 Columnas\n\n" +
                                        "Los Datos deben organizarse de la Siguiente Manera:\n\n1. Nombre - 2. Apellido - 3. Cedula - 4. Numero de Telefono\n\n");
                                }

                                if (SobreEscribirDatos == true)
                                {
                                    _datosCliente.Clear();
                                    _datosCliente = ClientesImportados;
                                }

                                else if (SobreEscribirDatos == false)
                                {
                                    for (int i = 0; i < ClientesImportados.Count; i++)
                                    {
                                        _datosCliente.Add(ClientesImportados[i]);
                                    }
                                }
                                ////cierro el archivo
                                MessageBox.Show("Clientes Importados");
                                if (EspaciosVacios == 1) MessageBox.Show($"En la Tabla Importada se ha Encotrado {EspaciosVacios} Celda Vacia");
                                else MessageBox.Show($"En la Tabla Importada se han Encotrado {EspaciosVacios} Celdas Vacias");
                                archivo.Close();
                                ActualizarTabla();
                                AutoSeleccionadoDeUltimaFila();
                                GuardarClientes();
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
        private int EspaciosVaciosImportar(string[] Linea)
        {
            int EspaciosVacios = 0;

            for (int i = 0; i < Linea.Length; i++)
            {
                if (string.IsNullOrEmpty(Linea[i])) EspaciosVacios++;
            }

            return EspaciosVacios;
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            //Con el Index = -1 le damos a entender a la siguiente ventana que va a tener que 
            //Crear un nuevo Cliente

            Agregar.Index = -1;
            Agregar.ListaClientes = _datosCliente;
            Agregar.ShowDialog();
            if (dtgvClientes.RowCount != _datosCliente.Count)
            {
                ActualizarTabla();
                AutoSeleccionadoDeUltimaFila();
            }
        }
    }
}