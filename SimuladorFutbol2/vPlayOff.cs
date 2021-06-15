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
    public partial class vPlayOff : Form
    {
        public vPlayOff()
        {
            InitializeComponent();
        }

        int fases = 0;

       

        PlayOff playOff;

        private void vPlayOff_Load(object sender, EventArgs e)
        {
            playOff = new PlayOff();
            txb4to1.Text = playOff.cuartos[0].eq1.nombre;
            txb4to2.Text = playOff.cuartos[0].eq2.nombre;
            txb4to3.Text = playOff.cuartos[1].eq1.nombre;
            txb4to4.Text = playOff.cuartos[1].eq2.nombre;
            txb4to5.Text = playOff.cuartos[2].eq1.nombre;
            txb4to6.Text = playOff.cuartos[2].eq2.nombre;
            txb4to7.Text = playOff.cuartos[3].eq1.nombre;
            txb4to8.Text = playOff.cuartos[3].eq2.nombre;
            txb4to1.BackColor = SystemColors.Window;
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            switch (fases)
            {
                case 0:
                    {
                        playOff.JugarCuartos();
                        //llave 1
                        if (playOff.cuartos[0].ganoE1)
                        {
                            txbSemi1.Text = playOff.cuartos[0].eq1.nombre;
                            txb4to2.Enabled = false;
                        }
                        else
                        {
                            txbSemi1.Text = playOff.cuartos[0].eq2.nombre;
                            txb4to1.Enabled = false;
                        }
                        lbl4to1.Text = playOff.cuartos[0].golStrE1;
                        lbl4to2.Text = playOff.cuartos[0].golStrE2;
                        //llave 2
                        if (playOff.cuartos[1].ganoE1)
                        {
                            txbSemi2.Text = playOff.cuartos[1].eq1.nombre;
                            txb4to4.Enabled = false;
                        }
                        else
                        {
                            txbSemi2.Text = playOff.cuartos[1].eq2.nombre;
                            txb4to3.Enabled = false;
                        }
                        lbl4to3.Text = playOff.cuartos[1].golStrE1;
                        lbl4to4.Text = playOff.cuartos[1].golStrE2;
                        //llave 3
                        if (playOff.cuartos[2].ganoE1)
                        {
                            txbSemi3.Text = playOff.cuartos[2].eq1.nombre;
                            txb4to6.Enabled = false;
                        }
                        else
                        {
                            txbSemi3.Text = playOff.cuartos[2].eq2.nombre;
                            txb4to5.Enabled = false;
                        }
                        lbl4to5.Text = playOff.cuartos[2].golStrE1;
                        lbl4to6.Text = playOff.cuartos[2].golStrE2;
                        //llave 4
                        if (playOff.cuartos[3].ganoE1)
                        {
                            txbSemi4.Text = playOff.cuartos[3].eq1.nombre;
                            txb4to8.Enabled = false;
                        }
                        else
                        {
                            txbSemi4.Text = playOff.cuartos[3].eq2.nombre;
                            txb4to7.Enabled = false;
                        }
                        lbl4to7.Text = playOff.cuartos[3].golStrE1;
                        lbl4to8.Text = playOff.cuartos[3].golStrE2;
                    }
                    break;
                case 1:
                    {
                        playOff.JugarSemis();
                        //llave 1
                        if (playOff.semis[0].ganoE1)
                        {
                            txbFinal1.Text = playOff.semis[0].eq1.nombre;
                            txbSemi2.Enabled = false;
                        }
                        else
                        {
                            txbFinal1.Text = playOff.semis[0].eq2.nombre;
                            txbSemi1.Enabled = false;
                        }
                        lblSemi1.Text = playOff.semis[0].golStrE1;
                        lblSemi2.Text = playOff.semis[0].golStrE2;
                        //llave 2
                        if (playOff.semis[1].ganoE1)
                        {
                            txbFinal2.Text = playOff.semis[1].eq1.nombre;
                            txbSemi4.Enabled = false;
                        }
                        else
                        {
                            txbFinal2.Text = playOff.semis[1].eq2.nombre;
                            txbSemi3.Enabled = false;
                        }
                        lblSemi3.Text = playOff.semis[1].golStrE1;
                        lblSemi4.Text = playOff.semis[1].golStrE2;

                    }
                    break;
                case 2:
                    {
                        playOff.JugarFinal();
                        if (playOff.final.ganoE1)
                        {
                            txbCampeon.Text = playOff.final.eq1.nombre;
                            txbFinal2.Enabled = false;
                        }
                        else
                        {
                            txbCampeon.Text = playOff.final.eq2.nombre;
                            txbFinal1.Enabled = false;
                        }

                        lblFinal.Text = playOff.final.golStrE1 + "-" + playOff.final.golStrE2;
                    }
                    break;
                default:
                    break;
            }
            fases++;

        }
    }
}
