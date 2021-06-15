using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SimuladorFutbol2
{
    public partial class vPrincipal : Form
    {
       
        public vPrincipal()
        {
            InitializeComponent();
            labEquipo.Text = sC.equipos[0].nombre;
        }

        private int pos = 0;

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            string nom = labEquipo.Text;
            string id = db.VerId(nom);
            sC.eqSeleccionado = id;
            vSeleccTorneo vTorneo = new vSeleccTorneo();
            sC.CambiarVentana(vTorneo);
        }

        private void btnIzq_Click(object sender, EventArgs e)
        {
            pos--;
            if (pos < 0)
                pos = sC.equipos.Count-1;

            labEquipo.Text = sC.equipos[pos].nombre;
        }

        private void btnDer_Click(object sender, EventArgs e)
        {
            pos++;
            if (pos > sC.equipos.Count-1)
                pos = 0;

            labEquipo.Text = sC.equipos[pos].nombre;
        }
    }
}
