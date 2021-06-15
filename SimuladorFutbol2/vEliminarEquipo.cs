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
    public partial class vEliminarEquipo : Form
    {
        DataBase db;
        public vEliminarEquipo()
        {
            InitializeComponent();
            db = new DataBase();
            dataGridView1.DataSource = db.MostrarEquipos();
            this.dataGridView1.Columns["id"].Visible = false;
            this.dataGridView1.Columns["nombre"].Width = 150;
        }
    }
}
