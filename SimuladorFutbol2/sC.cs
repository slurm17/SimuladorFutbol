using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SimuladorFutbol2
{   //OJO CON COPIAR LISTAS ESTATICAS
    //HACEN SIMPRE REFERENCIA A ESTAS
    //COPIAR DATOS MANUALMENTE CON UN FOREACH
    static class sC
    {
        public static List<Equipo> equipos = new List<Equipo>();
        public static Form vContenedora;
        public static Form vActual;
        public static string eqSeleccionado;
        public static string eqVsAmistoso;
        public static Random rdn = new Random();

        public static void CambiarVentana(Form f)
        {
            vActual.Close();
            f.MdiParent = vContenedora;
            f.Show();
            vActual = f;
        }

        public static Equipo GetEquipo(string id)
        {
            return equipos.Find(x => x.id.Contains(id));
        }
        
        public static DataGridViewRow TrerFilaActual(DataGridView  d)
        {
            return d.Rows[d.CurrentRow.Index];
        }

        public static string idSelecc(DataGridView d)
        {
            DataGridViewRow row = d.Rows[d.CurrentRow.Index];
            return row.Cells["id"].Value.ToString();
        }

        public static string nomSelecc(DataGridView d)
        {
            DataGridViewRow row = d.Rows[d.CurrentRow.Index];
            return row.Cells["nombre"].Value.ToString();
        }

        public static void Shuffle(List<Equipo> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rdn.Next(n + 1);
                Equipo value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        
    }
}
