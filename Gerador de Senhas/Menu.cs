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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Antes_gerador Other_form = new Antes_gerador();
            Other_form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Escolha uma foto";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Foto.Load(openFileDialog1.FileName);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Foto.Image = null;
            openFileDialog1.FileName = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            resposta = MessageBox.Show("Você realmente quer sair do programa?",
                "Sorteador de Tele Sena",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Sobre Other_form = new Sobre();
            Other_form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
           Sorveteria.Sorveteria Other_form = new Sorveteria.Sorveteria();
           Other_form.Show();
        }
    }
}
