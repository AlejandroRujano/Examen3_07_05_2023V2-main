using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenDockUp
{
    public class Productos
    {
        private string _codigo;
        private string _nombre;
        private double _precio;
        private string _descripcion;
        private bool _disponible;
        private bool _eliminado;
        private long _cantidad;
        public long Cantidad { get { return _cantidad; } set { _cantidad = value; } }
        public bool Disponible { get { return _disponible; } set { _disponible = value; } }
        public bool Eliminado { get { return _eliminado; } set { _eliminado = value; } }
        public string Descripcion { get { return _descripcion; } set { _descripcion = value; } }
        public double Precio { get { return _precio; } set { _precio = value; } }
        public string Nombre { get { return _nombre; } set { _nombre = value; } }
        public string Codigo { get { return _codigo; } set { _codigo = value; } }
        public Productos(string codigo, string nombre, string descripcion, long cantidad, double precio)
        {
            _codigo = codigo;
            _nombre = nombre;
            _precio = precio;
            _descripcion = descripcion;
            _cantidad = cantidad;
            _disponible = true;
            _eliminado = false;
        }
        public string Data_Codigo()
        {
            return $"#{_codigo}  {_nombre}";
        }
    }
}
