using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerador_de_Senhas
{
    public partial class Antes_gerador : Form
    {
        int mudacar;
        int letra;
        int num;

        public Antes_gerador()
        {
            InitializeComponent();

            Num_caract.Text = "3";
            mudacar = 0;
            letra = 0;
            num = 0;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
                if (mudacar == 0)
                {
                    mudacar = 1;
                }
                else if (mudacar == 1)
                {
                    mudacar = 0;
                }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Num_caract.Text = Convert.ToString(trackBar1.Value);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(letra==0)
            {
                letra = 1;
            }
            else if(letra==1)
            {
                letra = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gerador Other_form = new Gerador(mudacar, letra, num, Num_caract.Text);
            Other_form.Show();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (num == 0)
            {
                num = 1;
            }
            else if (num == 1)
            {
                num = 0;
            }
        }
    }
}
