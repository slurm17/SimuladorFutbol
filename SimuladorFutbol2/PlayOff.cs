using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorFutbol2
{
    
    class PlayOff
    {
        private Equipo[] equipos = new Equipo[8];
        public Partido[] cuartos { set; get; }
        public Partido[] semis { set; get; }
        public Partido final { set; get; }
        public Equipo campeon = new Equipo();

        public PlayOff()
        {
            cuartos = new Partido[4];
            semis = new Partido[2];
            int c = 0;
            bool bandera = false;
            

            do
            {
                if (sC.equipos[c].id == sC.eqSeleccionado)
                {
                    equipos[0] = sC.equipos[c];
                    bandera = true;
                }
                c++;

            } while (!bandera);

            
            sC.Shuffle(sC.equipos);

            int c2 = 0;
            for (int i = 1; i < 8; i++)
            {
                if (sC.equipos[c2].id != sC.eqSeleccionado)
                    this.equipos[i] = sC.equipos[c2];
                else
                    i--;
                c2++;
            }

            Cuartos();
        }

        private void Cuartos()
        {
            cuartos[0] = new Partido(equipos[0], equipos[1], true);
            cuartos[1] = new Partido(equipos[2], equipos[3], true);
            cuartos[2] = new Partido(equipos[4], equipos[5], true);
            cuartos[3] = new Partido(equipos[6], equipos[7], true);
        }

        public void JugarCuartos()
        {
            foreach (Partido p in cuartos)
                p.Jugar();
            Semis();
        }

        private void Semis()
        {
            Equipo []semisEq= new Equipo[4];

            for (int i = 0; i < 4; i++)
            {
                if (cuartos[i].ganoE1)
                {
                    semisEq[i] = cuartos[i].eq1;
                }
                else
                {
                    semisEq[i] = cuartos[i].eq2;
                }
            }

            this.semis[0] = new Partido(semisEq[0], semisEq[1], true);
            this.semis[1] = new Partido(semisEq[2], semisEq[3], true);
        }

        public void JugarSemis()
        {
            this.semis[0].Jugar();
            this.semis[1].Jugar();

            Final();
        }

        private void Final()
        {
            Equipo[] finalEq = new Equipo[2];
            
            for (int i = 0; i < 2; i++)
            {
                if (this.semis[i].ganoE1)
                {
                    finalEq[i] = semis[i].eq1;
                }
                else
                {
                    finalEq[i] = semis[i].eq2;
                }
            }

            final = new Partido(finalEq[0], finalEq[1], true);
        }

        public void JugarFinal()
        {
            final.Jugar();
            if (this.final.ganoE1)
            {
                this.campeon = final.eq1;
            }
            else
            {
                this.campeon = final.eq2;
            }
        }

    }
}
