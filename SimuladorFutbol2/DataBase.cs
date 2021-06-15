using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace SimuladorFutbol2
{
    class DataBase
    {
        protected readonly string MySQLConexion;
        protected MySqlConnection dbConexion;
        protected DataSet dSet;

        public DataBase()
        {
            MySQLConexion = "datasource=127.0.0.1;port=3308;username=root; password=;database=iles";
            try{dbConexion = new MySqlConnection(MySQLConexion);}
            catch(Exception e){MessageBox.Show(e.Message);}
            
        }

        public DataTable GenerarTabla(string query)
        {
            try
            {
                dbConexion.Open();
                MySqlCommand cmd = new MySqlCommand(query, dbConexion);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                dSet = new DataSet();
                adapter.Fill(dSet, "tabla");
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
            finally { dbConexion.Close(); }
            return dSet.Tables["tabla"];
        }

        /*protected Partido CalcularDatos(Partido p)
        {
            Equipo aux1 = new Equipo();
            Equipo aux2 = new Equipo();
            aux1 = EstadisticasEquipo(p.eq1);
            aux2 = EstadisticasEquipo(p.eq2);
            if (p.empate)
            {
                aux1.pe++;aux2.pe++;aux1.puntos++;aux2.puntos++;
            }else if(p.ganoE1)
            {
                aux1.pg++;aux2.pp++;aux1.puntos += 3;
            }else
            {
                aux2.pg++;aux1.pp++;aux2.puntos += 3;
            }
            aux1.pj++;aux2.pj++;

            int dif1, dif2;
            dif1 = p.golIntE1 - p.golIntE2;
            dif2 = p.golIntE2 - p.golIntE1;
            aux1.dif += dif1; aux2.dif += dif2;

            Partido aux3 = new Partido(aux1, aux2, false);
            return aux3;
            //GuardarDatos(aux1);
            //GuardarDatos(aux2);
        }*/

        protected void GuardarDatos(Equipo e)
        {
            try
            {
                //Console.WriteLine(p.golIntE1+" "+ p.golIntE2+" "+ fecha+" "+ p.eq1.id+" "+ p.eq2.id);
                dbConexion.Open();
                MySqlCommand cmd = new MySqlCommand(String.Format("UPDATE `posiciones` SET `pj`={0},`pg`={1},`pe`={2}" +
                    ",`pp`={3},`dif`={4}, `puntos`={6} WHERE `id`=\"{5}\"", e.pj, e.pg, e.pe, e.pp, e.dif, e.id, e.puntos), dbConexion);
                //Console.WriteLine(String.Format("UPDATE `fixture` SET `golL`={0},`golV`={1} WHERE " +
                //  "(`fecha`={2}) AND (`equipoL`=\"{3}\") AND (`equipoV`=\"{4}\")", p.golIntE1, p.golIntE2, fecha, p.eq1.id, p.eq2.id));
                cmd.ExecuteNonQuery();
            }
            catch (Exception ee) { MessageBox.Show(ee.Message); }
            finally { dbConexion.Close(); }
        }

        /*private Equipo EstadisticasEquipo(Equipo e)
        {
            Equipo aux = new Equipo();
            try
            {
                dbConexion.Open();
                MySqlCommand cmd = new MySqlCommand("select * from posiciones where id = \"" + e.id + "\" ", dbConexion);
                MySqlDataReader myReader = cmd.ExecuteReader();
                if (myReader.HasRows)//Mientras haya filas
                {
                    while (myReader.Read())
                    {
                        aux.id = myReader.GetString("id");
                        aux.puntos = myReader.GetInt32("puntos");
                        aux.pj = myReader.GetInt32("pj");
                        aux.pg = myReader.GetInt32("pg");
                        aux.pe = myReader.GetInt32("pe");
                        aux.pp = myReader.GetInt32("pp");
                        aux.dif = myReader.GetInt32("dif");
                    }
                }
            }

            catch (Exception ee) { MessageBox.Show(ee.Message); }
            finally { dbConexion.Close(); }
            return aux;
        }*/

        public void BorrarTablaFixture()
        {
            try
            {
                dbConexion.Open();
                MySqlCommand cmd = new MySqlCommand("TRUNCATE TABLE fixture", dbConexion);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e) { MessageBox.Show(e.Message);}
            finally { dbConexion.Close(); }
        }

        public bool InsertarEquipoLiga(Equipo e)
        {
            bool salida = false;
            try
            {
                dbConexion.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO `posiciones`(`id`,`nombre`) " +
                            "VALUES('"+e.id+"','" + e.nombre + "')", dbConexion);
                int filasAfectadas = cmd.ExecuteNonQuery();
                if (filasAfectadas > 0) return true;
            }
            catch (Exception ee) { MessageBox.Show(ee.Message); }

            finally { dbConexion.Close(); }

            return salida;
        }

        public bool BorrarTablaLiga()
        {
            bool salida = false;
            try
            {
                dbConexion.Open();
                MySqlCommand cmd = new MySqlCommand("TRUNCATE TABLE posiciones", dbConexion);
                int filasAfectadas = cmd.ExecuteNonQuery();
                if (filasAfectadas > 0) return true;
            }
            catch (Exception e) { MessageBox.Show(e.Message); }

            finally { dbConexion.Close(); }

            return salida;
        }

        public DataTable MostrarEquipos()
        {
            //string query = "select id, nombre from equipos";
            //return GenerarTabla(query);
            try
            {
                dbConexion.Open();
                MySqlCommand cmd = new MySqlCommand("select id, nombre from equipos", dbConexion);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                dSet = new DataSet();
                adapter.Fill(dSet, "tabla");
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            finally { dbConexion.Close(); }
            return dSet.Tables["tabla"];
        }

        //public DataTable MostrarEquiposLiga()
        //{
        //    string query = "select * from posiciones order by puntos desc, dif desc";
        //    return GenerarTabla(query);
        //    //try
        //    //{
        //    //    dbConexion.Open();
        //    //    MySqlCommand cmd = new MySqlCommand("select * from posiciones order by puntos desc, dif desc", dbConexion);
        //    //    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
        //    //    dSet = new DataSet();
        //    //    adapter.Fill(dSet, "tabla");   
        //    //}
        //    //catch(Exception e) { Console.WriteLine(e.Message); }
        //    //finally { dbConexion.Close();}
        //    //return dSet.Tables["tabla"];
        //}

        public void CargarEquipos()
        {
            try
            {
                dbConexion.Open();
                MySqlCommand cmd = new MySqlCommand("select * from equipos", dbConexion);
                MySqlDataReader myReader = cmd.ExecuteReader();
                if (myReader.HasRows)//Mientras haya filas
                {
                    while (myReader.Read())
                    {
                        Equipo eq = new Equipo();
                        eq.id = myReader.GetString(0);
                        eq.nombre = myReader.GetString(1);
                        sC.equipos.Add(eq);
                    }
                }
            }
            catch(Exception e){MessageBox.Show(e.Message);}

            finally{dbConexion.Close();}
        }

        public string VerNombre(string id)
        {
            dbConexion.Open();
            string n="";
            string query = "select nombre from equipos where id = '" + id + "'";
            MySqlCommand cmd = new MySqlCommand(query ,dbConexion);
            MySqlDataReader myReader = cmd.ExecuteReader();
            if (myReader.HasRows)//Mientras haya filas
            {
                while (myReader.Read())
                {
                   n = myReader.GetString(0);
                }
            }
            dbConexion.Close();
            return n;
            
        }

        public string VerId(string nom)
        {
            dbConexion.Open();
            string n = "";
            MySqlCommand cmd = new MySqlCommand("select id from equipos where nombre = '" + nom + "'", dbConexion);
            MySqlDataReader myReader = cmd.ExecuteReader();
            if (myReader.HasRows)//Mientras haya filas
            {
                while (myReader.Read())
                {
                    n = myReader.GetString(0);
                }
            }
            dbConexion.Close();
            return n;
        }

        public bool Insertar(string id, string nombre)
        {
            bool salida = false;
            try
            {
                dbConexion.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO `equipos`(`id`, `nombre`) " +
                            "VALUES('" + id + "','" + nombre + "')", dbConexion);
                int filasAfectadas = cmd.ExecuteNonQuery();
                if (filasAfectadas > 0) return true;
            }
            catch(Exception e){MessageBox.Show(e.Message);}

            finally{dbConexion.Close();}

            return salida;
        }

        public bool Eliminar(string id)
        {
            bool salida = false;
            try
            {
                dbConexion.Open();
                MySqlCommand cmd = new MySqlCommand("delete from equipos where id = '" + id +"'", dbConexion);
                int filasAfectadas = cmd.ExecuteNonQuery();
                if (filasAfectadas > 0) return true;
            }
            catch (Exception e) { MessageBox.Show(e.Message); }

            finally { dbConexion.Close(); }

            return salida;
        }
    }
}
