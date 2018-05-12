using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_Enlazadas_Simples
{
    class Producto
    {

        private string _nombre;
        private string _codigo;
        public string Codigo { get { return _codigo; } }
        private int _precio;
        private string _descripcion;
        private string _marca;

        private Producto _siquiente;
        public Producto Siguente
        {
            get { return _siquiente; }
            set { _siquiente = value; }
        }

        public Producto(string nombre, string codigo, int precio, string descripcion, string marca)
        {
            _nombre = nombre;
            _codigo = codigo;
            _precio = precio;
            _descripcion = descripcion;
            _marca = marca;
        }

        public override string ToString()
        {
            return "Nombre = " + _nombre + " Codigo = " + _codigo + " Precio = " + _precio + " Descripcion = " + _descripcion + " Marca = " + _marca;
        }
    }
}
