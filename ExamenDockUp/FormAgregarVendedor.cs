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
    public partial class FormAgregarVendedor : Form
    {
        private List<Usuario> _listaEmpleados = new List<Usuario>();
        private string _pathEmpleados = "";
        private int _index = -1;
        public string PathEmpleados { set { _pathEmpleados = value; } get { return _pathEmpleados; } }
        public List<Usuario> ListaEmpleados { set { _listaEmpleados = value; } get { return _listaEmpleados; } }
        public int Index { set { _index = value; } get { return _index; } }
        public FormAgregarVendedor()
        {
            InitializeComponent();
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
        private long FormatoDeCedula()
        {
            long Cedula = -1;
            if (!long.TryParse(txtCI.Text, out Cedula))
            {
                throw new Exception("El Formato de la Cedula introducida no es válido");
            }
            if (Cedula < 1)
            {
                throw new Exception("La Cedula Indicada no es valida\nSe manejan Cedulas a Partir del Numero 1");
            }
            return Cedula;
        }
        private void EditarDatosEmpleado()
        {
            //A diferencia del codigo de anadir cliente, aqui debemos empezar a contar desde
            //index + 1; ya que debemos recordar que desde que se inicio el programa se creo el
            //Super Usuario; ubicado en la posicion 0 de la lista de Usuarios
            //la idea del +1 es para evitar de que puedan modificar o eliminar al Super Usuario

            _listaEmpleados[_index + 1].Nombre = txtNombre.Text;
            _listaEmpleados[_index + 1].Apellido = txtApellido.Text;
            _listaEmpleados[_index + 1].Cedula = txtCI.Text;
        }
        private void GuardarEmpleados()
        {
            string empleadosJson = JsonConvert.SerializeObject(ListaEmpleados.ToArray(), Formatting.Indented);
            File.WriteAllText(_pathEmpleados, empleadosJson);
            MessageBox.Show("Guardado Exitosamente");
        }
        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            //El index -1 es la referencia que necesita el programa para saber si debe crear desde
            //cero un nuevo Vendedor o si debe modificar alguno
            //de este modo cuando el index es -1, quiere decir que se va a anadir un nuevo Vendedor
            //en caso de que sea cualquier otro numero, nos quiere decir que ese numero es la
            //posicion del Vendedor en la lista que se va a modificar

            if (_index == -1)
            {
                try
                {
                    if (string.IsNullOrEmpty(txtCI.Text)) throw new Exception("El campo de la Cedula esta Vacio");
                    else if (CedulaRepetida()) throw new Exception("La Cedula Introducida ya esta \nregistrada en la base de Datos");
                    //else if (DatoRepetido()) MessageBox.Show("Nombre de Usuario ya registrado en la base de Datos", "Usuario Repetido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if(_index != -1)
            {
                txtNombre.Text = _listaEmpleados[_index+1].Nombre;
                txtApellido.Text = _listaEmpleados[_index+1].Apellido;
                txtCI.Text = _listaEmpleados[_index+1].Cedula;
            }
        }
    }
}
