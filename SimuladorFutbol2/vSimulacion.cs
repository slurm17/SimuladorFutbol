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
    public partial class vSimulacion : Form
    {
        public vSimulacion()
        {
            InitializeComponent();
            DataBase db = new DataBase();
            label1.Text = db.VerNombre(sC.eqSeleccionado);
            label2.Text = db.VerNombre(sC.eqVsAmistoso);
            label3.Text = g.Goles().ToString();
            label4.Text = g.Goles().ToString();
        }

        Gol g = new Gol();

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = g.Goles().ToString();
            label4.Text = g.Goles().ToString();
        }
    }
}
