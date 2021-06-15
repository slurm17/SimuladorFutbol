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
    public partial class vSeleccTorneo : Form
    {
        public vSeleccTorneo()
        {
            InitializeComponent();
        }

        private void vSeleccTorneo_Load(object sender, EventArgs e)
        {

        }

        private void vActual_Load(object sender, EventArgs e)
        {

        }

        private void vActual_Load_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            vSeleccAmist vSA = new vSeleccAmist();
            sC.CambiarVentana(vSA);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            vPlayOff vPOff = new vPlayOff();
            sC.CambiarVentana(vPOff);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vLiga vL = new vLiga();
            sC.CambiarVentana(vL);
        }
    }
}
