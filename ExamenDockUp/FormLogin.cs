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
    public partial class FormLogin : Form
    {
        private string _path = "";
        private int _posicionUser = -1;
        private List<Usuario> _usuarios = new List<Usuario>();
        public FormLogin()
        {
            InitializeComponent();
        }
        public string Path { set { _path = value; } get { return _path; } }
        public int Posicion { set { _posicionUser = value; } get { return _posicionUser; } }
        public List<Usuario> ListaUsuarios { set { _usuarios = value; } get { return _usuarios; } }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            //Intentamos Leer la lista y en caso de no encontrarse Lista alguna; procedemos a Crear el Usuario del Admin
            try 
            { 
                _usuarios = JsonConvert.DeserializeObject<List<Usuario>>(File.ReadAllText(_path));
            }
            catch
            {
                MessageBox.Show("Es primera vez que se inicia el Programa.\nLa Clave Ingresada sera Asignada al Administrador");
            }
            if(_usuarios.Count < 1)
            {
                //Prueba Para Creacion del Super Usuario; con esto nos aseguramos de que sea siempre el primero de la lista
                //Ademas por algunas condiciones, podemos saber que ningun trabajador va a poder tener el mismo nombre de usuario

                _usuarios.Add(new Usuario("AdminS", "MiLider", true));
                _usuarios[0].Nombre = "Acceso Especial";
            }
            if(_usuarios.Count < 2)
            {
                txtUsuario.Text = "Admin";
                txtUsuario.ForeColor = Color.Black;
                txtUsuario.Enabled = false;
            }
        }
        private void btnSalir_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            /*El siguiente Booleano nos indicara si los Datos ingresados son correctos
            Por lo cual, hasta que se compruebe tal cosa, desde un inicio sera true */

            bool Incorrecto = true;

            if(_usuarios.Count > 1)
            {
                for (int i = 0; i < _usuarios.Count; i++)
                {
                    if (_usuarios[i].NombreUsuario == txtUsuario.Text && _usuarios[i].Clave == txtClave.Text)
                    {
                        this.DialogResult = DialogResult.OK;
                        _posicionUser = i;
                        this.Close();
                        Incorrecto = false;
                        break;
                    }
                }
                if (Incorrecto) MessageBox.Show("Usuario y/o Clave Incorrectas","Datos de Ingreso Incorrectos",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            { 
                //En caso de Que la Lista este Vacia, Aqui es donde se crea el Usuario Admin

                _usuarios.Add(new Usuario(txtUsuario.Text, txtClave.Text, true));
                this.DialogResult = DialogResult.OK;
                _posicionUser = 1;
                this.Close();
            }
        }
        //La siguiente Region es Para el Fondo de los TextBox (Las palabras que Salen en Gris Claro y luego se Borran)
        #region PlaceHolder
        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.ForeColor == Color.Silver)
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }
        private void txtClave_Enter(object sender, EventArgs e)
        {
            if (txtClave.ForeColor == Color.Silver)
            {
                txtClave.Text = "";
                txtClave.ForeColor = Color.Black;
            }
        }
        #endregion
    }
}
