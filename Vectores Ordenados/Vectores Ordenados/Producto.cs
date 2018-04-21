using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectores_Ordenados
{
    class Producto
    {
        private string _nombre;
        private string _codigo;
        public string Codigo { get { return _codigo; } }
        private int _precio;
        private string _descripcion;
        private string _marca;

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
            return _nombre + "___" + _codigo + "___" + _precio.ToString() + "___" + _descripcion + "___" + _marca + "\r\n";
        }
    }
}
