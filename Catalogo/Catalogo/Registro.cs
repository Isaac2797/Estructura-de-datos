using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo
{
    class Registro
    {
        Producto[] reg = new Producto[15];
        string output="";
        
        public void Agregar(Producto producto)
        {
           for(int i = reg.Length-1; i >= 1; i--)
            {
              reg[i] = reg[i-1];
            }
            reg[0] = producto;
        }

        public Producto Buscar(string codigo)
        {
            for(int i = 0; i < reg.Length; i++)
            {
                if (reg[i] != null)
                {
                    if (reg[i].Codigo == codigo)
                    {
                        return reg[i];
                    }
                }
            }
            throw new System.Exception("Not Found");
        }

        public void Eliminar(string codigo)
        {
            for (int i = 0; i < reg.Length; i++)
            {
                if (reg[i] != null)
                {
                    if (reg[i].Codigo == codigo)
                    {
                        for (; i < reg.Length - 1; i++)
                        {
                            reg[i] = reg[i + 1];
                        }
                        reg[reg.Length - 1] = null;
                        break;
                    }
                }
            }
        }
        public void Insertar(Producto producto, int posicion)
        {
            for(int i = reg.Length-1; i > posicion-1; i--)
            {
                reg[i] = reg[i - 1];
            }
            reg[posicion] = producto;

        }
        public string Listar()
        {
            output = "";
            for (int i = 0; i < reg.Length; i++)
            {
                output += reg[i];
            }
            return output;
        }

    }
}
