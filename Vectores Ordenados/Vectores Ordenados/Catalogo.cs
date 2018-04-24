using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectores_Ordenados
{
    class Catalogo
    {
        Producto[] reg;
        string output = "";

        public Catalogo()
        {
            reg = new Producto[15];
        }

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
            Acomodar();
        }

        public void Eliminar(int codigo)
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

        public Producto Buscar(int codigo)
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

        public void Acomodar()
        {
            Producto value = null;
            for(int i = 0; i < reg.Length-1; i++)
            {
                for(int j = 0; j < reg.Length-1; j++)
                {
                    if (reg[j+1] != null)
                    {
                        if (reg[j].Codigo > reg[j + 1].Codigo)
                        {
                            value = reg[j];
                            reg[j] = reg[j + 1];
                            reg[j + 1] = value;
                        }
                    }
                }
            }
        }
    }
}
