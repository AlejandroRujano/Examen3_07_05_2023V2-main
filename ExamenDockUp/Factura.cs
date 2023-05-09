using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ExamenDockUp
{
    public class Factura
    {
        private string _numero;
        private List<string> _datosEmpresa;
        private string _fecha;
        private double _total;
        private double _impuesto;
        private List<Productos> _compras = new List<Productos>();
        private Cliente _cliente = new Cliente();
        private List<string> _vendedor;
        public Factura()
        {
            _fecha = "0/0/0";
            _total = -1;
            _impuesto = -1;
            _numero = "";
        }
        public Factura(string Fecha, List<string> DatosEmpresa, string NumeroFactura, List<Productos> Compras, Cliente Cliente, List<string> Vendedor, double total, double Impuesto)
        {
            _fecha = Fecha;
            _total = total;
            _impuesto = Impuesto;
            _compras = Compras;
            _cliente = Cliente;
            _numero= NumeroFactura;
            _datosEmpresa = DatosEmpresa;
            _vendedor = Vendedor;
        }
        public string Numero { get { return _numero; } set { _numero = value; } }
        public List<string> DatosEmpresa { get { return _datosEmpresa; } set { _datosEmpresa = value; } }
        public List<string> Vendedor { get { return _vendedor; } set { _vendedor = value; } }
        public string Fecha { get { return _fecha; } set { _fecha = value; } }
        public List<Productos> Compras { get { return _compras; } set { _compras = value; } }
        public Cliente Cliente { get { return _cliente; } set { _cliente = value; } }
        public double Total { get { return _total; } set { _total = value; } }
        public double Impuesto { get { return _impuesto; } set { _impuesto = value; } }
    }
}
