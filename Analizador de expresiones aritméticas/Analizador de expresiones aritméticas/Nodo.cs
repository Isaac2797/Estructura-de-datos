using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analizador_de_expresiones_aritméticas
{
    class Nodo
    {
        private string _value;
        public string value
        {
            set { _value = value; }
            get { return _value; }
        }
        private Nodo _siguiente;
        private Nodo _Left;
        private Nodo _Right;

        public Nodo Left
        {
            get { return _Left; }
            set { _Left = value; }
        }
        public Nodo Right
        {
            get { return _Right; }
            set { _Right = value; }
        }

        public Nodo Siguiente
        {
            get { return _siguiente; }
            set { _siguiente = value; }
        }

        public Nodo(string value)
        {
            _value = value;
        }


    }
}
