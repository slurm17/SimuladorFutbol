using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuladorFutbol2
{
    public partial class vLiga : Form
    {
        Liga liga = new Liga();
        DataBaseLiga db = new DataBaseLiga();
        public vLiga()
        {
            InitializeComponent();
            dgv3.DataSource = db.MostrarEquiposLiga();
            UpdateColumnas();
            CargarPosiciones();
            CargarFechaT1(1);
            CargarFechaT2(2);
        }


        private void CargarFechaT1(int f)
        {
            //db = new DataBase();
            dgvPartidosActual.DataSource = db.MostrarPartidosLiga(f);
            dgvPartidosActual.Columns[0].Visible = false;
        }

        private void CargarFechaT2(int f)
        {
            //db = new DataBase();
            dgvPartidosSig.DataSource = db.MostrarPartidosLiga(f);
            dgvPartidosSig.Columns[0].Visible = false;
        }

        private void CargarPosiciones()
        {
            for (int i = 0; i < 6; i++)
            {
                dgv4.Rows.Add();
                dgv4.Rows[i].Cells[0].Value = i + 1;
            }
            dgv4.Columns[0].Width = 20;
            dgv4.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void UpdateColumnas()
        {
            dgv3.Columns[0].Visible = false;
            dgv3.Columns[1].HeaderText = "Equipo";
            dgv3.Columns[2].HeaderText = "Pts";
            dgv3.Columns[3].HeaderText = "PJ";
            dgv3.Columns[4].HeaderText = "PG";
            dgv3.Columns[5].HeaderText = "PE";
            dgv3.Columns[6].HeaderText = "PP";
            dgv3.Columns[7].HeaderText = "DIF";
            for (int i = 2; i < 7; i++)
            {
                dgv3.Columns[i].Width = 25;
                dgv3.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;      
            }
            dgv3.Columns[7].Width = 30;
            dgv3.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv3.Columns[1].Width = 100;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //DataBase db = new DataBase();
            db.BorrarTablaLiga();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //DataBase db = new DataBase();
            db.BorrarTablaFixture();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int fecha = db.MostrarFechaActual();
            //Console.WriteLine("fecha: "+fecha);
            JugarFecha(fecha);
        }

        private void JugarFecha(int n)
        {
            for (int i = 0; i < liga.N/2; i++)
            {
                liga.partidos[n-1, i].Jugar();
                db.GuardarResultado(liga.partidos[n-1, i], n);

                //Console.WriteLine(liga.partidos[n-1,i].eq1.id);
                //Console.WriteLine(liga.partidos[n-1, i].eq2.id);
            }
            //Console.WriteLine();
            CargarFechaT1(n);
            CargarFechaT2(n + 1);
            db.ProximaFecha(n);
            dgv3.DataSource =  db.MostrarEquiposLiga();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            db.FechaUno();
        }
    }
}
