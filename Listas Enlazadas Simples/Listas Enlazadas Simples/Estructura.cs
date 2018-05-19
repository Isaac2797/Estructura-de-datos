using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_Enlazadas_Simples
{
    class Estructura
    {
        Producto inicio = null;

        public void agregar(Producto nuevo)
        {
            if (inicio == null)
                inicio = nuevo;
            else
            {
                agregar(nuevo, inicio);
            }
        }

        private void agregar(Producto nuevo, Producto quien)
        {
            if (quien.Siguente != null)
                agregar(nuevo, quien.Siguente);
            else
                quien.Siguente = nuevo;
        }

        public Producto buscar(int codigo)
        {
            Producto t = inicio;
            while (t != null)
            {
                if (t.Codigo == codigo)
                    return t;
                t = t.Siguente;
            }
            return null;
        }

        public void Inverso()
        {
            Producto t = inicio, backup = null, helper;

            while (t != null)
            {
                helper = t.Siguente;
                t.Siguente = backup;
                backup = t;
                t = helper;
            }
            inicio = backup;
        }
        public string listarInverso()
        {
            string output = "";
            Producto t = inicio;

            while (t != null)
            {
                output = t.ToString() + "\r\n" + output;
                t = t.Siguente;
            }
            return output;
        }

        public void eliminarUltimo()
        {
            Producto t = inicio;

            while (t.Siguente.Siguente != null)
            {

                t = t.Siguente;
            }
            t.Siguente = null;
        }

        public void eliminarPrimero()
        {
            Producto t = inicio;

            if (t.Siguente != null)
                inicio = t.Siguente;
            else
                inicio = null;
        }
    }
}
