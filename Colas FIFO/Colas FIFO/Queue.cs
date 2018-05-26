using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colas_FIFO
{
    class Queue
    {
        Proceso inicio = null;

        public int Peek()
        {
            if (inicio == null)
                return 0;
            else
                return inicio.Process;
        }

        public Proceso Pop()
        {
            Proceso r;
            if (inicio.Siguiente != null)
            {
                r = inicio;
                inicio = inicio.Siguiente;
                return inicio;
            }
            else
            {
                r = inicio;
                inicio = null;
                return inicio;
            }
        }

        public void Put(Proceso nuevo)
        {
            if (inicio == null)
                inicio = nuevo;
            else
            {
                agregar(nuevo, inicio);
            }
        }
        private void agregar(Proceso nuevo, Proceso quien)
        {
            if (quien.Siguiente != null)
                agregar(nuevo, quien.Siguiente);
            else
                quien.Siguiente = nuevo;
        }

        public int Count()
        {
            Proceso t = inicio;
            int sum = 0;
            while(t != null)
            {
                sum += Peek();
                t = t.Siguiente;
            }
            return sum;
        }
    }
}
