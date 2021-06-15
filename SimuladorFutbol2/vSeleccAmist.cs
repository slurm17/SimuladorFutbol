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
    public partial class vSeleccAmist : Form
    {
        public vSeleccAmist()
        {
            DataBase db = new DataBase();
            InitializeComponent();
            label1.Text = db.VerNombre(sC.eqSeleccionado);
            

            dataGridView1.DataSource = db.MostrarEquipos();
            this.dataGridView1.Columns["id"].Visible = false;
            this.dataGridView1.Columns["nombre"].Width = 150;
        }

        private void btnInicio_Click_1(object sender, EventArgs e)
        {
            //sC.eqVsAmistoso = listBox1.SelectedIndex;
            sC.eqVsAmistoso = sC.idSelecc(dataGridView1);
            vSimulacion vSimu = new vSimulacion();
            sC.CambiarVentana(vSimu);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //currentRow -> fila actual
            //DataGridViewRow fila = dataGridView1.Rows[dataGridView1.CurrentRow.Index];
            //cells -> celdas
        }
    }
}
