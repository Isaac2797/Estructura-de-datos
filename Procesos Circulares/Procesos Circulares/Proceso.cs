using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procesos_Circulares
{
    class Proceso
    {
        Random rt = new Random();

        private int _proceso;
        public int Process
        {
            get { return _proceso; }
            set { _proceso = value; }
        }
        private Proceso _siguiente;
        private Proceso _anterior;
        public Proceso Siguiente
        {
            get { return _siguiente; }
            set { _siguiente = value; }
        }
        public Proceso Anterior
        {
            get { return _anterior; }
            set { _anterior = value; }
        }

        public Proceso(int proceso)
        {
            _proceso = proceso;
        }
    }
}
