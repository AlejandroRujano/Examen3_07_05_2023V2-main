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
    public partial class FormCambiarDatosUsuario : Form
    {
        private string _path = "";
        private int _posicion = -1;
        private List<Usuario> _usuarios = new List<Usuario>();
        public FormCambiarDatosUsuario()
        {
            InitializeComponent();
        }
        public string Path { set { _path = value; } get { return _path; } }
        public List<Usuario> Usuarios { set { _usuarios = value; } get { return _usuarios; } }
        public int Posicion { set { _posicion = value;} get { return _posicion; } }
        private bool DatoRepetido()
        {
            //Se recorre La Lista de Usuarios, y si el Nombre de usuario llegase a repetirse se retorna un True

            bool Repetido = false;
            for(int i=0; i<Usuarios.Count; i++)
            {
                if (Usuarios[i].NombreUsuario == tbUsuario.Text) Repetido = true;
            }
            return Repetido;
        }
        private void FormCambiarDatosUsuario_Load(object sender, EventArgs e)
        {
            tbUsuario.Text = _usuarios[_posicion].NombreUsuario;
            tbClaveAntigua.Text = "";
            tbClaveNueva.Text = "";
            tbConfirmarClave.Text = "";
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            #region Condiciones para Cuando Quiere cambiar la Clave

            /*Como Condicion principal para poder cambiar de Clave, Primero se Comprueba que los TextBox de las Claves
             No esten Vacias*/

            /*Luego se hacen comprobaciones para saber si lo que se escribe en el textbox coincide con los datos
             guardados en la lista de Usuarios, para entonces en el caso de si coincidir, poder cambiar los Datos*/

            if (!string.IsNullOrEmpty(tbClaveAntigua.Text) && !string.IsNullOrEmpty(tbClaveNueva.Text) && !string.IsNullOrEmpty(tbConfirmarClave.Text))
            {
                if (_usuarios[_posicion].Clave != tbClaveAntigua.Text)
                {
                    MessageBox.Show("Su Clave Actual introducida no es correcta","Clave Anterior Erronea",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else if (tbConfirmarClave.Text == tbClaveNueva.Text)
                {
                    if(_usuarios[_posicion].NombreUsuario == tbUsuario.Text)
                    {
                        DialogResult Decision = MessageBox.Show("Su Clave sera cambiada.\n\nEsta de Acuerdo?", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        if (Decision == DialogResult.OK)
                        {
                            _usuarios[_posicion].Clave = tbClaveNueva.Text;
                            MessageBox.Show("Cambio realizado Exitosamente!", "Clave Cambiada Correctamente", MessageBoxButtons.OK, MessageBoxIcon.None);
                            this.Close();
                        }
                    }
                    else if(_usuarios[_posicion].NombreUsuario != tbUsuario.Text && !DatoRepetido())
                    {
                        DialogResult Decision = MessageBox.Show("Su Usuario y Clave seran cambiados.\n\nEsta de Acuerdo?", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        if (Decision == DialogResult.OK)
                        {
                            _usuarios[_posicion].Clave = tbClaveNueva.Text;
                            _usuarios[_posicion].NombreUsuario = tbUsuario.Text;
                            MessageBox.Show("Cambio realizado Exitosamente!","Nombre de Usuario y Clave Cambiados Correctamente", MessageBoxButtons.OK, MessageBoxIcon.None);
                            this.Close();
                        }
                    }
                }
                if (tbConfirmarClave.Text != tbClaveNueva.Text) MessageBox.Show("La Clave Nueva y su confirmacion no coinciden,\nPor favor introduzcalas de Nuevo.", "Clave Nueva Incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (DatoRepetido() && _usuarios[_posicion].NombreUsuario != tbUsuario.Text) MessageBox.Show("El Nombre de Usuario Introducido Ya existe","Nombre de Usuario Ya Existente",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                string Json = JsonConvert.SerializeObject(_usuarios.ToArray(), Formatting.Indented);
                File.WriteAllText(_path, Json);
            }
            #endregion

            #region Condicion para Cuando Solo Quiere Cambiar el Usuario

            /*En Caso de que los Textbox de las Claves esten Vacias; se Considerara que no se quiere cambiar de Clave.
             Pero por otra parte se debe verificar si cambio su nombre de Usuario*/ 

            else if (tbUsuario.Text != _usuarios[_posicion].NombreUsuario && !DatoRepetido())
            {
                if (!string.IsNullOrEmpty(tbClaveAntigua.Text))
                {
                    if(_usuarios[_posicion].Clave == tbClaveAntigua.Text)
                    {
                        DialogResult Decision = MessageBox.Show("Su Usuario sera cambiado.\n\nEsta de Acuerdo?", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        if (Decision == DialogResult.OK)
                        {
                            _usuarios[_posicion].NombreUsuario = tbUsuario.Text;
                            MessageBox.Show("Cambio realizado Exitosamente!", "Nombre de Usuario Cambiado Correctamente", MessageBoxButtons.OK, MessageBoxIcon.None);
                            string Json = JsonConvert.SerializeObject(_usuarios.ToArray(), Formatting.Indented);
                            File.WriteAllText(_path, Json);
                            this.Close();
                        }
                    }
                    else MessageBox.Show("Su Clave Actual es Incorrecta,\nPor favor introduzcala de Nuevo.", "Clave Actual erronea", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else MessageBox.Show("Para Cambiar su Nombre de Usuario\nPor Favor Ingrese Su Clave actual\n en el Campo de Clave Anterior", "Clave Necesaria", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (DatoRepetido() && _usuarios[_posicion].NombreUsuario != tbUsuario.Text) MessageBox.Show("El Nombre de Usuario Introducido Ya existe", "Nombre de Usuario Ya Existente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            #endregion

            //Si no se Hace nada y le unde click al boton de Aceptar, Se cierra la Ventana

            else this.Close();
        }
    }
}
