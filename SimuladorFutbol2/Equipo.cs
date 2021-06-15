using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorFutbol2
{
    class Equipo
    {
        public string nombre { set; get; }
        public string id { set; get; }
        public int puntos { set; get; }
        public int pj { set; get; }
        public int pg { set; get; }
        public int pe { set; get; }
        public int pp { set; get; }
        public int dif { set; get; }

        public Equipo()
        {
            puntos = 0;
            pj = 0;
            pg = 0;
            pe = 0;
            pp = 0;
            dif = 0;
        }
    }
}
