using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenDockUp
{
    public partial class FormAgregarCliente : Form
    {
        private List<Cliente> _listaClientes = new List<Cliente>();
        private string _pathClientes = "";
        private int _index = -1;
        public FormAgregarCliente()
        {
            InitializeComponent();
        }
        public int Index { set { _index = value; } get { return _index; } }
        public string PathClientes { set { _pathClientes = value; } get { return _pathClientes; } }
        public List<Cliente> ListaClientes { set { _listaClientes = value; } get { return _listaClientes; } }
        private bool CedulaRepetida()
        {
            bool Repetido = false;
            for (int i = 0; i < _listaClientes.Count; i++)
            {
                if (_listaClientes[i].Cedula == txtCI.Text)
                {
                    Repetido = true;
                    break;
                }
            }
            return Repetido;
        }
        private void GuardarClientes()
        {
            string ClientesJson = JsonConvert.SerializeObject(ListaClientes.ToArray(), Formatting.Indented);
            File.WriteAllText(_pathClientes, ClientesJson);
            MessageBox.Show("Guardado Exitosamente");
        }
        public static bool IsValidRIF(string rif)
        {
            return rif != null && Regex.IsMatch(rif, @"^[JVEG]\d+$");
        }
        /*private long FormatoDeCedula()
        {
            long Cedula = -1;
            if (!long.TryParse(txtCI.Text, out Cedula))
            {
                throw new Exception("El Formato de la Cedula introducida no es válido");
            }
            else if (Cedula < 1)
            {
                throw new Exception("La Cedula Indicada no es valida\nSe manejan Cedulas a Partir del Numero 1");
            }
            return Cedula;
        }*/
        private long FormatoTlf()
        {
           long Tlf = -1;
           if(!long.TryParse(txtTlf.Text, out Tlf))
           {
               throw new Exception("El formato del numero de Telefono es Incorrecto.\nNo se permite el uso de Caracteres");
           }
           if (Tlf < 0)
           {
               throw new Exception("Se manejan unicamente numeros mayores a 0\nPara este tipo de formato");
           }
           return Tlf;
        }
        private void EditarDatosCliente()
        {
            _listaClientes[_index].Nombre = txtNombre.Text;
            _listaClientes[_index].Apellido = txtApellido.Text;
            _listaClientes[_index].Cedula = txtCI.Text;
            _listaClientes[_index].NumeroDeTlf = txtTlf.Text;
        }
        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            //El index -1 es la referencia que necesita el programa para saber si debe crear desde
            //cero un nuevo cliente o si debe modificar alguno
            //de este modo cuando el index es -1, quiere decir que se va a anadir un nuevo cliente
            //en caso de que sea cualquier otro numero, nos quiere decir que ese numero es la
            //posicion del cliente en la lista que se va a modificar

            if(_index == -1)
            {
                try
                {
                    if (string.IsNullOrEmpty(txtCI.Text)) throw new Exception("El campo de la Cedula esta Vacio");
                    else if (!IsValidRIF(txtCI.Text)) throw new Exception("El campo del rif/Cedula no es correcto\nDebe Contener solo numeros\n y alguna De las siguientes letras \nen Mayuscula: J, V, E, G");
                    else if (CedulaRepetida()) MessageBox.Show("La Cedula Introducida ya esta registrada en la base de Datos", "Cedula Repetida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        if (FormatoTlf() != -1)
                        {
                            _listaClientes.Add(new Cliente(txtNombre.Text, txtApellido.Text, txtCI.Text, txtTlf.Text));
                            GuardarClientes();
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
                    else if (!IsValidRIF(txtCI.Text)) throw new Exception("El campo del rif/Cedula no es correcto\nDebe Contener solo numeros\n y alguna De las siguientes letras \nen Mayuscula: J, V, E, G");
                    else if (CedulaRepetida() && txtCI.Text != _listaClientes[_index].Cedula) MessageBox.Show("La Cedula Introducida ya esta registrada en la base de Datos", "Cedula Repetida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        if (FormatoTlf() != -1)
                        {
                            EditarDatosCliente();
                            GuardarClientes();
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
        private void FormAgregarCliente_Load(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCI.Text = "";
            txtTlf.Text = "";
            if (_index != -1)
            {
                txtNombre.Text = _listaClientes[_index].Nombre;
                txtApellido.Text = _listaClientes[_index].Apellido;
                txtCI.Text = _listaClientes[_index].Cedula;
                txtTlf.Text = _listaClientes[_index].NumeroDeTlf;
            }
        }
    }
}
