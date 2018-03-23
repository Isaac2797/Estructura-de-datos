using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liebre_vs_Tortuga
{
    class Liebre : Animales
    {
        public override int Correr()
        {
            int steps = 0;

            int speed = rt.Next(1,11);

            if (speed <= 2)
            {
                steps += 0;
            }
            else if (speed >= 3 && speed <= 4)
            {
                steps += 9;
            }
            else if (speed == 5)
            {
                steps -= 12;
            }
            else if (speed >= 6 && speed <= 8)
            {
                steps += 1;
            }
            else
            {
                steps -= 2;
            }
            return steps;
        }
    }
}
