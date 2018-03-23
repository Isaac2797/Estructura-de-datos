using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coladera_de_Eratostenes
{
    class Eratosthenes
    {
        private int[] _vec;

        public Eratosthenes(int size)
        {
            _vec = new int[size];
        }

        public void fill()
        {
            for(int i = 2; i < _vec.Length; i++)
            {
                _vec[i] = 1;
            }
        }

        public void findPrimes()
        {
            for (int i = 2; i < _vec.Length; i++)
            {
                for (int j = 2; j * i < _vec.Length; j++)
                {
                    _vec[j * i] = 0;
                }
            }
        }

        public string getPrimes()
        {
            string primes = "";
            for (int i = 2; i < _vec.Length; i++)
            {
                if(_vec[i] == 1)
                {
                    primes += i + ", ";
                }
            }
            return primes;
        }
    }
}
