using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorFutbol2
{
    class Partido
    {
        public Equipo eq1 { get; set; }
        public Equipo eq2 { get; set; }
        public int golIntE1 { get; set; }
        public int golIntE2 { get; set; }
        private bool penales;
        public bool ganoE1 { get; set; }
        public bool ganoE2 { get; set; }
        public bool empate { get; set; }
        private int pen1, pen2;
        public string golStrE1 { get; set; }
        public string golStrE2 { get; set; }
        private Gol g = new Gol();

        public Partido(Equipo e1, Equipo e2, bool penales)
        {
            eq1 = e1;
            eq2 = e2;
            ganoE1 = false;
            ganoE2 = false;
            this.penales = penales;
        }

        public void Jugar()
        {
            
            golIntE1 = g.Goles();
            golIntE2 = g.Goles();

            if (golIntE1 > golIntE2)
            {
                ganoE1 = true;
                golStrE1 = golIntE1.ToString();
                golStrE2 = golIntE2.ToString();
            }


            if (golIntE2 > golIntE1)
            {
                ganoE2 = true;
                golStrE1 = golIntE1.ToString();
                golStrE2 = golIntE2.ToString();
            }
            
            if (golIntE1 == golIntE2)
            {
                if (penales)
                {
                    int resta;
                    do
                    {
                        pen1 = g.Goles();
                        pen2 = g.Goles();
                        resta = Math.Abs(pen1 - pen2);
                    } while (pen1 == pen2 || resta > 2 || pen1 < 2 || pen2 < 2);
                    if (pen1 > pen2)
                        ganoE1 = true;
                    else
                        ganoE2 = true;

                    golStrE1 = String.Format("{0}({1})", golIntE1, pen1);
                    golStrE2 = String.Format("{0}({1})", golIntE2, pen2);
                }
                else
                    empate = true;
            }

            CalcularPuntos();
        }

        private void CalcularPuntos()
        {
            if (empate)
            {
                eq1.pe++; eq2.pe++; eq1.puntos++; eq2.puntos++;
            }
            else if (ganoE1)
            {
                eq1.pg++; eq2.pp++; eq1.puntos += 3;
            }
            else
            {
                eq2.pg++; eq1.pp++; eq2.puntos += 3;
            }
            eq1.pj++; eq2.pj++;

            int dif1, dif2;
            dif1 = golIntE1 - golIntE2;
            dif2 = golIntE2 - golIntE1;
            eq1.dif += dif1; eq2.dif += dif2;
        }
    }
}
