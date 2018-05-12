using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_enlazadas_dobles
{
    class Estructura
    {
        Producto inicio = null, ultimo = null;

        public void agregar(Producto nuevo)
        {
            Producto t = inicio;

            if (inicio == null)
            {
                inicio = nuevo;
                ultimo = nuevo;

            }

            else if(nuevo.Codigo < inicio.Codigo)
            {
                nuevo.Siguente = inicio;
                inicio.Anterior = nuevo;
                inicio = nuevo;
            }

            else if(nuevo.Codigo > ultimo.Codigo)
            {
                ultimo.Siguente = nuevo;
                nuevo.Anterior = ultimo;
                ultimo = nuevo;
            }

            else
            {
                while (nuevo.Codigo > t.Codigo)
                {
                    t = t.Siguente;
                }
                nuevo.Anterior = t.Anterior;
                nuevo.Siguente = t;
                t.Anterior.Siguente = nuevo;
                t.Anterior = nuevo;
            }
        }

        public Producto buscar(int codigo)
        {
            Producto t = inicio;
            while(t != null)
            {
                if (t.Codigo == codigo)
                    return t;
                t = t.Siguente;
            }
            return null;
        }

        public void eliminar(int codigo)
        {
            Producto t = inicio, p = null;

            if (inicio.Codigo == codigo)
            {
                inicio = inicio.Siguente;
                inicio.Anterior = null;
            }

            else if (ultimo.Codigo == codigo)
            {
                p = ultimo.Anterior;
                p.Siguente = null;
                ultimo.Anterior = null;
                ultimo = p;
            }
            else
            {
                while(t != null)
                {
                    if (t.Codigo == codigo)
                    {
                        t.Anterior.Siguente = t.Siguente;
                        t.Siguente.Anterior = t.Anterior;
                        break;
                    }
                    t = t.Siguente;
                }
            }
        }
        
        public string listar()
        {
            string output = "";
            Producto t = inicio;

            while (t != null)
            {
                output += t.ToString() + "\r\n";
                t = t.Siguente;
            }
            return output;
        }

        public string listarInverso()
        {
            string output = "";
            Producto t = ultimo;

            while (t != null)
            {
                output += t.ToString() + "\r\n";
                t = t.Anterior;
            }
            return output;
        }

        public void eliminarUltimo()
        {
            Producto t = inicio, p = null;

            if(inicio == ultimo)
            {
                inicio = null;
                ultimo = null;
            }
            else
            {
                p = ultimo.Anterior;
                p.Siguente = null;
                ultimo.Anterior = null;
                ultimo = p;
            }
            
        }

        public void eliminarPrimero()
        {
            Producto t = inicio;

            if (ultimo == inicio)
            {
                inicio = null;
                ultimo = null;
            }

            else
            {
                inicio = inicio.Siguente;
                inicio.Anterior = null;
            }
        }


    }
}
