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
        private int _codigo;
        public int Codigo { get { return _codigo; } }
        private int _precio;
        private string _descripcion;
        private string _marca;

        public Producto(string nombre, int codigo, int precio, string descripcion, string marca)
        {
            _nombre = nombre;
            _codigo = codigo;
            _precio = precio;
            _descripcion = descripcion;
            _marca = marca;
        }

        public override string ToString()
        {
            return _nombre + "___" + _codigo.ToString() + "___" + _precio.ToString() + "___" + _descripcion + "___" + _marca + "\r\n";
        }
    }
}
