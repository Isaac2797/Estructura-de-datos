using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_Circulares
{
    class Estructura
    {
        Base inicio = null, ultimo = null;

        public void Agregar(Base nuevo)
        {
            Base t = inicio;

            if (inicio == null)
            {
                inicio = nuevo;
                ultimo = nuevo;
                inicio.Anterior = ultimo;
                ultimo.Siguente = inicio;
            }

            else
            {
                nuevo.Anterior = ultimo;
                ultimo.Siguente = nuevo;
                ultimo = nuevo;
                inicio.Anterior = ultimo;
                ultimo.Siguente = inicio;
            }
        }

        public Base Buscar(string nombre)
        {
            Base t = inicio;

            while (t.Siguente != inicio)
            {
                if (t.NombreBase == nombre)
                {
                    return t;
                }
                t = t.Siguente;
            }
            if (t.NombreBase == nombre)
            {
                return t;
            }
            return null;
        }

        public Base EliminarUltimo()
        {
            Base t = inicio, p = null, r = null;
            if (inicio == ultimo)
            {
                r = ultimo;
                r.Anterior = r.Siguente = null;
                inicio = null;
                ultimo = null;
            }
            else
            {
                p = ultimo.Anterior;
                p.Siguente = null;
                ultimo.Anterior = null;
                r = ultimo;
                r.Anterior = r.Siguente = null;
                ultimo = p;
                ultimo.Siguente = inicio;
            }
            return r;
        }

        public Base EliminarInicio()
        {
            Base t = inicio, r = null;
            if (ultimo == inicio)
            {
                r = inicio;
                r.Anterior = r.Siguente = null;
                inicio = null;
                ultimo = null;
            }
            else
            {
                r = inicio;
                r.Anterior = r.Siguente = null;
                inicio = inicio.Siguente;
                ultimo.Siguente = inicio;
                inicio.Anterior = ultimo;
            }
            return r;
        }

        public string listar()
        {
            string output = "";
            Base t = inicio;
            if(inicio == null)
            {
                output = "No existen bases";
            }
            else
            {
                while (t.Siguente != inicio)
                {
                    output += t.ToString() + "\r\n";
                    t = t.Siguente;
                }
                output += t.ToString() + "\r\n";
            }
            return output;
        }

        public void Insertar(Base nuevo, int pos)
        {
            Base t = inicio;
            int c = 1;


            if (inicio == null)
            {
                inicio = nuevo;
                ultimo = nuevo;
            }
            
            else
            {
                while (c != pos)
                {
                    t = t.Siguente;
                    c++;
                    if(t == inicio)
                    {
                        break;
                    }
                }
                if(c == pos)
                {
                    t.Anterior.Siguente = nuevo;
                    nuevo.Anterior = t.Anterior;
                    t.Anterior = nuevo;
                    nuevo.Siguente = t;
                    if(c == 1)
                    {
                        inicio = nuevo;
                    }
                }
                else
                {
                    string show = "No es posible";
                }
            }
        }

        public Base Eliminar(string nombre)
        {
            Base t = inicio, r = null;
            if (inicio.NombreBase == ultimo.NombreBase)
            {
                r = inicio;
                r.Anterior = r.Siguente = null;
                inicio = null;
                ultimo = null;
            }

            else if (inicio.NombreBase == nombre)
            {
                r = inicio;
                r.Anterior = r.Siguente = null;
                inicio.Anterior.Siguente = inicio.Siguente;
                inicio.Siguente.Anterior = ultimo;
                inicio = inicio.Siguente;
            }
            else if (ultimo.NombreBase == nombre)
            {
                r = ultimo;
                r.Anterior = r.Siguente = null;
                ultimo.Anterior.Siguente = inicio;
                ultimo.Siguente.Anterior = ultimo.Anterior;
                ultimo = ultimo.Anterior;
            }
            else
            {
                while (t.Siguente != inicio)
                {
                    if (t.NombreBase == nombre)
                    {
                        r = t;
                        r.Anterior = r.Siguente = null;
                        t.Anterior.Siguente = t.Siguente;
                        t.Siguente.Anterior = t.Anterior;
                    }
                    t = t.Siguente;
                }
            }
            return r;
        }

        public string Ruta(string nombreBase, DateTime horainicio, DateTime horafin)
        {
            Base t = inicio;
            DateTime Recorrido;
            string data = "";

            while (t.NombreBase != nombreBase)
            {
                t = t.Siguente;
                if (t == inicio)
                {
                    break;
                }
            }
            if(t.NombreBase == nombreBase)
            {
                Recorrido = horainicio;
                data = "Base: " + t.NombreBase + " Tiempo: " + Recorrido.ToShortTimeString() + "\r\n";
                while (Recorrido < horafin)
                {
                    t = t.Siguente;
                    Recorrido = Recorrido.AddMinutes(t.Tiempo);
                    data += "Base: " + t.NombreBase + " Tiempo: " + Recorrido.ToShortTimeString() + "\r\n";
                }
            }
            else
            {
                return null;
            }
            return data;
        }
    }
}
