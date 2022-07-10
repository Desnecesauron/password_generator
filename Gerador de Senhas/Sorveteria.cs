using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorveteria
{
    public partial class Sorveteria : Form
    {
        public Sorveteria()
        {
            InitializeComponent();
        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Sorveteria_Load(object sender, EventArgs e)
        {

        }

        private void cliente_Click(object sender, EventArgs e)
        {

        }

        private void nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void calc_Click(object sender, EventArgs e)
        {
            double qtdc, qtdac1, qtdac2, qtdsv, qtdpi, soma;

            qtdc = Convert.ToInt16(qtdcasq.Text); //a
            double a = qtdc * 2.50;
            qtdac1 = Convert.ToInt16(qtdacai1.Text); //b
            double b = qtdac1 * 7.50;
            qtdac2 = Convert.ToInt16(qtdacai2.Text); //c
            double c = qtdac2 * 15.0;
            qtdsv = Convert.ToInt16(qtdsorv.Text); //d
            double d = qtdsv * 10.0;
            qtdpi = Convert.ToInt16(qtdpic.Text); //e
            double w = qtdpi * 2.00;


            soma = a + b + c + d + w;
            total.Text = nome.Text + ", o total da sua compra é:";
            pagar.Text = "R$" + Convert.ToString(soma);


        }

        private void qtdcasq_TextChanged(object sender, EventArgs e)
        {

        }

        private void casquinha_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void qtd_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pagar_Click(object sender, EventArgs e)
        {

        }

        private void pagar_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void limpar_Click(object sender, EventArgs e)
        {
            nome.Clear();
            qtdcasq.Clear();
            qtdacai1.Clear();
            qtdacai2.Clear();
            qtdsorv.Clear();
            qtdpic.Clear();
            total.Text= "Total da Compra:";
            pagar.Text = "R$ 0";

        }
    }
}
