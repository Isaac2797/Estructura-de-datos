using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analizador_de_expresiones_aritméticas
{
    class EstructuraStack
    {
        Nodo inicio = null;
        public void Put(Nodo nuevo)
        {
            if (inicio == null)
                inicio = nuevo;
            else
            {
                agregar(nuevo, inicio);
            }
        }
        private void agregar(Nodo nuevo, Nodo quien)
        {
            if (quien.Siguiente != null)
                agregar(nuevo, quien.Siguiente);
            else
                quien.Siguiente = nuevo;
        }

        public Nodo Pop()
        {
            Nodo t = inicio, r;
            if(t.Siguiente == null)
            {
                r = t;
                inicio = null;
            }
            else
            {
                while (t.Siguiente.Siguiente != null)
                {
                    t = t.Siguiente;
                }
                r = t.Siguiente;
                t.Siguiente = null;
            }
            return r;
        }

        public Nodo end()
        {
            if (inicio == null)
            {
                return null;
            }
            else
                return inicio;
        }
    }
}
