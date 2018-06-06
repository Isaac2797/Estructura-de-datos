using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procesos_Circulares
{
    class Estructura
    {
        Proceso inicio = null, ultimo = null, actual = null;

        public Proceso Peek(Proceso actual)
        {
            if (actual == null)
                return null;
            else if(actual.Process == 0)
            {
                actual = null;
                return actual;
            }
            else
                return actual;
            
        }

        public void Pop(Proceso actual)
        {
            actual.Anterior.Siguiente = actual.Siguiente;
            actual.Siguiente.Anterior = actual.Anterior;
            actual = actual.Anterior;

            while(ultimo.Process == 0)
            {
                ultimo = ultimo.Anterior;
                if (inicio.Process == 0 && ultimo.Process == 0)
                {
                    inicio = null;
                    ultimo = null;
                    actual = null;
                    break;
                }
            }
            if(inicio != null)
            {
                while (inicio.Process == 0)
                {
                    inicio = inicio.Siguiente;
                }
            }
            this.actual = actual;
        }

        public void Put(Proceso nuevo)
        {
            Proceso t = inicio;

            if (inicio == null)
            {
                actual = nuevo;
                inicio = nuevo;
                ultimo = nuevo;
                inicio.Anterior = ultimo;
                ultimo.Siguiente = inicio;
            }

            else
            {
                nuevo.Anterior = ultimo;
                ultimo.Siguiente = nuevo;
                ultimo = nuevo;
                inicio.Anterior = ultimo;
                ultimo.Siguiente = inicio;
            }
        }

        public int Count()
        {
            Proceso t = inicio.Siguiente;
            int sum = 0;
            while (t != inicio)
            {
                sum += t.Process;
                t = t.Siguiente;
            }
            sum += t.Process;
            return sum;
        }

        public Proceso Next()
        {
            if (actual == null)
                return null;
            else
            {
                actual = actual.Siguiente;
                return actual;
            }
            
        }
    }
}
