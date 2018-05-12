using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_enlazadas_dobles
{
    class Producto
    {
        private string _nombre;
        private int _codigo;
        public int Codigo { get { return _codigo; } }
        private int _precio;
        private string _descripcion;
        private string _marca;

        private Producto _siquiente;
        public Producto Siguente
        {
            get { return _siquiente; }
            set { _siquiente = value; }
        }

        private Producto _anterior;
        public Producto Anterior
        {
            get { return _anterior; }
            set { _anterior = value; }
        }

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
            return "Nombre = " + _nombre + " Codigo = " + _codigo + " Precio = " + _precio + " Descripcion = " + _descripcion + " Marca = " + _marca;
        }
    }
}
