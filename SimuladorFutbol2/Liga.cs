using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorFutbol2
{
    class Liga
    {
        private Equipo[,] matriz1, matriz2;
        public Partido[,] partidos { set; get; }
        private string[,] jornadas;
        public int N { set; get; }
        DataBase db;
        //private int fecha;

        public Liga()
        {
            this.N = 6;
            InsertarEquipos();
            CrearFixture();
            //fecha = 0;
        }

        private void InsertarEquipos()
        {
            db = new DataBase();
            int n = 6;
            sC.Shuffle(sC.equipos);
            for (int i = 0; i < n; i++)
            {
                db.InsertarEquipoLiga(sC.equipos[i]);
            }
        }

        private void CrearFixture()
        {
            DataBaseLiga db = new DataBaseLiga();
            matriz1 = new Equipo[N - 1, N / 2];//5x3
            matriz2 = new Equipo[N - 1, N / 2];//5x3
            jornadas = new string[N - 1, N / 2]; //5x3    primera vuelta
            partidos = new Partido[N - 1, N / 2];

            int cont = 0;
            //matriz1
            int cont2 = N - 2;

            for (int i = 0; i < N - 1; i++)//de 0 a i<5
            {
                for (int j = 0; j < N / 2; j++)//de 0 a i<3
                {
                    //matriz1
                    matriz1[i, j] = sC.equipos[cont];
                    cont++;
                    if (cont == (N - 1)) cont = 0;

                    //matriz2
                    if (j == 0) matriz2[i, j] = sC.equipos[N - 1];// (N - 1).ToString();
                    else
                    {
                        matriz2[i, j] = sC.equipos[cont2];// cont2.ToString();
                        cont2--;
                        if (cont2 == -1) cont2 = N - 2;
                    }


                    //Elaboro la matriz final de enfrentamientos por jornada (primera vuelta)
                    if (j == 0)
                    {
                        if (i % 2 == 0)
                        {
                            jornadas[i, j] = matriz2[i, j].id + "-" + matriz1[i, j].id + " ";
                            partidos[i, j] = new Partido(matriz2[i, j], matriz1[i, j], false);
                            db.InsertarPartidoEnFixture(i+1, matriz2[i, j].id, matriz1[i, j].id);
                        }
                        else
                        {
                            jornadas[i, j] = matriz1[i, j].id + "-" + matriz2[i, j].id + " ";
                            partidos[i, j] = new Partido(matriz1[i, j], matriz2[i, j], false);
                            db.InsertarPartidoEnFixture(i+1, matriz1[i, j].id, matriz2[i, j].id);
                        }
                    }
                    else
                    {
                        jornadas[i, j] = matriz1[i, j].id + "-" + matriz2[i, j].id + " ";
                        partidos[i, j] = new Partido(matriz1[i, j], matriz2[i, j], false);
                        db.InsertarPartidoEnFixture(i+1, matriz1[i, j].id, matriz2[i, j].id);
                    }
                }
            }

            for (int i = 0; i < N-1; i++)
            {
                for (int j = 0; j < N/2; j++)
                {
                    Console.WriteLine(jornadas[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
