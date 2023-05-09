using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenDockUp
{
    public partial class FormOpcionesSuperAdmin : Form
    {
        private List<Usuario> _listaEmpleados = new List<Usuario>();
        private string _pathEmpleados = "";
        private int _index = -1;
        public string PathEmpleados { set { _pathEmpleados = value; } get { return _pathEmpleados; } }
        public List<Usuario> ListaEmpleados { set { _listaEmpleados = value; } get { return _listaEmpleados; } }
        public int Index { set { _index = value; } get { return _index; } }
        public FormOpcionesSuperAdmin()
        {
            InitializeComponent();
        }
        private bool NombreDeUsuarioRepetido()
        {
            //Se recorre La Lista de Usuarios, y si el Nombre de usuario llegase a repetirse se retorna un True

            bool Repetido = false;
            for (int i = 0; i < _listaEmpleados.Count; i++)
            {
                if (_listaEmpleados[i].NombreUsuario == txtNombreDeUsuario.Text) Repetido = true;
            }
            return Repetido;
        }
        private bool CedulaRepetida()
        {
            bool Repetido = false;
            for (int i = 0; i < _listaEmpleados.Count; i++)
            {
                if (_listaEmpleados[i].Cedula == txtCI.Text)
                {
                    Repetido = true;
                    break;
                }
            }
            return Repetido;
        }
        private int FormatoDeCedula()
        {
            int Cedula = -1;
            if (!int.TryParse(txtCI.Text, out Cedula))
            {
                throw new Exception("El Formato de la Cedula introducida no es válido");
            }
            if (Cedula < 1)
            {
                throw new Exception("La Cedula Indicada no es valida\nSe manejan Cedulas a Partir del Numero 1");
            }
            return Cedula;
        }
        /*private bool DatoRepetido()
        {
            //Se recorre La Lista de Usuarios, y si el Nombre de usuario llegase a repetirse se retorna un True

            bool Repetido = false;
            for (int i = 0; i < ListaEmpleados.Count; i++)
            {
                if (ListaEmpleados[i].NombreUsuario == txtCI.Text) Repetido = true;
            }
            return Repetido;
        }*/
        private void EditarDatosEmpleado()
        {
            _listaEmpleados[_index + 1].Nombre = txtNombre.Text;
            _listaEmpleados[_index + 1].Apellido = txtApellido.Text;
            _listaEmpleados[_index + 1].Cedula = txtCI.Text;
            _listaEmpleados[_index + 1].NombreUsuario = txtNombreDeUsuario.Text;
            _listaEmpleados[_index + 1].Clave = txtClave.Text;
        }
        private void GuardarEmpleados()
        {
            string empleadosJson = JsonConvert.SerializeObject(ListaEmpleados.ToArray(), Formatting.Indented);
            File.WriteAllText(_pathEmpleados, empleadosJson);
            MessageBox.Show("Guardado Exitosamente");
        }
        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            if(_index == -1)
            {
                try
                {
                    if (string.IsNullOrEmpty(txtCI.Text)) throw new Exception("El campo de la Cedula esta Vacio");
                    else if (CedulaRepetida()) MessageBox.Show("La Cedula Introducida ya esta \nregistrada en la base de Datos", "Cedula Repetida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        if (FormatoDeCedula() != -1)
                        {
                            _listaEmpleados.Add(new Usuario(txtNombre.Text, txtApellido.Text, txtCI.Text));
                            GuardarEmpleados();
                            Close();
                        }

                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                try
                {
                    if (string.IsNullOrEmpty(txtCI.Text)) throw new Exception("El campo de la Cedula esta Vacio");
                    else if (CedulaRepetida() && txtCI.Text != _listaEmpleados[_index + 1].Cedula) MessageBox.Show("La Cedula Introducida ya esta \nregistrada en la base de Datos", "Cedula Repetida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else if (NombreDeUsuarioRepetido() && txtNombreDeUsuario.Text != _listaEmpleados[_index + 1].NombreUsuario) MessageBox.Show("El Nombre de Usuario Introducido ya \nesta registrado en la base de Datos", "Nombre de Usuario Repetido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        if (FormatoDeCedula() != -1)
                        {
                            EditarDatosEmpleado();
                            GuardarEmpleados();
                            Close();
                        }
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        private void FormAgregarVendedor_Load(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCI.Text = "";
            txtNombreDeUsuario.Text = "";
            txtClave.Text = "";
            if(_index != -1)
            {
                txtNombre.Text = _listaEmpleados[_index+1].Nombre;
                txtApellido.Text = _listaEmpleados[_index+1].Apellido;
                txtCI.Text = _listaEmpleados[_index+1].Cedula;
                txtNombreDeUsuario.Text = _listaEmpleados[_index+1].NombreUsuario;
                txtClave.Text = _listaEmpleados[_index + 1].Clave;
            }
        }
    }
}
