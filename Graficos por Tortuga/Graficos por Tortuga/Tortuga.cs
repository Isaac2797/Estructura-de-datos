using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graficos_por_Tortuga
{
    class Tortuga
    {
        private static int _steps;
        public int steps { get { return _steps; } }

        private static bool _pluma;
        public bool pluma = _pluma;

        private static int _direction;
        public int direction = _direction;

        public Tortuga()
        {
            _steps = 0;
            pluma = false;
            direction = 1;
        }
    }
}
