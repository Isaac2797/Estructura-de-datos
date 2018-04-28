using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graficos_por_Tortuga
{
    class Campo
    {
        Tortuga turtle = new Tortuga();
        private int[,] _matriz;
        private int i = 0, j = 0, c = 0;
        private string output;

        public Campo()
        {
             _matriz = new int[20, 20];
            _matriz[0, 0] = 1;
           
        }
        public void llenar()
        {
            for (int i = 0; i < _matriz.Length; i++)
            {
                for (int j = 0; j < _matriz.Length; j++)
                {
                    _matriz[i, j] = 0;
                }
            }
        }
        public void Avanzar(int times)
        {
            if (turtle.direction == 1)
            {
                int y = j + 1;
                c = y + times;
                for (j = y; j < c; j++)
                {
                    if(turtle.pluma == false)
                    {
                        _matriz[i, j] = 1;
                    }
                }
                j--;
            }
            else if (turtle.direction == 4)
            {
                int x = i + 1;
                c = x + times;
                for (i = x; i < c; i++)
                {
                    if (turtle.pluma == false)
                    {
                        _matriz[i, j] = 1;
                    }
                }
                i--;
            }
            else if (turtle.direction == 2)
            {
                int o = i - 1;
                c = i - times;
                for (i = o; i >= c; i--)
                {
                    if (turtle.pluma == false)
                    {
                        _matriz[i, j] = 1;
                    }
                }
                i++;
            }
            else if (turtle.direction == 3)
            {
                int p = j - 1;
                c = j - times;
                for (j = p; j >= c; j--)
                {
                    if (turtle.pluma == false)
                    {
                        _matriz[i, j] = 1;
                    }
                }
                j++;
            }
        }
        public string Mostar()
        {
            output = "";
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    output += _matriz[i, j] + "  ";
                }
                output += "\r\n";
            }
            return output;
        }

        public void PlumaArriba()
        {
            turtle.pluma = true;
        }

        public void PlumaAbajo()
        {
            turtle.pluma = false;
        }

        public void GirarDerecha()
        {
            if (turtle.direction == 1)
            {
                turtle.direction = 4;
            }
            else
            {
                turtle.direction--;
            }
        }

        public void GirarIzquierda()
        {
            if (turtle.direction == 4)
            {
                turtle.direction = 1;
            }
            else
            {
                turtle.direction++;
            }
        }
    }
}
