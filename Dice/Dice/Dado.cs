using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice
{
    class Dado
    {
        private int _dice;
        Random rt = new Random();

        public Dado()
        {
            _dice = 0;
        }

        public int Lanzar()
        {
            int num = rt.Next(1,7);
            return num;
        }
    }
}
