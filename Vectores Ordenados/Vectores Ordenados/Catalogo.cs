using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectores_Ordenados
{
    class Catalogo
    {
        Producto[] reg = new Producto[15];
        string output = "";

        public void Agregar(Producto producto)
        {

                for (int i = 0; i <= reg.Length-1; i++)
                {
                    if (reg[i] == null)
                    {
                        reg[i] = producto;
                        break;
                    }
                }
        }

        public void Eliminar(string codigo)
        {
            for (int i = 0; i < reg.Length; i++)
            {
                if (reg[i] != null)
                    if (reg[i].Codigo == codigo)
                    {
                        reg[i] = null;
                        return;
                    }
            }
            throw new System.Exception("Does Not Exist");
        }

        public Producto Buscar(string codigo)
        {
            for (int i = 0; i < reg.Length; i++)
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

        public string Listar()
        {
            output = "";
            for (int i = 0; i < reg.Length; i++)
            {
                if (reg[i] == null)
                {
                    output += "Empty Spot" + "\r\n";
                }
                else
                    output += reg[i];
            }
            return output;
        }

    }
}
