using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenDockUp
{
    // Atributos: Nombre, Apellido, Numero de Telefono, Cedula/Identificacion y Direccion del cliente
    // Metodos: Getters y Setters para los atributos mencionados
    public class Cliente
    {
        private string _nombre;
        private string _apellido;
        private string _numeroDeTlf;
        private string _cedula;

        // Constructor por Default
        public Cliente()
        {
            _nombre = "null";
            _apellido = "null";
            _numeroDeTlf = "";
            //_cedula = -1;
        }

        // Constructor Parametrico
        /*public Cliente(string Nombre, string Apellido, string Direccion, long NumeroDeTlf, long Cedula)
        {
            _nombre = Nombre;
            _apellido = Apellido;
            _numeroDeTlf = NumeroDeTlf;
            _cedula = Cedula;
        }*/
        public Cliente(string Nombre, string Apellido, string Cedula, string NumeroTlf)
        {
            _nombre = Nombre;
            _apellido = Apellido;
            _cedula = Cedula;
            _numeroDeTlf = NumeroTlf;
        }
        public string Identificacion()
        {
            return $"{_nombre} {_apellido}";
        }
        public string DataEliminar()
        {
            return $"Nombre: {_nombre} Cedula: {_cedula}";
        }
        public string Nombre { set { _nombre = value; } get { return _nombre; } }
        public string Apellido { set { _apellido = value; } get { return _apellido; } }
        public string NumeroDeTlf { set { _numeroDeTlf = value; } get { return _numeroDeTlf; } }
        public string Cedula { set { _cedula = value; } get { return _cedula; } }
    }
}
