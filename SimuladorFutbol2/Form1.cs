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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            RunQuery();
            vPrincipal princi = new vPrincipal();
            sC.vContenedora = this;
            princi.MdiParent = this;
            princi.Show();
            sC.vActual = princi;
        }

        private void RunQuery()
        {
            DataBase bd = new DataBase();
            bd.CargarEquipos();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VAgregarEquipo vAgrEq = new VAgregarEquipo();
            DataBase db = new DataBase();
            if(vAgrEq.ShowDialog()==DialogResult.OK)
            {
                if (vAgrEq.tbxNombre.Text.Equals("") || vAgrEq.tbxId.Text.Equals(""))
                {
                    MessageBox.Show("(*)No puede dejar este campo vacío");
                }
                else
                {
                    Equipo eq = new Equipo();
                    eq.nombre = vAgrEq.tbxNombre.Text;
                    eq.id = vAgrEq.tbxId.Text;
                    sC.equipos.Add(eq);
                    if (db.Insertar(eq.id, eq.nombre))
                        MessageBox.Show("Equipo agregado correctamente!");
                    else
                        MessageBox.Show("Ha ocurrido un error >:/");
                }
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vEliminarEquipo vElimEq = new vEliminarEquipo();
            DataBase db = new DataBase();
            if(vElimEq.ShowDialog() == DialogResult.OK)
            {
                if (db.Eliminar(sC.idSelecc(vElimEq.dataGridView1)))
                {
                    MessageBox.Show(sC.nomSelecc(vElimEq.dataGridView1)+ " ha sido eliminado de la lista de equipos");
                }
                else
                { MessageBox.Show("Ha ocurrido un error >:/"); }
            }
        }
    }
}
