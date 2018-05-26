using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colas_FIFO
{
    class Proceso
    {
        Random rt = new Random();

        private int _proceso;
        public int Process { get { return _proceso; } }
        private Proceso _siguiente;
        public Proceso Siguiente
        {
            get { return _siguiente; }
            set { _siguiente = value; }
        }

        public Proceso(int proceso)
        {
            _proceso = proceso;
        }
    }
}
