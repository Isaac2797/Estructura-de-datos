using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_Circulares
{
    class Base
    {
        private string _nombreBase;
        public string NombreBase { get { return _nombreBase; } }
        private int _tiempo;
        public int Tiempo { get { return _tiempo; } }

        private Base _siquiente;
        public Base Siguente
        {
            get { return _siquiente; }
            set { _siquiente = value; }
        }

        private Base _anterior;
        public Base Anterior
        {
            get { return _anterior; }
            set { _anterior = value; }
        }

        public Base(string nombreBase, int tiempo)
        {
            _nombreBase = nombreBase;
            _tiempo = tiempo;
        }

        public override string ToString()
        {
            return "Ruta: " + _nombreBase + " | Tiempo: " + _tiempo;
        }
    }
}
