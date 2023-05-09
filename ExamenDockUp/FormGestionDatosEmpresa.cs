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
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;

namespace DatosEmpresa
{
    public partial class FormGestionDatosEmpresa : Form
    {
        private string _pathDatos = "";
        private string _pathEmpleados = "";
        private int aux = -1;
        private Usuario _vendedor = new Usuario();
        private List<Usuario> _datosEmpleado = new List<Usuario>();
        private List<string> _datosEmpresa = new List<string>();
        private FormAgregarVendedor Agregar = new FormAgregarVendedor();

        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrEmpty(email)) { return false; }
            //    try {var enderocoEmail = new System.Net.Mail.MailAddress(email); return enderocoEmail.Address == email;}
            //catch{return false;}
            return Regex.IsMatch(email, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }
        public static bool IsValidRIF(string rif)
        {
            return rif != null && Regex.IsMatch(rif, @"^[JVEG]\d+$");
        }

        public FormGestionDatosEmpresa()
        {
            InitializeComponent();
        }
        public string PathEmpleados { set { _pathEmpleados = value;} get { return _pathEmpleados; } }
        public string PathDatos { set { _pathDatos = value; } get { return _pathDatos; } }
        public Usuario Vendedor { set { _vendedor = value; } get { return _vendedor; } }
        public List<string> DatosEmpresa { set { _datosEmpresa = value; } get { return _datosEmpresa; } }
        public List<Usuario> Empleados { get { return _datosEmpleado;} set { _datosEmpleado = value; } }

        private void GuardarEmpleados()
        {
            string empleadosJson = JsonConvert.SerializeObject(_datosEmpleado.ToArray(), Formatting.Indented);
            File.WriteAllText(_pathEmpleados, empleadosJson);
        }
        private void LlenarTablaEmpleados()
        {
            if (_datosEmpleado.Count > 0)
            {
                for (int i = 1; i < _datosEmpleado.Count; i++)
                {
                    if (_datosEmpleado[i].NombreUsuario != "AdminS")
                    {
                        for (int j = 0; j < dtgvEmpleados.Columns.Count; j++)
                        {
                            if (j == 0) dtgvEmpleados[j, i-1].Value = _datosEmpleado[i].Nombre;
                            else if (j == 1) dtgvEmpleados[j, i-1].Value = _datosEmpleado[i].Apellido;
                            else if (j == 2) dtgvEmpleados[j, i-1].Value = $"V{_datosEmpleado[i].Cedula}";
                        }
                    }
                }
            }
        }
        private void ActualizarTabla()
        {
            dtgvEmpleados.Rows.Clear();

            if (_datosEmpleado.Count > 1) dtgvEmpleados.Rows.Add(_datosEmpleado.Count - 1);

            LlenarTablaEmpleados();
        }
        private void PreviewDatosEmpresa()
        {
            txtNomEmpresa.Text = "TuProductoOnline";
            txtCorreo.Text = "No Asignado";
            txtRif.Text = "No Asignado";
            txtDireccion.Text = "No Asignada";
            txtNomEmpresa.ForeColor = Color.Gray;
            txtCorreo.ForeColor = Color.Gray;
            txtRif.ForeColor = Color.Gray;
            txtDireccion.ForeColor = Color.Gray;
        }
        private void MostrarDatosEmpresa()
        {
            txtNomEmpresa.Text = _datosEmpresa[0];
            txtCorreo.Text = _datosEmpresa[1];
            txtRif.Text = _datosEmpresa[2];
            txtDireccion.Text = _datosEmpresa[3];
        }
        private void FormGestionEmpresa_Load(object sender, EventArgs e)
        {
            Agregar.PathEmpleados = _pathEmpleados;
            Agregar.ListaEmpleados = _datosEmpleado;

            lblPosicion.Visible = false;
            aux = -1;

            if(_datosEmpresa.Count == 0)
            {
                PreviewDatosEmpresa();
            }
            else
            {
                MostrarDatosEmpresa();
            }

            ActualizarTabla();
        }
        private void btnAgregarVen_Click(object sender, EventArgs e)
        {
            //Con el Index = -1 le damos a entender a la siguiente ventana que va a tener que 
            //Crear un nuevo Empleado

            Agregar.Index = -1;
            Agregar.ShowDialog();

            if(dtgvEmpleados.RowCount != Agregar.ListaEmpleados.Count)
            {
                ActualizarTabla();
                dtgvEmpleados.CurrentCell = dtgvEmpleados[0, dtgvEmpleados.RowCount-1];
                aux = dtgvEmpleados.RowCount - 1;
                lblPosicion.Text = $"Numero de Fila del Empleado Seleccionado: {aux + 1}";
                lblPosicion.Visible = true;
            }
        }
        private void btnGuardarDatosEmpresa_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidEmail(txtCorreo.Text)) 
                {
                    if (!string.IsNullOrEmpty(txtNomEmpresa.Text)) 
                    {
                        if (IsValidRIF(txtRif.Text)) 
                        {
                            if (!string.IsNullOrEmpty(txtDireccion.Text)) 
                            {
                                _datosEmpresa.Clear();
                                _datosEmpresa.Add(txtNomEmpresa.Text);
                                _datosEmpresa.Add(txtCorreo.Text);
                                _datosEmpresa.Add(txtRif.Text);
                                _datosEmpresa.Add(txtDireccion.Text);
                            }
                            else { throw new Exception("El campo de direccion no puede quedar vacio"); }
                        }
                        else { throw new Exception("El campo del rif no es correcto\nDebe Contener solo numeros\n y alguna De las siguientes letras \nen Mayuscula: J,V,E,G"); }
                    }
                    else { throw new Exception("El campo de texto de Nombre de empresa no puede quedar vacio"); }
                }
                else { throw new Exception("Por favor aniada un email valido"); }

                if (txtNomEmpresa.ForeColor == Color.Gray)
                {
                    txtNomEmpresa.ForeColor = Color.Black;
                    txtCorreo.ForeColor = Color.Black;
                    txtRif.ForeColor = Color.Black;
                    txtDireccion.ForeColor = Color.Black;
                }

                string DatosEmpresaJson = JsonConvert.SerializeObject(_datosEmpresa.ToArray(), Formatting.Indented);
                File.WriteAllText(_pathDatos, DatosEmpresaJson);
                MessageBox.Show("Se han Guardado correctamente los datos de la Empresa");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
     
        private void dtgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            aux = e.RowIndex;
            lblPosicion.Visible = true;
            lblPosicion.Text = $"Numero de Fila del Empleado Seleccionado: {e.RowIndex + 1}";

            //Si la persona selecciona la columna de editar, abriremos dicha ventana

            if (e.ColumnIndex == 3 && aux!=-1) 
            {
                //Si el que unde el boton de editar es el Super Admin
                //Se muestra la venta de Opciones de Super Admin en ves de la de "Agregar"

                if (_vendedor.NombreUsuario == "AdminS")
                {
                    FormOpcionesSuperAdmin Editar = new FormOpcionesSuperAdmin();
                    Editar.Index = aux;
                    Editar.PathEmpleados = _pathEmpleados;
                    Editar.ListaEmpleados = _datosEmpleado;
                    Editar.ShowDialog();
                    ActualizarTabla();
                    dtgvEmpleados.CurrentCell = dtgvEmpleados[e.ColumnIndex, aux];
                }
                else
                {
                    Agregar.Index = aux;
                    Agregar.ShowDialog();
                    ActualizarTabla();
                    dtgvEmpleados.CurrentCell = dtgvEmpleados[e.ColumnIndex, aux];
                }
            }
            //Si la persona selecciona la columna de Borrar , BORRA DICHO PRODUCTO 
            else if (e.ColumnIndex == 4 && aux != -1) 
            {
                try
                {
                    if (aux != -1)
                    {
                        if (MessageBox.Show($"Esta Seguro que desea Eliminar al Empleado Indicado?\n\n {_datosEmpleado[aux + 1].DataEliminar()}", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            if (_datosEmpleado[aux + 1].Cargo == "Administrador")
                            {
                                MessageBox.Show("El Administrador No puede ser Eliminado", "Accion Invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            if (dtgvEmpleados.Rows.Count > 1 && _datosEmpleado[aux + 1].Cargo != "Administrador")
                            {
                                dtgvEmpleados.Rows.RemoveAt(aux);
                                _datosEmpleado.RemoveAt(aux + 1);
                                GuardarEmpleados();
                                if (aux > 0) aux--;
                                lblPosicion.Text = $"Numero de Fila del Empleado Seleccionado: {aux + 1}";
                            }
                        }
                    }
                    else if (aux == -1)
                    {
                        throw new Exception("No se ha Seleccionado ningun Empleado a Eliminar");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        private void PictureInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("De Manera Predeterminada los Empleados Agregados\nA la Base de Datos de la Empresa tendran como\nUsuario y Clave: Su Cedula de Identidad","Metodo de Creacion de Usuarios",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        private void PicRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //La siguiente Region es Para el Fondo de los TextBox (Las palabras que Salen en Gris Claro y luego se Borran)
        #region PlaceHolder
        private void txtNomEmpresa_Enter(object sender, EventArgs e)
        {
            if (txtNomEmpresa.ForeColor == Color.Gray)
            {
                txtNomEmpresa.Text = "";
                txtNomEmpresa.ForeColor = Color.Black;
            }
        }

        private void txtRif_Enter(object sender, EventArgs e)
        {
            if (txtRif.ForeColor == Color.Gray)
            {
                txtRif.Text = "";
                txtRif.ForeColor = Color.Black;
            }
        }

        private void txtDireccion_Enter(object sender, EventArgs e)
        {
            if (txtDireccion.ForeColor == Color.Gray)
            {
                txtDireccion.Text = "";
                txtDireccion.ForeColor = Color.Black;
            }
        }

        private void txtCorreo_Enter(object sender, EventArgs e)
        {
            if (txtCorreo.ForeColor == Color.Gray)
            {
                txtCorreo.Text = "";
                txtCorreo.ForeColor = Color.Black;
            }
        }
        #endregion
    }
}