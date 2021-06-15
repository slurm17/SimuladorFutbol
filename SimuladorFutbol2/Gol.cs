using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorFutbol2
{
    class Gol
    {
        //private Random rdn;

        public int Goles()
        {
            //rdn = new Random();
            return _Goles(sC.rdn.Next(1, 100));
        }

        private int _Goles(int g)
        {
            if (g < 31)
                return 0;
            else if (g < 56)
                return 1;
            else if (g < 76)
                return 2;
            else if (g < 91)
                return 3;
            else if (g < 97)
                return 4;
            else if (g < 100)
                return 5;
            else return 6;
        }

    }
}
