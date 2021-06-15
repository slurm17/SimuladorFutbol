using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuladorFutbol2
{
    class DataBaseLiga : DataBase
    {
        public DataTable MostrarPartidosLiga(int f)
        {
            string query = "select * from fixture where fecha = " + f;
            return GenerarTabla(query);
        }

        public DataTable MostrarEquiposLiga()
        {
            string query = "select * from posiciones order by puntos desc, dif desc";
            return GenerarTabla(query);
        }

        public void InsertarPartidoEnFixture(int fecha, string idL, string idV)
        {
            try
            {
                dbConexion.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO `fixture`(`fecha`, `equipoL` , `equipoV`) " +
                            "VALUES('" + fecha + "','" + idL + "','" + idV + "')", dbConexion);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
            finally { dbConexion.Close(); }
        }

        public void ProximaFecha(int f)
        {
            f++;
            try
            {
                dbConexion.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE `fecha_actual` SET `fecha` = " + f + " ", dbConexion);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
            finally { dbConexion.Close(); }
        }

        public void FechaUno()
        {
            try
            {
                dbConexion.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE `fecha_actual` SET `fecha` = 1 ", dbConexion);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
            finally { dbConexion.Close(); }
        }

        public int MostrarFechaActual()
        {
            int fecha = -1;
            try
            {
                dbConexion.Open();
                MySqlCommand cmd = new MySqlCommand("select * from fecha_actual ", dbConexion);
                MySqlDataReader myReader = cmd.ExecuteReader();
                if (myReader.HasRows)//Mientras haya filas
                {
                    while (myReader.Read())
                    {
                        fecha = myReader.GetInt32(0);
                    }
                }
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
            finally { dbConexion.Close(); }
            return fecha;
        }

        public void GuardarResultado(Partido p, int fecha)
        {
            try
            {
                //Console.WriteLine(p.golIntE1+" "+ p.golIntE2+" "+ fecha+" "+ p.eq1.id+" "+ p.eq2.id);
                dbConexion.Open();
                MySqlCommand cmd = new MySqlCommand(String.Format("UPDATE `fixture` SET `golL`={0},`golV`={1} WHERE " +
                    "(`fecha`={2}) AND (`equipoL`=\"{3}\") AND (`equipoV`=\"{4}\")", p.golIntE1, p.golIntE2, fecha, p.eq1.id, p.eq2.id), dbConexion);
                //Console.WriteLine(String.Format("UPDATE `fixture` SET `golL`={0},`golV`={1} WHERE " +
                //  "(`fecha`={2}) AND (`equipoL`=\"{3}\") AND (`equipoV`=\"{4}\")", p.golIntE1, p.golIntE2, fecha, p.eq1.id, p.eq2.id));
                cmd.ExecuteNonQuery();
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
            finally { dbConexion.Close(); }

            //CalcularDatos(p);
            GuardarDatos(p.eq1);
            GuardarDatos(p.eq2);
        }

        
    }
}
