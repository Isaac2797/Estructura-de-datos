using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liebre_vs_Tortuga
{
    class Tortuga : Animales
    {
        public override int Correr()
        {
            int steps = 0;

            int speed = rt.Next(1, 11);

            if (speed <= 5)
            {
                steps += 3;
            }
            else if (speed >= 6 && speed <= 7)
            {
                steps -= 6;
            }
            else
            {
                steps += 1;
            }
           
            return steps;
        }
    }
}
