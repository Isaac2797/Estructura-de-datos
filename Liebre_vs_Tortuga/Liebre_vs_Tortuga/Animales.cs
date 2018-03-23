using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liebre_vs_Tortuga
{
    abstract class Animales
    {
        public static Random rt = new Random();
        protected static int _steps;
        public int steps { get { return _steps; } }

        protected static int _position;
        public int position = _position;

        public Animales()
        {
            _steps = 0;
            _position = 0;
        }

        public abstract int Correr();
    }
}
