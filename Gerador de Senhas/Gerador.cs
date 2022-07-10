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
    public partial class Gerador : Form
    {

        String senhacopy;

        public Gerador(int mudacar, int letra, int num, String Num_caracter)
        {
            InitializeComponent();
            int carac = Convert.ToInt32(Num_caracter);

            Carac1.Visible = false;
            Carac2.Visible = false;
            Carac3.Visible = false;
            Carac4.Visible = false;
            Carac5.Visible = false;
            Carac6.Visible = false;
            Carac7.Visible = false;
            Carac8.Visible = false;
            Carac9.Visible = false;
            Carac10.Visible = false;
            Carac11.Visible = false;
            Carac12.Visible = false;
            Carac13.Visible = false;
            Carac14.Visible = false;
            Carac15.Visible = false;

            int auxiliar = 0;

            Random senha= new Random();

            if (letra == 1 && mudacar == 0 && num == 0)
            {
                if (carac >= 1)
                {
                    auxiliar = senha.Next(1, 26);

                    Carac1.Visible = true;
                    Carac2.Visible = false;
                    Carac3.Visible = false;
                    Carac4.Visible = false;
                    Carac5.Visible = false;
                    Carac6.Visible = false;
                    Carac7.Visible = false;
                    Carac8.Visible = false;
                    Carac9.Visible = false;
                    Carac10.Visible = false;
                    Carac11.Visible = false;
                    Carac12.Visible = false;
                    Carac13.Visible = false;
                    Carac14.Visible = false;
                    Carac15.Visible = false;

                    if (auxiliar == 1)
                    {
                        Carac1.Text = "a";
                    }
                    else if (auxiliar == 2)
                    {
                        Carac1.Text = "b";
                    }
                    else if (auxiliar == 3)
                    {
                        Carac1.Text = "c";
                    }
                    else if (auxiliar == 4)
                    {
                        Carac1.Text = "d";
                    }
                    else if (auxiliar == 5)
                    {
                        Carac1.Text = "e";
                    }
                    else if (auxiliar == 6)
                    {
                        Carac1.Text = "f";
                    }
                    else if (auxiliar == 7)
                    {
                        Carac1.Text = "g";
                    }
                    else if (auxiliar == 8)
                    {
                        Carac1.Text = "h";
                    }
                    else if (auxiliar == 9)
                    {
                        Carac1.Text = "i";
                    }
                    else if (auxiliar == 10)
                    {
                        Carac1.Text = "j";
                    }
                    else if (auxiliar == 11)
                    {
                        Carac1.Text = "k";
                    }
                    else if (auxiliar == 12)
                    {
                        Carac1.Text = "l";
                    }
                    else if (auxiliar == 13)
                    {
                        Carac1.Text = "m";
                    }
                    else if (auxiliar == 14)
                    {
                        Carac1.Text = "n";
                    }
                    else if (auxiliar == 15)
                    {
                        Carac1.Text = "o";
                    }
                    else if (auxiliar == 16)
                    {
                        Carac1.Text = "p";
                    }
                    else if (auxiliar == 17)
                    {
                        Carac1.Text = "q";
                    }
                    else if (auxiliar == 18)
                    {
                        Carac1.Text = "r";
                    }
                    else if (auxiliar == 19)
                    {
                        Carac1.Text = "s";
                    }
                    else if (auxiliar == 20)
                    {
                        Carac1.Text = "t";
                    }
                    else if (auxiliar == 21)
                    {
                        Carac1.Text = "u";
                    }
                    else if (auxiliar == 22)
                    {
                        Carac1.Text = "v";
                    }
                    else if (auxiliar == 23)
                    {
                        Carac1.Text = "w";
                    }
                    else if (auxiliar == 24)
                    {
                        Carac1.Text = "x";
                    }
                    else if (auxiliar == 25)
                    {
                        Carac1.Text = "y";
                    }
                    else if (auxiliar == 26)
                    {
                        Carac1.Text = "z";
                    }
                }
                if (carac >= 2)
                {
                    auxiliar = senha.Next(1, 26);

                    Carac1.Visible = true;
                    Carac2.Visible = true;
                    Carac3.Visible = false;
                    Carac4.Visible = false;
                    Carac5.Visible = false;
                    Carac6.Visible = false;
                    Carac7.Visible = false;
                    Carac8.Visible = false;
                    Carac9.Visible = false;
                    Carac10.Visible = false;
                    Carac11.Visible = false;
                    Carac12.Visible = false;
                    Carac13.Visible = false;
                    Carac14.Visible = false;
                    Carac15.Visible = false;

                    if (auxiliar == 1)
                    {
                        Carac2.Text = "a";
                    }
                    else if (auxiliar == 2)
                    {
                        Carac2.Text = "b";
                    }
                    else if (auxiliar == 3)
                    {
                        Carac2.Text = "c";
                    }
                    else if (auxiliar == 4)
                    {
                        Carac2.Text = "d";
                    }
                    else if (auxiliar == 5)
                    {
                        Carac2.Text = "e";
                    }
                    else if (auxiliar == 6)
                    {
                        Carac2.Text = "f";
                    }
                    else if (auxiliar == 7)
                    {
                        Carac2.Text = "g";
                    }
                    else if (auxiliar == 8)
                    {
                        Carac2.Text = "h";
                    }
                    else if (auxiliar == 9)
                    {
                        Carac2.Text = "i";
                    }
                    else if (auxiliar == 10)
                    {
                        Carac2.Text = "j";
                    }
                    else if (auxiliar == 11)
                    {
                        Carac2.Text = "k";
                    }
                    else if (auxiliar == 12)
                    {
                        Carac2.Text = "l";
                    }
                    else if (auxiliar == 13)
                    {
                        Carac2.Text = "m";
                    }
                    else if (auxiliar == 14)
                    {
                        Carac2.Text = "n";
                    }
                    else if (auxiliar == 15)
                    {
                        Carac2.Text = "o";
                    }
                    else if (auxiliar == 16)
                    {
                        Carac2.Text = "p";
                    }
                    else if (auxiliar == 17)
                    {
                        Carac2.Text = "q";
                    }
                    else if (auxiliar == 18)
                    {
                        Carac2.Text = "r";
                    }
                    else if (auxiliar == 19)
                    {
                        Carac2.Text = "s";
                    }
                    else if (auxiliar == 20)
                    {
                        Carac2.Text = "t";
                    }
                    else if (auxiliar == 21)
                    {
                        Carac2.Text = "u";
                    }
                    else if (auxiliar == 22)
                    {
                        Carac2.Text = "v";
                    }
                    else if (auxiliar == 23)
                    {
                        Carac2.Text = "w";
                    }
                    else if (auxiliar == 24)
                    {
                        Carac2.Text = "x";
                    }
                    else if (auxiliar == 25)
                    {
                        Carac2.Text = "y";
                    }
                    else if (auxiliar == 26)
                    {
                        Carac2.Text = "z";
                    }
                }
                if (carac >= 3)
                {
                    auxiliar = senha.Next(1, 26);

                    Carac1.Visible = true;
                    Carac2.Visible = true;
                    Carac3.Visible = true;
                    Carac4.Visible = false;
                    Carac5.Visible = false;
                    Carac6.Visible = false;
                    Carac7.Visible = false;
                    Carac8.Visible = false;
                    Carac9.Visible = false;
                    Carac10.Visible = false;
                    Carac11.Visible = false;
                    Carac12.Visible = false;
                    Carac13.Visible = false;
                    Carac14.Visible = false;
                    Carac15.Visible = false;

                    if (auxiliar == 1)
                    {
                        Carac3.Text = "a";
                    }
                    else if (auxiliar == 2)
                    {
                        Carac3.Text = "b";
                    }
                    else if (auxiliar == 3)
                    {
                        Carac3.Text = "c";
                    }
                    else if (auxiliar == 4)
                    {
                        Carac3.Text = "d";
                    }
                    else if (auxiliar == 5)
                    {
                        Carac3.Text = "e";
                    }
                    else if (auxiliar == 6)
                    {
                        Carac3.Text = "f";
                    }
                    else if (auxiliar == 7)
                    {
                        Carac3.Text = "g";
                    }
                    else if (auxiliar == 8)
                    {
                        Carac3.Text = "h";
                    }
                    else if (auxiliar == 9)
                    {
                        Carac3.Text = "i";
                    }
                    else if (auxiliar == 10)
                    {
                        Carac3.Text = "j";
                    }
                    else if (auxiliar == 11)
                    {
                        Carac3.Text = "k";
                    }
                    else if (auxiliar == 12)
                    {
                        Carac3.Text = "l";
                    }
                    else if (auxiliar == 13)
                    {
                        Carac3.Text = "m";
                    }
                    else if (auxiliar == 14)
                    {
                        Carac3.Text = "n";
                    }
                    else if (auxiliar == 15)
                    {
                        Carac3.Text = "o";
                    }
                    else if (auxiliar == 16)
                    {
                        Carac3.Text = "p";
                    }
                    else if (auxiliar == 17)
                    {
                        Carac3.Text = "q";
                    }
                    else if (auxiliar == 18)
                    {
                        Carac3.Text = "r";
                    }
                    else if (auxiliar == 19)
                    {
                        Carac3.Text = "s";
                    }
                    else if (auxiliar == 20)
                    {
                        Carac3.Text = "t";
                    }
                    else if (auxiliar == 21)
                    {
                        Carac3.Text = "u";
                    }
                    else if (auxiliar == 22)
                    {
                        Carac3.Text = "v";
                    }
                    else if (auxiliar == 23)
                    {
                        Carac3.Text = "w";
                    }
                    else if (auxiliar == 24)
                    {
                        Carac3.Text = "x";
                    }
                    else if (auxiliar == 25)
                    {
                        Carac3.Text = "y";
                    }
                    else if (auxiliar == 26)
                    {
                        Carac3.Text = "z";
                    }
                }
                if (carac >= 4)
                {
                    auxiliar = senha.Next(1, 26);

                    Carac1.Visible = true;
                    Carac2.Visible = true;
                    Carac3.Visible = true;
                    Carac4.Visible = true;
                    Carac5.Visible = false;
                    Carac6.Visible = false;
                    Carac7.Visible = false;
                    Carac8.Visible = false;
                    Carac9.Visible = false;
                    Carac10.Visible = false;
                    Carac11.Visible = false;
                    Carac12.Visible = false;
                    Carac13.Visible = false;
                    Carac14.Visible = false;
                    Carac15.Visible = false;

                    if (auxiliar == 1)
                    {
                        Carac4.Text = "a";
                    }
                    else if (auxiliar == 2)
                    {
                        Carac4.Text = "b";
                    }
                    else if (auxiliar == 3)
                    {
                        Carac4.Text = "c";
                    }
                    else if (auxiliar == 4)
                    {
                        Carac4.Text = "d";
                    }
                    else if (auxiliar == 5)
                    {
                        Carac4.Text = "e";
                    }
                    else if (auxiliar == 6)
                    {
                        Carac4.Text = "f";
                    }
                    else if (auxiliar == 7)
                    {
                        Carac4.Text = "g";
                    }
                    else if (auxiliar == 8)
                    {
                        Carac4.Text = "h";
                    }
                    else if (auxiliar == 9)
                    {
                        Carac4.Text = "i";
                    }
                    else if (auxiliar == 10)
                    {
                        Carac4.Text = "j";
                    }
                    else if (auxiliar == 11)
                    {
                        Carac4.Text = "k";
                    }
                    else if (auxiliar == 12)
                    {
                        Carac4.Text = "l";
                    }
                    else if (auxiliar == 13)
                    {
                        Carac4.Text = "m";
                    }
                    else if (auxiliar == 14)
                    {
                        Carac4.Text = "n";
                    }
                    else if (auxiliar == 15)
                    {
                        Carac4.Text = "o";
                    }
                    else if (auxiliar == 16)
                    {
                        Carac4.Text = "p";
                    }
                    else if (auxiliar == 17)
                    {
                        Carac4.Text = "q";
                    }
                    else if (auxiliar == 18)
                    {
                        Carac4.Text = "r";
                    }
                    else if (auxiliar == 19)
                    {
                        Carac4.Text = "s";
                    }
                    else if (auxiliar == 20)
                    {
                        Carac4.Text = "t";
                    }
                    else if (auxiliar == 21)
                    {
                        Carac4.Text = "u";
                    }
                    else if (auxiliar == 22)
                    {
                        Carac4.Text = "v";
                    }
                    else if (auxiliar == 23)
                    {
                        Carac4.Text = "w";
                    }
                    else if (auxiliar == 24)
                    {
                        Carac4.Text = "x";
                    }
                    else if (auxiliar == 25)
                    {
                        Carac4.Text = "y";
                    }
                    else if (auxiliar == 26)
                    {
                        Carac4.Text = "z";
                    }
                }
                if (carac >= 5)
                {
                    auxiliar = senha.Next(1, 26);

                    Carac1.Visible = true;
                    Carac2.Visible = true;
                    Carac3.Visible = true;
                    Carac4.Visible = true;
                    Carac5.Visible = true;
                    Carac6.Visible = false;
                    Carac7.Visible = false;
                    Carac8.Visible = false;
                    Carac9.Visible = false;
                    Carac10.Visible = false;
                    Carac11.Visible = false;
                    Carac12.Visible = false;
                    Carac13.Visible = false;
                    Carac14.Visible = false;
                    Carac15.Visible = false;

                    if (auxiliar == 1)
                    {
                        Carac5.Text = "a";
                    }
                    else if (auxiliar == 2)
                    {
                        Carac5.Text = "b";
                    }
                    else if (auxiliar == 3)
                    {
                        Carac5.Text = "c";
                    }
                    else if (auxiliar == 4)
                    {
                        Carac5.Text = "d";
                    }
                    else if (auxiliar == 5)
                    {
                        Carac5.Text = "e";
                    }
                    else if (auxiliar == 6)
                    {
                        Carac5.Text = "f";
                    }
                    else if (auxiliar == 7)
                    {
                        Carac5.Text = "g";
                    }
                    else if (auxiliar == 8)
                    {
                        Carac5.Text = "h";
                    }
                    else if (auxiliar == 9)
                    {
                        Carac5.Text = "i";
                    }
                    else if (auxiliar == 10)
                    {
                        Carac5.Text = "j";
                    }
                    else if (auxiliar == 11)
                    {
                        Carac5.Text = "k";
                    }
                    else if (auxiliar == 12)
                    {
                        Carac5.Text = "l";
                    }
                    else if (auxiliar == 13)
                    {
                        Carac5.Text = "m";
                    }
                    else if (auxiliar == 14)
                    {
                        Carac5.Text = "n";
                    }
                    else if (auxiliar == 15)
                    {
                        Carac5.Text = "o";
                    }
                    else if (auxiliar == 16)
                    {
                        Carac5.Text = "p";
                    }
                    else if (auxiliar == 17)
                    {
                        Carac5.Text = "q";
                    }
                    else if (auxiliar == 18)
                    {
                        Carac5.Text = "r";
                    }
                    else if (auxiliar == 19)
                    {
                        Carac5.Text = "s";
                    }
                    else if (auxiliar == 20)
                    {
                        Carac5.Text = "t";
                    }
                    else if (auxiliar == 21)
                    {
                        Carac5.Text = "u";
                    }
                    else if (auxiliar == 22)
                    {
                        Carac5.Text = "v";
                    }
                    else if (auxiliar == 23)
                    {
                        Carac5.Text = "w";
                    }
                    else if (auxiliar == 24)
                    {
                        Carac5.Text = "x";
                    }
                    else if (auxiliar == 25)
                    {
                        Carac5.Text = "y";
                    }
                    else if (auxiliar == 26)
                    {
                        Carac5.Text = "z";
                    }
                }
                if (carac >= 6)
                {
                    auxiliar = senha.Next(1, 26);

                    Carac1.Visible = true;
                    Carac2.Visible = true;
                    Carac3.Visible = true;
                    Carac4.Visible = true;
                    Carac5.Visible = true;
                    Carac6.Visible = true;
                    Carac7.Visible = false;
                    Carac8.Visible = false;
                    Carac9.Visible = false;
                    Carac10.Visible = false;
                    Carac11.Visible = false;
                    Carac12.Visible = false;
                    Carac13.Visible = false;
                    Carac14.Visible = false;
                    Carac15.Visible = false;

                    if (auxiliar == 1)
                    {
                        Carac6.Text = "a";
                    }
                    else if (auxiliar == 2)
                    {
                        Carac6.Text = "b";
                    }
                    else if (auxiliar == 3)
                    {
                        Carac6.Text = "c";
                    }
                    else if (auxiliar == 4)
                    {
                        Carac6.Text = "d";
                    }
                    else if (auxiliar == 5)
                    {
                        Carac6.Text = "e";
                    }
                    else if (auxiliar == 6)
                    {
                        Carac6.Text = "f";
                    }
                    else if (auxiliar == 7)
                    {
                        Carac6.Text = "g";
                    }
                    else if (auxiliar == 8)
                    {
                        Carac6.Text = "h";
                    }
                    else if (auxiliar == 9)
                    {
                        Carac6.Text = "i";
                    }
                    else if (auxiliar == 10)
                    {
                        Carac6.Text = "j";
                    }
                    else if (auxiliar == 11)
                    {
                        Carac6.Text = "k";
                    }
                    else if (auxiliar == 12)
                    {
                        Carac6.Text = "l";
                    }
                    else if (auxiliar == 13)
                    {
                        Carac6.Text = "m";
                    }
                    else if (auxiliar == 14)
                    {
                        Carac6.Text = "n";
                    }
                    else if (auxiliar == 15)
                    {
                        Carac6.Text = "o";
                    }
                    else if (auxiliar == 16)
                    {
                        Carac6.Text = "p";
                    }
                    else if (auxiliar == 17)
                    {
                        Carac6.Text = "q";
                    }
                    else if (auxiliar == 18)
                    {
                        Carac6.Text = "r";
                    }
                    else if (auxiliar == 19)
                    {
                        Carac6.Text = "s";
                    }
                    else if (auxiliar == 20)
                    {
                        Carac6.Text = "t";
                    }
                    else if (auxiliar == 21)
                    {
                        Carac6.Text = "u";
                    }
                    else if (auxiliar == 22)
                    {
                        Carac6.Text = "v";
                    }
                    else if (auxiliar == 23)
                    {
                        Carac6.Text = "w";
                    }
                    else if (auxiliar == 24)
                    {
                        Carac6.Text = "x";
                    }
                    else if (auxiliar == 25)
                    {
                        Carac6.Text = "y";
                    }
                    else if (auxiliar == 26)
                    {
                        Carac6.Text = "z";
                    }
                }
                if (carac >= 7)
                {
                    auxiliar = senha.Next(1, 26);

                    Carac1.Visible = true;
                    Carac2.Visible = true;
                    Carac3.Visible = true;
                    Carac4.Visible = true;
                    Carac5.Visible = true;
                    Carac6.Visible = true;
                    Carac7.Visible = true;
                    Carac8.Visible = false;
                    Carac9.Visible = false;
                    Carac10.Visible = false;
                    Carac11.Visible = false;
                    Carac12.Visible = false;
                    Carac13.Visible = false;
                    Carac14.Visible = false;
                    Carac15.Visible = false;

                    if (auxiliar == 1)
                    {
                        Carac7.Text = "a";
                    }
                    else if (auxiliar == 2)
                    {
                        Carac7.Text = "b";
                    }
                    else if (auxiliar == 3)
                    {
                        Carac7.Text = "c";
                    }
                    else if (auxiliar == 4)
                    {
                        Carac7.Text = "d";
                    }
                    else if (auxiliar == 5)
                    {
                        Carac7.Text = "e";
                    }
                    else if (auxiliar == 6)
                    {
                        Carac7.Text = "f";
                    }
                    else if (auxiliar == 7)
                    {
                        Carac7.Text = "g";
                    }
                    else if (auxiliar == 8)
                    {
                        Carac7.Text = "h";
                    }
                    else if (auxiliar == 9)
                    {
                        Carac7.Text = "i";
                    }
                    else if (auxiliar == 10)
                    {
                        Carac7.Text = "j";
                    }
                    else if (auxiliar == 11)
                    {
                        Carac7.Text = "k";
                    }
                    else if (auxiliar == 12)
                    {
                        Carac7.Text = "l";
                    }
                    else if (auxiliar == 13)
                    {
                        Carac7.Text = "m";
                    }
                    else if (auxiliar == 14)
                    {
                        Carac7.Text = "n";
                    }
                    else if (auxiliar == 15)
                    {
                        Carac7.Text = "o";
                    }
                    else if (auxiliar == 16)
                    {
                        Carac7.Text = "p";
                    }
                    else if (auxiliar == 17)
                    {
                        Carac7.Text = "q";
                    }
                    else if (auxiliar == 18)
                    {
                        Carac7.Text = "r";
                    }
                    else if (auxiliar == 19)
                    {
                        Carac7.Text = "s";
                    }
                    else if (auxiliar == 20)
                    {
                        Carac7.Text = "t";
                    }
                    else if (auxiliar == 21)
                    {
                        Carac7.Text = "u";
                    }
                    else if (auxiliar == 22)
                    {
                        Carac7.Text = "v";
                    }
                    else if (auxiliar == 23)
                    {
                        Carac7.Text = "w";
                    }
                    else if (auxiliar == 24)
                    {
                        Carac7.Text = "x";
                    }
                    else if (auxiliar == 25)
                    {
                        Carac7.Text = "y";
                    }
                    else if (auxiliar == 26)
                    {
                        Carac7.Text = "z";
                    }
                }
                if (carac >= 8)
                {
                    auxiliar = senha.Next(1, 26);

                    Carac1.Visible = true;
                    Carac2.Visible = true;
                    Carac3.Visible = true;
                    Carac4.Visible = true;
                    Carac5.Visible = true;
                    Carac6.Visible = true;
                    Carac7.Visible = true;
                    Carac8.Visible = true;
                    Carac9.Visible = false;
                    Carac10.Visible = false;
                    Carac11.Visible = false;
                    Carac12.Visible = false;
                    Carac13.Visible = false;
                    Carac14.Visible = false;
                    Carac15.Visible = false;

                    if (auxiliar == 1)
                    {
                        Carac8.Text = "a";
                    }
                    else if (auxiliar == 2)
                    {
                        Carac8.Text = "b";
                    }
                    else if (auxiliar == 3)
                    {
                        Carac8.Text = "c";
                    }
                    else if (auxiliar == 4)
                    {
                        Carac8.Text = "d";
                    }
                    else if (auxiliar == 5)
                    {
                        Carac8.Text = "e";
                    }
                    else if (auxiliar == 6)
                    {
                        Carac8.Text = "f";
                    }
                    else if (auxiliar == 7)
                    {
                        Carac8.Text = "g";
                    }
                    else if (auxiliar == 8)
                    {
                        Carac8.Text = "h";
                    }
                    else if (auxiliar == 9)
                    {
                        Carac8.Text = "i";
                    }
                    else if (auxiliar == 10)
                    {
                        Carac8.Text = "j";
                    }
                    else if (auxiliar == 11)
                    {
                        Carac8.Text = "k";
                    }
                    else if (auxiliar == 12)
                    {
                        Carac8.Text = "l";
                    }
                    else if (auxiliar == 13)
                    {
                        Carac8.Text = "m";
                    }
                    else if (auxiliar == 14)
                    {
                        Carac8.Text = "n";
                    }
                    else if (auxiliar == 15)
                    {
                        Carac8.Text = "o";
                    }
                    else if (auxiliar == 16)
                    {
                        Carac8.Text = "p";
                    }
                    else if (auxiliar == 17)
                    {
                        Carac8.Text = "q";
                    }
                    else if (auxiliar == 18)
                    {
                        Carac8.Text = "r";
                    }
                    else if (auxiliar == 19)
                    {
                        Carac8.Text = "s";
                    }
                    else if (auxiliar == 20)
                    {
                        Carac8.Text = "t";
                    }
                    else if (auxiliar == 21)
                    {
                        Carac8.Text = "u";
                    }
                    else if (auxiliar == 22)
                    {
                        Carac8.Text = "v";
                    }
                    else if (auxiliar == 23)
                    {
                        Carac8.Text = "w";
                    }
                    else if (auxiliar == 24)
                    {
                        Carac8.Text = "x";
                    }
                    else if (auxiliar == 25)
                    {
                        Carac8.Text = "y";
                    }
                    else if (auxiliar == 26)
                    {
                        Carac8.Text = "z";
                    }
                }
                if (carac >= 9)
                {
                    auxiliar = senha.Next(1, 26);

                    Carac1.Visible = true;
                    Carac2.Visible = true;
                    Carac3.Visible = true;
                    Carac4.Visible = true;
                    Carac5.Visible = true;
                    Carac6.Visible = true;
                    Carac7.Visible = true;
                    Carac8.Visible = true;
                    Carac9.Visible = true;
                    Carac10.Visible = false;
                    Carac11.Visible = false;
                    Carac12.Visible = false;
                    Carac13.Visible = false;
                    Carac14.Visible = false;
                    Carac15.Visible = false;

                    if (auxiliar == 1)
                    {
                        Carac9.Text = "a";
                    }
                    else if (auxiliar == 2)
                    {
                        Carac9.Text = "b";
                    }
                    else if (auxiliar == 3)
                    {
                        Carac9.Text = "c";
                    }
                    else if (auxiliar == 4)
                    {
                        Carac9.Text = "d";
                    }
                    else if (auxiliar == 5)
                    {
                        Carac9.Text = "e";
                    }
                    else if (auxiliar == 6)
                    {
                        Carac9.Text = "f";
                    }
                    else if (auxiliar == 7)
                    {
                        Carac9.Text = "g";
                    }
                    else if (auxiliar == 8)
                    {
                        Carac9.Text = "h";
                    }
                    else if (auxiliar == 9)
                    {
                        Carac9.Text = "i";
                    }
                    else if (auxiliar == 10)
                    {
                        Carac9.Text = "j";
                    }
                    else if (auxiliar == 11)
                    {
                        Carac9.Text = "k";
                    }
                    else if (auxiliar == 12)
                    {
                        Carac9.Text = "l";
                    }
                    else if (auxiliar == 13)
                    {
                        Carac9.Text = "m";
                    }
                    else if (auxiliar == 14)
                    {
                        Carac9.Text = "n";
                    }
                    else if (auxiliar == 15)
                    {
                        Carac9.Text = "o";
                    }
                    else if (auxiliar == 16)
                    {
                        Carac9.Text = "p";
                    }
                    else if (auxiliar == 17)
                    {
                        Carac9.Text = "q";
                    }
                    else if (auxiliar == 18)
                    {
                        Carac9.Text = "r";
                    }
                    else if (auxiliar == 19)
                    {
                        Carac9.Text = "s";
                    }
                    else if (auxiliar == 20)
                    {
                        Carac9.Text = "t";
                    }
                    else if (auxiliar == 21)
                    {
                        Carac9.Text = "u";
                    }
                    else if (auxiliar == 22)
                    {
                        Carac9.Text = "v";
                    }
                    else if (auxiliar == 23)
                    {
                        Carac9.Text = "w";
                    }
                    else if (auxiliar == 24)
                    {
                        Carac9.Text = "x";
                    }
                    else if (auxiliar == 25)
                    {
                        Carac9.Text = "y";
                    }
                    else if (auxiliar == 26)
                    {
                        Carac9.Text = "z";
                    }
                }
                if (carac >= 10)
                {
                    auxiliar = senha.Next(1, 26);

                    Carac1.Visible = true;
                    Carac2.Visible = true;
                    Carac3.Visible = true;
                    Carac4.Visible = true;
                    Carac5.Visible = true;
                    Carac6.Visible = true;
                    Carac7.Visible = true;
                    Carac8.Visible = true;
                    Carac9.Visible = true;
                    Carac10.Visible = true;
                    Carac11.Visible = false;
                    Carac12.Visible = false;
                    Carac13.Visible = false;
                    Carac14.Visible = false;
                    Carac15.Visible = false;

                    if (auxiliar == 1)
                    {
                        Carac10.Text = "a";
                    }
                    else if (auxiliar == 2)
                    {
                        Carac10.Text = "b";
                    }
                    else if (auxiliar == 3)
                    {
                        Carac10.Text = "c";
                    }
                    else if (auxiliar == 4)
                    {
                        Carac10.Text = "d";
                    }
                    else if (auxiliar == 5)
                    {
                        Carac10.Text = "e";
                    }
                    else if (auxiliar == 6)
                    {
                        Carac10.Text = "f";
                    }
                    else if (auxiliar == 7)
                    {
                        Carac10.Text = "g";
                    }
                    else if (auxiliar == 8)
                    {
                        Carac10.Text = "h";
                    }
                    else if (auxiliar == 9)
                    {
                        Carac10.Text = "i";
                    }
                    else if (auxiliar == 10)
                    {
                        Carac10.Text = "j";
                    }
                    else if (auxiliar == 11)
                    {
                        Carac10.Text = "k";
                    }
                    else if (auxiliar == 12)
                    {
                        Carac10.Text = "l";
                    }
                    else if (auxiliar == 13)
                    {
                        Carac10.Text = "m";
                    }
                    else if (auxiliar == 14)
                    {
                        Carac10.Text = "n";
                    }
                    else if (auxiliar == 15)
                    {
                        Carac10.Text = "o";
                    }
                    else if (auxiliar == 16)
                    {
                        Carac10.Text = "p";
                    }
                    else if (auxiliar == 17)
                    {
                        Carac10.Text = "q";
                    }
                    else if (auxiliar == 18)
                    {
                        Carac10.Text = "r";
                    }
                    else if (auxiliar == 19)
                    {
                        Carac10.Text = "s";
                    }
                    else if (auxiliar == 20)
                    {
                        Carac10.Text = "t";
                    }
                    else if (auxiliar == 21)
                    {
                        Carac10.Text = "u";
                    }
                    else if (auxiliar == 22)
                    {
                        Carac10.Text = "v";
                    }
                    else if (auxiliar == 23)
                    {
                        Carac10.Text = "w";
                    }
                    else if (auxiliar == 24)
                    {
                        Carac10.Text = "x";
                    }
                    else if (auxiliar == 25)
                    {
                        Carac10.Text = "y";
                    }
                    else if (auxiliar == 26)
                    {
                        Carac10.Text = "z";
                    }
                }
                if (carac >= 11)
                {
                    auxiliar = senha.Next(1, 26);

                    Carac1.Visible = true;
                    Carac2.Visible = true;
                    Carac3.Visible = true;
                    Carac4.Visible = true;
                    Carac5.Visible = true;
                    Carac6.Visible = true;
                    Carac7.Visible = true;
                    Carac8.Visible = true;
                    Carac9.Visible = true;
                    Carac10.Visible = true;
                    Carac11.Visible = true;
                    Carac12.Visible = false;
                    Carac13.Visible = false;
                    Carac14.Visible = false;
                    Carac15.Visible = false;

                    if (auxiliar == 1)
                    {
                        Carac11.Text = "a";
                    }
                    else if (auxiliar == 2)
                    {
                        Carac11.Text = "b";
                    }
                    else if (auxiliar == 3)
                    {
                        Carac11.Text = "c";
                    }
                    else if (auxiliar == 4)
                    {
                        Carac11.Text = "d";
                    }
                    else if (auxiliar == 5)
                    {
                        Carac11.Text = "e";
                    }
                    else if (auxiliar == 6)
                    {
                        Carac11.Text = "f";
                    }
                    else if (auxiliar == 7)
                    {
                        Carac11.Text = "g";
                    }
                    else if (auxiliar == 8)
                    {
                        Carac11.Text = "h";
                    }
                    else if (auxiliar == 9)
                    {
                        Carac11.Text = "i";
                    }
                    else if (auxiliar == 10)
                    {
                        Carac11.Text = "j";
                    }
                    else if (auxiliar == 11)
                    {
                        Carac11.Text = "k";
                    }
                    else if (auxiliar == 12)
                    {
                        Carac11.Text = "l";
                    }
                    else if (auxiliar == 13)
                    {
                        Carac11.Text = "m";
                    }
                    else if (auxiliar == 14)
                    {
                        Carac11.Text = "n";
                    }
                    else if (auxiliar == 15)
                    {
                        Carac11.Text = "o";
                    }
                    else if (auxiliar == 16)
                    {
                        Carac11.Text = "p";
                    }
                    else if (auxiliar == 17)
                    {
                        Carac11.Text = "q";
                    }
                    else if (auxiliar == 18)
                    {
                        Carac11.Text = "r";
                    }
                    else if (auxiliar == 19)
                    {
                        Carac11.Text = "s";
                    }
                    else if (auxiliar == 20)
                    {
                        Carac11.Text = "t";
                    }
                    else if (auxiliar == 21)
                    {
                        Carac11.Text = "u";
                    }
                    else if (auxiliar == 22)
                    {
                        Carac11.Text = "v";
                    }
                    else if (auxiliar == 23)
                    {
                        Carac11.Text = "w";
                    }
                    else if (auxiliar == 24)
                    {
                        Carac11.Text = "x";
                    }
                    else if (auxiliar == 25)
                    {
                        Carac11.Text = "y";
                    }
                    else if (auxiliar == 26)
                    {
                        Carac11.Text = "z";
                    }
                }
                if (carac >= 12)
                {
                    auxiliar = senha.Next(1, 26);

                    Carac1.Visible = true;
                    Carac2.Visible = true;
                    Carac3.Visible = true;
                    Carac4.Visible = true;
                    Carac5.Visible = true;
                    Carac6.Visible = true;
                    Carac7.Visible = true;
                    Carac8.Visible = true;
                    Carac9.Visible = true;
                    Carac10.Visible = true;
                    Carac11.Visible = true;
                    Carac12.Visible = true;
                    Carac13.Visible = false;
                    Carac14.Visible = false;
                    Carac15.Visible = false;

                    if (auxiliar == 1)
                    {
                        Carac12.Text = "a";
                    }
                    else if (auxiliar == 2)
                    {
                        Carac12.Text = "b";
                    }
                    else if (auxiliar == 3)
                    {
                        Carac12.Text = "c";
                    }
                    else if (auxiliar == 4)
                    {
                        Carac12.Text = "d";
                    }
                    else if (auxiliar == 5)
                    {
                        Carac12.Text = "e";
                    }
                    else if (auxiliar == 6)
                    {
                        Carac12.Text = "f";
                    }
                    else if (auxiliar == 7)
                    {
                        Carac12.Text = "g";
                    }
                    else if (auxiliar == 8)
                    {
                        Carac12.Text = "h";
                    }
                    else if (auxiliar == 9)
                    {
                        Carac12.Text = "i";
                    }
                    else if (auxiliar == 10)
                    {
                        Carac12.Text = "j";
                    }
                    else if (auxiliar == 11)
                    {
                        Carac12.Text = "k";
                    }
                    else if (auxiliar == 12)
                    {
                        Carac12.Text = "l";
                    }
                    else if (auxiliar == 13)
                    {
                        Carac12.Text = "m";
                    }
                    else if (auxiliar == 14)
                    {
                        Carac12.Text = "n";
                    }
                    else if (auxiliar == 15)
                    {
                        Carac12.Text = "o";
                    }
                    else if (auxiliar == 16)
                    {
                        Carac12.Text = "p";
                    }
                    else if (auxiliar == 17)
                    {
                        Carac12.Text = "q";
                    }
                    else if (auxiliar == 18)
                    {
                        Carac12.Text = "r";
                    }
                    else if (auxiliar == 19)
                    {
                        Carac12.Text = "s";
                    }
                    else if (auxiliar == 20)
                    {
                        Carac12.Text = "t";
                    }
                    else if (auxiliar == 21)
                    {
                        Carac12.Text = "u";
                    }
                    else if (auxiliar == 22)
                    {
                        Carac12.Text = "v";
                    }
                    else if (auxiliar == 23)
                    {
                        Carac12.Text = "w";
                    }
                    else if (auxiliar == 24)
                    {
                        Carac12.Text = "x";
                    }
                    else if (auxiliar == 25)
                    {
                        Carac12.Text = "y";
                    }
                    else if (auxiliar == 26)
                    {
                        Carac12.Text = "z";
                    }
                }
                if (carac >= 13)
                {
                    auxiliar = senha.Next(1, 26);

                    Carac1.Visible = true;
                    Carac2.Visible = true;
                    Carac3.Visible = true;
                    Carac4.Visible = true;
                    Carac5.Visible = true;
                    Carac6.Visible = true;
                    Carac7.Visible = true;
                    Carac8.Visible = true;
                    Carac9.Visible = true;
                    Carac10.Visible = true;
                    Carac11.Visible = true;
                    Carac12.Visible = true;
                    Carac13.Visible = true;
                    Carac14.Visible = false;
                    Carac15.Visible = false;

                    if (auxiliar == 1)
                    {
                        Carac13.Text = "a";
                    }
                    else if (auxiliar == 2)
                    {
                        Carac13.Text = "b";
                    }
                    else if (auxiliar == 3)
                    {
                        Carac13.Text = "c";
                    }
                    else if (auxiliar == 4)
                    {
                        Carac13.Text = "d";
                    }
                    else if (auxiliar == 5)
                    {
                        Carac13.Text = "e";
                    }
                    else if (auxiliar == 6)
                    {
                        Carac13.Text = "f";
                    }
                    else if (auxiliar == 7)
                    {
                        Carac13.Text = "g";
                    }
                    else if (auxiliar == 8)
                    {
                        Carac13.Text = "h";
                    }
                    else if (auxiliar == 9)
                    {
                        Carac13.Text = "i";
                    }
                    else if (auxiliar == 10)
                    {
                        Carac13.Text = "j";
                    }
                    else if (auxiliar == 11)
                    {
                        Carac13.Text = "k";
                    }
                    else if (auxiliar == 12)
                    {
                        Carac13.Text = "l";
                    }
                    else if (auxiliar == 13)
                    {
                        Carac13.Text = "m";
                    }
                    else if (auxiliar == 14)
                    {
                        Carac13.Text = "n";
                    }
                    else if (auxiliar == 15)
                    {
                        Carac13.Text = "o";
                    }
                    else if (auxiliar == 16)
                    {
                        Carac13.Text = "p";
                    }
                    else if (auxiliar == 17)
                    {
                        Carac13.Text = "q";
                    }
                    else if (auxiliar == 18)
                    {
                        Carac13.Text = "r";
                    }
                    else if (auxiliar == 19)
                    {
                        Carac13.Text = "s";
                    }
                    else if (auxiliar == 20)
                    {
                        Carac13.Text = "t";
                    }
                    else if (auxiliar == 21)
                    {
                        Carac13.Text = "u";
                    }
                    else if (auxiliar == 22)
                    {
                        Carac13.Text = "v";
                    }
                    else if (auxiliar == 23)
                    {
                        Carac13.Text = "w";
                    }
                    else if (auxiliar == 24)
                    {
                        Carac13.Text = "x";
                    }
                    else if (auxiliar == 25)
                    {
                        Carac13.Text = "y";
                    }
                    else if (auxiliar == 26)
                    {
                        Carac13.Text = "z";
                    }
                }
                if (carac >= 14)
                {
                    auxiliar = senha.Next(1, 26);

                    Carac1.Visible = true;
                    Carac2.Visible = true;
                    Carac3.Visible = true;
                    Carac4.Visible = true;
                    Carac5.Visible = true;
                    Carac6.Visible = true;
                    Carac7.Visible = true;
                    Carac8.Visible = true;
                    Carac9.Visible = true;
                    Carac10.Visible = true;
                    Carac11.Visible = true;
                    Carac12.Visible = true;
                    Carac13.Visible = true;
                    Carac14.Visible = true;
                    Carac15.Visible = false;

                    if (auxiliar == 1)
                    {
                        Carac14.Text = "a";
                    }
                    else if (auxiliar == 2)
                    {
                        Carac14.Text = "b";
                    }
                    else if (auxiliar == 3)
                    {
                        Carac14.Text = "c";
                    }
                    else if (auxiliar == 4)
                    {
                        Carac14.Text = "d";
                    }
                    else if (auxiliar == 5)
                    {
                        Carac14.Text = "e";
                    }
                    else if (auxiliar == 6)
                    {
                        Carac14.Text = "f";
                    }
                    else if (auxiliar == 7)
                    {
                        Carac14.Text = "g";
                    }
                    else if (auxiliar == 8)
                    {
                        Carac14.Text = "h";
                    }
                    else if (auxiliar == 9)
                    {
                        Carac14.Text = "i";
                    }
                    else if (auxiliar == 10)
                    {
                        Carac14.Text = "j";
                    }
                    else if (auxiliar == 11)
                    {
                        Carac14.Text = "k";
                    }
                    else if (auxiliar == 12)
                    {
                        Carac14.Text = "l";
                    }
                    else if (auxiliar == 13)
                    {
                        Carac14.Text = "m";
                    }
                    else if (auxiliar == 14)
                    {
                        Carac14.Text = "n";
                    }
                    else if (auxiliar == 15)
                    {
                        Carac14.Text = "o";
                    }
                    else if (auxiliar == 16)
                    {
                        Carac14.Text = "p";
                    }
                    else if (auxiliar == 17)
                    {
                        Carac14.Text = "q";
                    }
                    else if (auxiliar == 18)
                    {
                        Carac14.Text = "r";
                    }
                    else if (auxiliar == 19)
                    {
                        Carac14.Text = "s";
                    }
                    else if (auxiliar == 20)
                    {
                        Carac14.Text = "t";
                    }
                    else if (auxiliar == 21)
                    {
                        Carac14.Text = "u";
                    }
                    else if (auxiliar == 22)
                    {
                        Carac14.Text = "v";
                    }
                    else if (auxiliar == 23)
                    {
                        Carac14.Text = "w";
                    }
                    else if (auxiliar == 24)
                    {
                        Carac14.Text = "x";
                    }
                    else if (auxiliar == 25)
                    {
                        Carac14.Text = "y";
                    }
                    else if (auxiliar == 26)
                    {
                        Carac14.Text = "z";
                    }
                }
                if (carac >= 15)
                {
                    auxiliar = senha.Next(1, 26);

                    Carac1.Visible = true;
                    Carac2.Visible = true;
                    Carac3.Visible = true;
                    Carac4.Visible = true;
                    Carac5.Visible = true;
                    Carac6.Visible = true;
                    Carac7.Visible = true;
                    Carac8.Visible = true;
                    Carac9.Visible = true;
                    Carac10.Visible = true;
                    Carac11.Visible = true;
                    Carac12.Visible = true;
                    Carac13.Visible = true;
                    Carac14.Visible = true;
                    Carac15.Visible = true;

                    if (auxiliar == 1)
                    {
                        Carac15.Text = "a";
                    }
                    else if (auxiliar == 2)
                    {
                        Carac15.Text = "b";
                    }
                    else if (auxiliar == 3)
                    {
                        Carac15.Text = "c";
                    }
                    else if (auxiliar == 4)
                    {
                        Carac15.Text = "d";
                    }
                    else if (auxiliar == 5)
                    {
                        Carac15.Text = "e";
                    }
                    else if (auxiliar == 6)
                    {
                        Carac15.Text = "f";
                    }
                    else if (auxiliar == 7)
                    {
                        Carac15.Text = "g";
                    }
                    else if (auxiliar == 8)
                    {
                        Carac15.Text = "h";
                    }
                    else if (auxiliar == 9)
                    {
                        Carac15.Text = "i";
                    }
                    else if (auxiliar == 10)
                    {
                        Carac15.Text = "j";
                    }
                    else if (auxiliar == 11)
                    {
                        Carac15.Text = "k";
                    }
                    else if (auxiliar == 12)
                    {
                        Carac15.Text = "l";
                    }
                    else if (auxiliar == 13)
                    {
                        Carac15.Text = "m";
                    }
                    else if (auxiliar == 14)
                    {
                        Carac15.Text = "n";
                    }
                    else if (auxiliar == 15)
                    {
                        Carac15.Text = "o";
                    }
                    else if (auxiliar == 16)
                    {
                        Carac15.Text = "p";
                    }
                    else if (auxiliar == 17)
                    {
                        Carac15.Text = "q";
                    }
                    else if (auxiliar == 18)
                    {
                        Carac15.Text = "r";
                    }
                    else if (auxiliar == 19)
                    {
                        Carac15.Text = "s";
                    }
                    else if (auxiliar == 20)
                    {
                        Carac15.Text = "t";
                    }
                    else if (auxiliar == 21)
                    {
                        Carac15.Text = "u";
                    }
                    else if (auxiliar == 22)
                    {
                        Carac15.Text = "v";
                    }
                    else if (auxiliar == 23)
                    {
                        Carac15.Text = "w";
                    }
                    else if (auxiliar == 24)
                    {
                        Carac15.Text = "x";
                    }
                    else if (auxiliar == 25)
                    {
                        Carac15.Text = "y";
                    }
                    else if (auxiliar == 26)
                    {
                        Carac15.Text = "z";
                    }
                }
                //26
            }

            else if (letra == 1 && mudacar == 1 && num == 0)
            {
                if (carac >= 1)
                {
                    auxiliar = senha.Next(1, 52);

                    Carac1.Visible = true;
                    Carac2.Visible = false;
                    Carac3.Visible = false;
                    Carac4.Visible = false;
                    Carac5.Visible = false;
                    Carac6.Visible = false;
                    Carac7.Visible = false;
                    Carac8.Visible = false;
                    Carac9.Visible = false;
                    Carac10.Visible = false;
                    Carac11.Visible = false;
                    Carac12.Visible = false;
                    Carac13.Visible = false;
                    Carac14.Visible = false;
                    Carac15.Visible = false;

                    if (auxiliar == 1)
                    {
                        Carac1.Text = "a";
                    }
                    else if (auxiliar == 2)
                    {
                        Carac1.Text = "b";
                    }
                    else if (auxiliar == 3)
                    {
                        Carac1.Text = "c";
                    }
                    else if (auxiliar == 4)
                    {
                        Carac1.Text = "d";
                    }
                    else if (auxiliar == 5)
                    {
                        Carac1.Text = "e";
                    }
                    else if (auxiliar == 6)
                    {
                        Carac1.Text = "f";
                    }
                    else if (auxiliar == 7)
                    {
                        Carac1.Text = "g";
                    }
                    else if (auxiliar == 8)
                    {
                        Carac1.Text = "h";
                    }
                    else if (auxiliar == 9)
                    {
                        Carac1.Text = "i";
                    }
                    else if (auxiliar == 10)
                    {
                        Carac1.Text = "j";
                    }
                    else if (auxiliar == 11)
                    {
                        Carac1.Text = "k";
                    }
                    else if (auxiliar == 12)
                    {
                        Carac1.Text = "l";
                    }
                    else if (auxiliar == 13)
                    {
                        Carac1.Text = "m";
                    }
                    else if (auxiliar == 14)
                    {
                        Carac1.Text = "n";
                    }
                    else if (auxiliar == 15)
                    {
                        Carac1.Text = "o";
                    }
                    else if (auxiliar == 16)
                    {
                        Carac1.Text = "p";
                    }
                    else if (auxiliar == 17)
                    {
                        Carac1.Text = "q";
                    }
                    else if (auxiliar == 18)
                    {
                        Carac1.Text = "r";
                    }
                    else if (auxiliar == 19)
                    {
                        Carac1.Text = "s";
                    }
                    else if (auxiliar == 20)
                    {
                        Carac1.Text = "t";
                    }
                    else if (auxiliar == 21)
                    {
                        Carac1.Text = "u";
                    }
                    else if (auxiliar == 22)
                    {
                        Carac1.Text = "v";
                    }
                    else if (auxiliar == 23)
                    {
                        Carac1.Text = "w";
                    }
                    else if (auxiliar == 24)
                    {
                        Carac1.Text = "x";
                    }
                    else if (auxiliar == 25)
                    {
                        Carac1.Text = "y";
                    }
                    else if (auxiliar == 26)
                    {
                        Carac1.Text = "z";
                    }
                    else if (auxiliar == 27)
                    {
                        Carac1.Text = "A";
                    }
                    else if (auxiliar == 28)
                    {
                        Carac1.Text = "B";
                    }
                    else if (auxiliar == 29)
                    {
                        Carac1.Text = "C";
                    }
                    else if (auxiliar == 30)
                    {
                        Carac1.Text = "D";
                    }
                    else if (auxiliar == 31)
                    {
                        Carac1.Text = "E";
                    }
                    else if (auxiliar == 32)
                    {
                        Carac1.Text = "F";
                    }
                    else if (auxiliar == 33)
                    {
                        Carac1.Text = "G";
                    }
                    else if (auxiliar == 34)
                    {
                        Carac1.Text = "H";
                    }
                    else if (auxiliar == 35)
                    {
                        Carac1.Text = "I";
                    }
                    else if (auxiliar == 36)
                    {
                        Carac1.Text = "J";
                    }
                    else if (auxiliar == 37)
                    {
                        Carac1.Text = "K";
                    }
                    else if (auxiliar == 38)
                    {
                        Carac1.Text = "L";
                    }
                    else if (auxiliar == 39)
                    {
                        Carac1.Text = "M";
                    }
                    else if (auxiliar == 40)
                    {
                        Carac1.Text = "N";
                    }
                    else if (auxiliar == 41)
                    {
                        Carac1.Text = "O";
                    }
                    else if (auxiliar == 42)
                    {
                        Carac1.Text = "P";
                    }
                    else if (auxiliar == 43)
                    {
                        Carac1.Text = "Q";
                    }
                    else if (auxiliar == 44)
                    {
                        Carac1.Text = "R";
                    }
                    else if (auxiliar == 45)
                    {
                        Carac1.Text = "S";
                    }
                    else if (auxiliar == 46)
                    {
                        Carac1.Text = "T";
                    }
                    else if (auxiliar == 47)
                    {
                        Carac1.Text = "U";
                    }
                    else if (auxiliar == 48)
                    {
                        Carac1.Text = "V";
                    }
                    else if (auxiliar == 49)
                    {
                        Carac1.Text = "W";
                    }
                    else if (auxiliar == 50)
                    {
                        Carac1.Text = "X";
                    }
                    else if (auxiliar == 51)
                    {
                        Carac1.Text = "Y";
                    }
                    else if (auxiliar == 52)
                    {
                        Carac1.Text = "Z";
                    }
                }
                if (carac >= 2)
                {
                    auxiliar = senha.Next(1, 52);

                    Carac1.Visible = true;
                    Carac2.Visible = true;
                    Carac3.Visible = false;
                    Carac4.Visible = false;
                    Carac5.Visible = false;
                    Carac6.Visible = false;
                    Carac7.Visible = false;
                    Carac8.Visible = false;
                    Carac9.Visible = false;
                    Carac10.Visible = false;
                    Carac11.Visible = false;
                    Carac12.Visible = false;
                    Carac13.Visible = false;
                    Carac14.Visible = false;
                    Carac15.Visible = false;

                    if (auxiliar == 1)
                    {
                        Carac2.Text = "a";
                    }
                    else if (auxiliar == 2)
                    {
                        Carac2.Text = "b";
                    }
                    else if (auxiliar == 3)
                    {
                        Carac2.Text = "c";
                    }
                    else if (auxiliar == 4)
                    {
                        Carac2.Text = "d";
                    }
                    else if (auxiliar == 5)
                    {
                        Carac2.Text = "e";
                    }
                    else if (auxiliar == 6)
                    {
                        Carac2.Text = "f";
                    }
                    else if (auxiliar == 7)
                    {
                        Carac2.Text = "g";
                    }
                    else if (auxiliar == 8)
                    {
                        Carac2.Text = "h";
                    }
                    else if (auxiliar == 9)
                    {
                        Carac2.Text = "i";
                    }
                    else if (auxiliar == 10)
                    {
                        Carac2.Text = "j";
                    }
                    else if (auxiliar == 11)
                    {
                        Carac2.Text = "k";
                    }
                    else if (auxiliar == 12)
                    {
                        Carac2.Text = "l";
                    }
                    else if (auxiliar == 13)
                    {
                        Carac2.Text = "m";
                    }
                    else if (auxiliar == 14)
                    {
                        Carac2.Text = "n";
                    }
                    else if (auxiliar == 15)
                    {
                        Carac2.Text = "o";
                    }
                    else if (auxiliar == 16)
                    {
                        Carac2.Text = "p";
                    }
                    else if (auxiliar == 17)
                    {
                        Carac2.Text = "q";
                    }
                    else if (auxiliar == 18)
                    {
                        Carac2.Text = "r";
                    }
                    else if (auxiliar == 19)
                    {
                        Carac2.Text = "s";
                    }
                    else if (auxiliar == 20)
                    {
                        Carac2.Text = "t";
                    }
                    else if (auxiliar == 21)
                    {
                        Carac2.Text = "u";
                    }
                    else if (auxiliar == 22)
                    {
                        Carac2.Text = "v";
                    }
                    else if (auxiliar == 23)
                    {
                        Carac2.Text = "w";
                    }
                    else if (auxiliar == 24)
                    {
                        Carac2.Text = "x";
                    }
                    else if (auxiliar == 25)
                    {
                        Carac2.Text = "y";
                    }
                    else if (auxiliar == 26)
                    {
                        Carac2.Text = "z";
                    }
                    else if (auxiliar == 27)
                    {
                        Carac2.Text = "A";
                    }
                    else if (auxiliar == 28)
                    {
                        Carac2.Text = "B";
                    }
                    else if (auxiliar == 29)
                    {
                        Carac2.Text = "C";
                    }
                    else if (auxiliar == 30)
                    {
                        Carac2.Text = "D";
                    }
                    else if (auxiliar == 31)
                    {
                        Carac2.Text = "E";
                    }
                    else if (auxiliar == 32)
                    {
                        Carac2.Text = "F";
                    }
                    else if (auxiliar == 33)
                    {
                        Carac2.Text = "G";
                    }
                    else if (auxiliar == 34)
                    {
                        Carac2.Text = "H";
                    }
                    else if (auxiliar == 35)
                    {
                        Carac2.Text = "I";
                    }
                    else if (auxiliar == 36)
                    {
                        Carac2.Text = "J";
                    }
                    else if (auxiliar == 37)
                    {
                        Carac2.Text = "K";
                    }
                    else if (auxiliar == 38)
                    {
                        Carac2.Text = "L";
                    }
                    else if (auxiliar == 39)
                    {
                        Carac2.Text = "M";
                    }
                    else if (auxiliar == 40)
                    {
                        Carac2.Text = "N";
                    }
                    else if (auxiliar == 41)
                    {
                        Carac2.Text = "O";
                    }
                    else if (auxiliar == 42)
                    {
                        Carac2.Text = "P";
                    }
                    else if (auxiliar == 43)
                    {
                        Carac2.Text = "Q";
                    }
                    else if (auxiliar == 44)
                    {
                        Carac2.Text = "R";
                    }
                    else if (auxiliar == 45)
                    {
                        Carac2.Text = "S";
                    }
                    else if (auxiliar == 46)
                    {
                        Carac2.Text = "T";
                    }
                    else if (auxiliar == 47)
                    {
                        Carac2.Text = "U";
                    }
                    else if (auxiliar == 48)
                    {
                        Carac2.Text = "V";
                    }
                    else if (auxiliar == 49)
                    {
                        Carac2.Text = "W";
                    }
                    else if (auxiliar == 50)
                    {
                        Carac2.Text = "X";
                    }
                    else if (auxiliar == 51)
                    {
                        Carac2.Text = "Y";
                    }
                    else if (auxiliar == 52)
                    {
                        Carac2.Text = "Z";
                    }
                }
                if (carac >= 3)
                {
                    auxiliar = senha.Next(1, 52);

                    Carac1.Visible = true;
                    Carac2.Visible = true;
                    Carac3.Visible = true;
                    Carac4.Visible = false;
                    Carac5.Visible = false;
                    Carac6.Visible = false;
                    Carac7.Visible = false;
                    Carac8.Visible = false;
                    Carac9.Visible = false;
                    Carac10.Visible = false;
                    Carac11.Visible = false;
                    Carac12.Visible = false;
                    Carac13.Visible = false;
                    Carac14.Visible = false;
                    Carac15.Visible = false;

                    if (auxiliar == 1)
                    {
                        Carac3.Text = "a";
                    }
                    else if (auxiliar == 2)
                    {
                        Carac3.Text = "b";
                    }
                    else if (auxiliar == 3)
                    {
                        Carac3.Text = "c";
                    }
                    else if (auxiliar == 4)
                    {
                        Carac3.Text = "d";
                    }
                    else if (auxiliar == 5)
                    {
                        Carac3.Text = "e";
                    }
                    else if (auxiliar == 6)
                    {
                        Carac3.Text = "f";
                    }
                    else if (auxiliar == 7)
                    {
                        Carac3.Text = "g";
                    }
                    else if (auxiliar == 8)
                    {
                        Carac3.Text = "h";
                    }
                    else if (auxiliar == 9)
                    {
                        Carac3.Text = "i";
                    }
                    else if (auxiliar == 10)
                    {
                        Carac3.Text = "j";
                    }
                    else if (auxiliar == 11)
                    {
                        Carac3.Text = "k";
                    }
                    else if (auxiliar == 12)
                    {
                        Carac3.Text = "l";
                    }
                    else if (auxiliar == 13)
                    {
                        Carac3.Text = "m";
                    }
                    else if (auxiliar == 14)
                    {
                        Carac3.Text = "n";
                    }
                    else if (auxiliar == 15)
                    {
                        Carac3.Text = "o";
                    }
                    else if (auxiliar == 16)
                    {
                        Carac3.Text = "p";
                    }
                    else if (auxiliar == 17)
                    {
                        Carac3.Text = "q";
                    }
                    else if (auxiliar == 18)
                    {
                        Carac3.Text = "r";
                    }
                    else if (auxiliar == 19)
                    {
                        Carac3.Text = "s";
                    }
                    else if (auxiliar == 20)
                    {
                        Carac3.Text = "t";
                    }
                    else if (auxiliar == 21)
                    {
                        Carac3.Text = "u";
                    }
                    else if (auxiliar == 22)
                    {
                        Carac3.Text = "v";
                    }
                    else if (auxiliar == 23)
                    {
                        Carac3.Text = "w";
                    }
                    else if (auxiliar == 24)
                    {
                        Carac3.Text = "x";
                    }
                    else if (auxiliar == 25)
                    {
                        Carac3.Text = "y";
                    }
                    else if (auxiliar == 26)
                    {
                        Carac3.Text = "z";
                    }
                    else if (auxiliar == 27)
                    {
                        Carac3.Text = "A";
                    }
                    else if (auxiliar == 28)
                    {
                        Carac3.Text = "B";
                    }
                    else if (auxiliar == 29)
                    {
                        Carac3.Text = "C";
                    }
                    else if (auxiliar == 30)
                    {
                        Carac3.Text = "D";
                    }
                    else if (auxiliar == 31)
                    {
                        Carac3.Text = "E";
                    }
                    else if (auxiliar == 32)
                    {
                        Carac3.Text = "F";
                    }
                    else if (auxiliar == 33)
                    {
                        Carac3.Text = "G";
                    }
                    else if (auxiliar == 34)
                    {
                        Carac3.Text = "H";
                    }
                    else if (auxiliar == 35)
                    {
                        Carac3.Text = "I";
                    }
                    else if (auxiliar == 36)
                    {
                        Carac3.Text = "J";
                    }
                    else if (auxiliar == 37)
                    {
                        Carac3.Text = "K";
                    }
                    else if (auxiliar == 38)
                    {
                        Carac3.Text = "L";
                    }
                    else if (auxiliar == 39)
                    {
                        Carac3.Text = "M";
                    }
                    else if (auxiliar == 40)
                    {
                        Carac3.Text = "N";
                    }
                    else if (auxiliar == 41)
                    {
                        Carac3.Text = "O";
                    }
                    else if (auxiliar == 42)
                    {
                        Carac3.Text = "P";
                    }
                    else if (auxiliar == 43)
                    {
                        Carac3.Text = "Q";
                    }
                    else if (auxiliar == 44)
                    {
                        Carac3.Text = "R";
                    }
                    else if (auxiliar == 45)
                    {
                        Carac3.Text = "S";
                    }
                    else if (auxiliar == 46)
                    {
                        Carac3.Text = "T";
                    }
                    else if (auxiliar == 47)
                    {
                        Carac3.Text = "U";
                    }
                    else if (auxiliar == 48)
                    {
                        Carac3.Text = "V";
                    }
                    else if (auxiliar == 49)
                    {
                        Carac3.Text = "W";
                    }
                    else if (auxiliar == 50)
                    {
                        Carac3.Text = "X";
                    }
                    else if (auxiliar == 51)
                    {
                        Carac3.Text = "Y";
                    }
                    else if (auxiliar == 52)
                    {
                        Carac3.Text = "Z";
                    }
                }
                if (carac >= 4)
                {
                    auxiliar = senha.Next(1, 52);

                    Carac1.Visible = true;
                    Carac2.Visible = true;
                    Carac3.Visible = true;
                    Carac4.Visible = true;
                    Carac5.Visible = false;
                    Carac6.Visible = false;
                    Carac7.Visible = false;
                    Carac8.Visible = false;
                    Carac9.Visible = false;
                    Carac10.Visible = false;
                    Carac11.Visible = false;
                    Carac12.Visible = false;
                    Carac13.Visible = false;
                    Carac14.Visible = false;
                    Carac15.Visible = false;

                    if (auxiliar == 1)
                    {
                        Carac4.Text = "a";
                    }
                    else if (auxiliar == 2)
                    {
                        Carac4.Text = "b";
                    }
                    else if (auxiliar == 3)
                    {
                        Carac4.Text = "c";
                    }
                    else if (auxiliar == 4)
                    {
                        Carac4.Text = "d";
                    }
                    else if (auxiliar == 5)
                    {
                        Carac4.Text = "e";
                    }
                    else if (auxiliar == 6)
                    {
                        Carac4.Text = "f";
                    }
                    else if (auxiliar == 7)
                    {
                        Carac4.Text = "g";
                    }
                    else if (auxiliar == 8)
                    {
                        Carac4.Text = "h";
                    }
                    else if (auxiliar == 9)
                    {
                        Carac4.Text = "i";
                    }
                    else if (auxiliar == 10)
                    {
                        Carac4.Text = "j";
                    }
                    else if (auxiliar == 11)
                    {
                        Carac4.Text = "k";
                    }
                    else if (auxiliar == 12)
                    {
                        Carac4.Text = "l";
                    }
                    else if (auxiliar == 13)
                    {
                        Carac4.Text = "m";
                    }
                    else if (auxiliar == 14)
                    {
                        Carac4.Text = "n";
                    }
                    else if (auxiliar == 15)
                    {
                        Carac4.Text = "o";
                    }
                    else if (auxiliar == 16)
                    {
                        Carac4.Text = "p";
                    }
                    else if (auxiliar == 17)
                    {
                        Carac4.Text = "q";
                    }
                    else if (auxiliar == 18)
                    {
                        Carac4.Text = "r";
                    }
                    else if (auxiliar == 19)
                    {
                        Carac4.Text = "s";
                    }
                    else if (auxiliar == 20)
                    {
                        Carac4.Text = "t";
                    }
                    else if (auxiliar == 21)
                    {
                        Carac4.Text = "u";
                    }
                    else if (auxiliar == 22)
                    {
                        Carac4.Text = "v";
                    }
                    else if (auxiliar == 23)
                    {
                        Carac4.Text = "w";
                    }
                    else if (auxiliar == 24)
                    {
                        Carac4.Text = "x";
                    }
                    else if (auxiliar == 25)
                    {
                        Carac4.Text = "y";
                    }
                    else if (auxiliar == 26)
                    {
                        Carac4.Text = "z";
                    }
                    else if (auxiliar == 27)
                    {
                        Carac4.Text = "A";
                    }
                    else if (auxiliar == 28)
                    {
                        Carac4.Text = "B";
                    }
                    else if (auxiliar == 29)
                    {
                        Carac4.Text = "C";
                    }
                    else if (auxiliar == 30)
                    {
                        Carac4.Text = "D";
                    }
                    else if (auxiliar == 31)
                    {
                        Carac4.Text = "E";
                    }
                    else if (auxiliar == 32)
                    {
                        Carac4.Text = "F";
                    }
                    else if (auxiliar == 33)
                    {
                        Carac4.Text = "G";
                    }
                    else if (auxiliar == 34)
                    {
                        Carac4.Text = "H";
                    }
                    else if (auxiliar == 35)
                    {
                        Carac4.Text = "I";
                    }
                    else if (auxiliar == 36)
                    {
                        Carac4.Text = "J";
                    }
                    else if (auxiliar == 37)
                    {
                        Carac4.Text = "K";
                    }
                    else if (auxiliar == 38)
                    {
                        Carac4.Text = "L";
                    }
                    else if (auxiliar == 39)
                    {
                        Carac4.Text = "M";
                    }
                    else if (auxiliar == 40)
                    {
                        Carac4.Text = "N";
                    }
                    else if (auxiliar == 41)
                    {
                        Carac4.Text = "O";
                    }
                    else if (auxiliar == 42)
                    {
                        Carac4.Text = "P";
                    }
                    else if (auxiliar == 43)
                    {
                        Carac4.Text = "Q";
                    }
                    else if (auxiliar == 44)
                    {
                        Carac4.Text = "R";
                    }
                    else if (auxiliar == 45)
                    {
                        Carac4.Text = "S";
                    }
                    else if (auxiliar == 46)
                    {
                        Carac4.Text = "T";
                    }
                    else if (auxiliar == 47)
                    {
                        Carac4.Text = "U";
                    }
                    else if (auxiliar == 48)
                    {
                        Carac4.Text = "V";
                    }
                    else if (auxiliar == 49)
                    {
                        Carac4.Text = "W";
                    }
                    else if (auxiliar == 50)
                    {
                        Carac4.Text = "X";
                    }
                    else if (auxiliar == 51)
                    {
                        Carac4.Text = "Y";
                    }
                    else if (auxiliar == 52)
                    {
                        Carac4.Text = "Z";
                    }
                }
                if (carac >= 5)
                {
                    auxiliar = senha.Next(1, 52);

                    Carac1.Visible = true;
                    Carac2.Visible = true;
                    Carac3.Visible = true;
                    Carac4.Visible = true;
                    Carac5.Visible = true;
                    Carac6.Visible = false;
                    Carac7.Visible = false;
                    Carac8.Visible = false;
                    Carac9.Visible = false;
                    Carac10.Visible = false;
                    Carac11.Visible = false;
                    Carac12.Visible = false;
                    Carac13.Visible = false;
                    Carac14.Visible = false;
                    Carac15.Visible = false;

                    if (auxiliar == 1)
                    {
                        Carac5.Text = "a";
                    }
                    else if (auxiliar == 2)
                    {
                        Carac5.Text = "b";
                    }
                    else if (auxiliar == 3)
                    {
                        Carac5.Text = "c";
                    }
                    else if (auxiliar == 4)
                    {
                        Carac5.Text = "d";
                    }
                    else if (auxiliar == 5)
                    {
                        Carac5.Text = "e";
                    }
                    else if (auxiliar == 6)
                    {
                        Carac5.Text = "f";
                    }
                    else if (auxiliar == 7)
                    {
                        Carac5.Text = "g";
                    }
                    else if (auxiliar == 8)
                    {
                        Carac5.Text = "h";
                    }
                    else if (auxiliar == 9)
                    {
                        Carac5.Text = "i";
                    }
                    else if (auxiliar == 10)
                    {
                        Carac5.Text = "j";
                    }
                    else if (auxiliar == 11)
                    {
                        Carac5.Text = "k";
                    }
                    else if (auxiliar == 12)
                    {
                        Carac5.Text = "l";
                    }
                    else if (auxiliar == 13)
                    {
                        Carac5.Text = "m";
                    }
                    else if (auxiliar == 14)
                    {
                        Carac5.Text = "n";
                    }
                    else if (auxiliar == 15)
                    {
                        Carac5.Text = "o";
                    }
                    else if (auxiliar == 16)
                    {
                        Carac5.Text = "p";
                    }
                    else if (auxiliar == 17)
                    {
                        Carac5.Text = "q";
                    }
                    else if (auxiliar == 18)
                    {
                        Carac5.Text = "r";
                    }
                    else if (auxiliar == 19)
                    {
                        Carac5.Text = "s";
                    }
                    else if (auxiliar == 20)
                    {
                        Carac5.Text = "t";
                    }
                    else if (auxiliar == 21)
                    {
                        Carac5.Text = "u";
                    }
                    else if (auxiliar == 22)
                    {
                        Carac5.Text = "v";
                    }
                    else if (auxiliar == 23)
                    {
                        Carac5.Text = "w";
                    }
                    else if (auxiliar == 24)
                    {
                        Carac5.Text = "x";
                    }
                    else if (auxiliar == 25)
                    {
                        Carac5.Text = "y";
                    }
                    else if (auxiliar == 26)
                    {
                        Carac5.Text = "z";
                    }
                    else if (auxiliar == 27)
                    {
                        Carac5.Text = "A";
                    }
                    else if (auxiliar == 28)
                    {
                        Carac5.Text = "B";
                    }
                    else if (auxiliar == 29)
                    {
                        Carac5.Text = "C";
                    }
                    else if (auxiliar == 30)
                    {
                        Carac5.Text = "D";
                    }
                    else if (auxiliar == 31)
                    {
                        Carac5.Text = "E";
                    }
                    else if (auxiliar == 32)
                    {
                        Carac5.Text = "F";
                    }
                    else if (auxiliar == 33)
                    {
                        Carac5.Text = "G";
                    }
                    else if (auxiliar == 34)
                    {
                        Carac5.Text = "H";
                    }
                    else if (auxiliar == 35)
                    {
                        Carac5.Text = "I";
                    }
                    else if (auxiliar == 36)
                    {
                        Carac5.Text = "J";
                    }
                    else if (auxiliar == 37)
                    {
                        Carac5.Text = "K";
                    }
                    else if (auxiliar == 38)
                    {
                        Carac5.Text = "L";
                    }
                    else if (auxiliar == 39)
                    {
                        Carac5.Text = "M";
                    }
                    else if (auxiliar == 40)
                    {
                        Carac5.Text = "N";
                    }
                    else if (auxiliar == 41)
                    {
                        Carac5.Text = "O";
                    }
                    else if (auxiliar == 42)
                    {
                        Carac5.Text = "P";
                    }
                    else if (auxiliar == 43)
                    {
                        Carac5.Text = "Q";
                    }
                    else if (auxiliar == 44)
                    {
                        Carac5.Text = "R";
                    }
                    else if (auxiliar == 45)
                    {
                        Carac5.Text = "S";
                    }
                    else if (auxiliar == 46)
                    {
                        Carac5.Text = "T";
                    }
                    else if (auxiliar == 47)
                    {
                        Carac5.Text = "U";
                    }
                    else if (auxiliar == 48)
                    {
                        Carac5.Text = "V";
                    }
                    else if (auxiliar == 49)
                    {
                        Carac5.Text = "W";
                    }
                    else if (auxiliar == 50)
                    {
                        Carac5.Text = "X";
                    }
                    else if (auxiliar == 51)
                    {
                        Carac5.Text = "Y";
                    }
                    else if (auxiliar == 52)
                    {
                        Carac5.Text = "Z";
                    }
                }
                if (carac >= 6)
                {
                    auxiliar = senha.Next(1, 52);

                    Carac1.Visible = true;
                    Carac2.Visible = true;
                    Carac3.Visible = true;
                    Carac4.Visible = true;
                    Carac5.Visible = true;
                    Carac6.Visible = true;
                    Carac7.Visible = false;
                    Carac8.Visible = false;
                    Carac9.Visible = false;
                    Carac10.Visible = false;
                    Carac11.Visible = false;
                    Carac12.Visible = false;
                    Carac13.Visible = false;
                    Carac14.Visible = false;
                    Carac15.Visible = false;

                    if (auxiliar == 1)
                    {
                        Carac6.Text = "a";
                    }
                    else if (auxiliar == 2)
                    {
                        Carac6.Text = "b";
                    }
                    else if (auxiliar == 3)
                    {
                        Carac6.Text = "c";
                    }
                    else if (auxiliar == 4)
                    {
                        Carac6.Text = "d";
                    }
                    else if (auxiliar == 5)
                    {
                        Carac6.Text = "e";
                    }
                    else if (auxiliar == 6)
                    {
                        Carac6.Text = "f";
                    }
                    else if (auxiliar == 7)
                    {
                        Carac6.Text = "g";
                    }
                    else if (auxiliar == 8)
                    {
                        Carac6.Text = "h";
                    }
                    else if (auxiliar == 9)
                    {
                        Carac6.Text = "i";
                    }
                    else if (auxiliar == 10)
                    {
                        Carac6.Text = "j";
                    }
                    else if (auxiliar == 11)
                    {
                        Carac6.Text = "k";
                    }
                    else if (auxiliar == 12)
                    {
                        Carac6.Text = "l";
                    }
                    else if (auxiliar == 13)
                    {
                        Carac6.Text = "m";
                    }
                    else if (auxiliar == 14)
                    {
                        Carac6.Text = "n";
                    }
                    else if (auxiliar == 15)
                    {
                        Carac6.Text = "o";
                    }
                    else if (auxiliar == 16)
                    {
                        Carac6.Text = "p";
                    }
                    else if (auxiliar == 17)
                    {
                        Carac6.Text = "q";
                    }
                    else if (auxiliar == 18)
                    {
                        Carac6.Text = "r";
                    }
                    else if (auxiliar == 19)
                    {
                        Carac6.Text = "s";
                    }
                    else if (auxiliar == 20)
                    {
                        Carac6.Text = "t";
                    }
                    else if (auxiliar == 21)
                    {
                        Carac6.Text = "u";
                    }
                    else if (auxiliar == 22)
                    {
                        Carac6.Text = "v";
                    }
                    else if (auxiliar == 23)
                    {
                        Carac6.Text = "w";
                    }
                    else if (auxiliar == 24)
                    {
                        Carac6.Text = "x";
                    }
                    else if (auxiliar == 25)
                    {
                        Carac6.Text = "y";
                    }
                    else if (auxiliar == 26)
                    {
                        Carac6.Text = "z";
                    }
                    else if (auxiliar == 27)
                    {
                        Carac6.Text = "A";
                    }
                    else if (auxiliar == 28)
                    {
                        Carac6.Text = "B";
                    }
                    else if (auxiliar == 29)
                    {
                        Carac6.Text = "C";
                    }
                    else if (auxiliar == 30)
                    {
                        Carac6.Text = "D";
                    }
                    else if (auxiliar == 31)
                    {
                        Carac6.Text = "E";
                    }
                    else if (auxiliar == 32)
                    {
                        Carac6.Text = "F";
                    }
                    else if (auxiliar == 33)
                    {
                        Carac6.Text = "G";
                    }
                    else if (auxiliar == 34)
                    {
                        Carac6.Text = "H";
                    }
                    else if (auxiliar == 35)
                    {
                        Carac6.Text = "I";
                    }
                    else if (auxiliar == 36)
                    {
                        Carac6.Text = "J";
                    }
                    else if (auxiliar == 37)
                    {
                        Carac6.Text = "K";
                    }
                    else if (auxiliar == 38)
                    {
                        Carac6.Text = "L";
                    }
                    else if (auxiliar == 39)
                    {
                        Carac6.Text = "M";
                    }
                    else if (auxiliar == 40)
                    {
                        Carac6.Text = "N";
                    }
                    else if (auxiliar == 41)
                    {
                        Carac6.Text = "O";
                    }
                    else if (auxiliar == 42)
                    {
                        Carac6.Text = "P";
                    }
                    else if (auxiliar == 43)
                    {
                        Carac6.Text = "Q";
                    }
                    else if (auxiliar == 44)
                    {
                        Carac6.Text = "R";
                    }
                    else if (auxiliar == 45)
                    {
                        Carac6.Text = "S";
                    }
                    else if (auxiliar == 46)
                    {
                        Carac6.Text = "T";
                    }
                    else if (auxiliar == 47)
                    {
                        Carac6.Text = "U";
                    }
                    else if (auxiliar == 48)
                    {
                        Carac6.Text = "V";
                    }
                    else if (auxiliar == 49)
                    {
                        Carac6.Text = "W";
                    }
                    else if (auxiliar == 50)
                    {
                        Carac6.Text = "X";
                    }
                    else if (auxiliar == 51)
                    {
                        Carac6.Text = "Y";
                    }
                    else if (auxiliar == 52)
                    {
                        Carac6.Text = "Z";
                    }
                }
                if (carac >= 7)
                {
                    auxiliar = senha.Next(1, 52);

                    Carac1.Visible = true;
                    Carac2.Visible = true;
                    Carac3.Visible = true;
                    Carac4.Visible = true;
                    Carac5.Visible = true;
                    Carac6.Visible = true;
                    Carac7.Visible = true;
                    Carac8.Visible = false;
                    Carac9.Visible = false;
                    Carac10.Visible = false;
                    Carac11.Visible = false;
                    Carac12.Visible = false;
                    Carac13.Visible = false;
                    Carac14.Visible = false;
                    Carac15.Visible = false;

                    if (auxiliar == 1)
                    {
                        Carac7.Text = "a";
                    }
                    else if (auxiliar == 2)
                    {
                        Carac7.Text = "b";
                    }
                    else if (auxiliar == 3)
                    {
                        Carac7.Text = "c";
                    }
                    else if (auxiliar == 4)
                    {
                        Carac7.Text = "d";
                    }
                    else if (auxiliar == 5)
                    {
                        Carac7.Text = "e";
                    }
                    else if (auxiliar == 6)
                    {
                        Carac7.Text = "f";
                    }
                    else if (auxiliar == 7)
                    {
                        Carac7.Text = "g";
                    }
                    else if (auxiliar == 8)
                    {
                        Carac7.Text = "h";
                    }
                    else if (auxiliar == 9)
                    {
                        Carac7.Text = "i";
                    }
                    else if (auxiliar == 10)
                    {
                        Carac7.Text = "j";
                    }
                    else if (auxiliar == 11)
                    {
                        Carac7.Text = "k";
                    }
                    else if (auxiliar == 12)
                    {
                        Carac7.Text = "l";
                    }
                    else if (auxiliar == 13)
                    {
                        Carac7.Text = "m";
                    }
                    else if (auxiliar == 14)
                    {
                        Carac7.Text = "n";
                    }
                    else if (auxiliar == 15)
                    {
                        Carac7.Text = "o";
                    }
                    else if (auxiliar == 16)
                    {
                        Carac7.Text = "p";
                    }
                    else if (auxiliar == 17)
                    {
                        Carac7.Text = "q";
                    }
                    else if (auxiliar == 18)
                    {
                        Carac7.Text = "r";
                    }
                    else if (auxiliar == 19)
                    {
                        Carac7.Text = "s";
                    }
                    else if (auxiliar == 20)
                    {
                        Carac7.Text = "t";
                    }
                    else if (auxiliar == 21)
                    {
                        Carac7.Text = "u";
                    }
                    else if (auxiliar == 22)
                    {
                        Carac7.Text = "v";
                    }
                    else if (auxiliar == 23)
                    {
                        Carac7.Text = "w";
                    }
                    else if (auxiliar == 24)
                    {
                        Carac7.Text = "x";
                    }
                    else if (auxiliar == 25)
                    {
                        Carac7.Text = "y";
                    }
                    else if (auxiliar == 26)
                    {
                        Carac7.Text = "z";
                    }
                    else if (auxiliar == 27)
                    {
                        Carac7.Text = "A";
                    }
                    else if (auxiliar == 28)
                    {
                        Carac7.Text = "B";
                    }
                    else if (auxiliar == 29)
                    {
                        Carac7.Text = "C";
                    }
                    else if (auxiliar == 30)
                    {
                        Carac7.Text = "D";
                    }
                    else if (auxiliar == 31)
                    {
                        Carac7.Text = "E";
                    }
                    else if (auxiliar == 32)
                    {
                        Carac7.Text = "F";
                    }
                    else if (auxiliar == 33)
                    {
                        Carac7.Text = "G";
                    }
                    else if (auxiliar == 34)
                    {
                        Carac7.Text = "H";
                    }
                    else if (auxiliar == 35)
                    {
                        Carac7.Text = "I";
                    }
                    else if (auxiliar == 36)
                    {
                        Carac7.Text = "J";
                    }
                    else if (auxiliar == 37)
                    {
                        Carac7.Text = "K";
                    }
                    else if (auxiliar == 38)
                    {
                        Carac7.Text = "L";
                    }
                    else if (auxiliar == 39)
                    {
                        Carac7.Text = "M";
                    }
                    else if (auxiliar == 40)
                    {
                        Carac7.Text = "N";
                    }
                    else if (auxiliar == 41)
                    {
                        Carac7.Text = "O";
                    }
                    else if (auxiliar == 42)
                    {
                        Carac7.Text = "P";
                    }
                    else if (auxiliar == 43)
                    {
                        Carac7.Text = "Q";
                    }
                    else if (auxiliar == 44)
                    {
                        Carac7.Text = "R";
                    }
                    else if (auxiliar == 45)
                    {
                        Carac7.Text = "S";
                    }
                    else if (auxiliar == 46)
                    {
                        Carac7.Text = "T";
                    }
                    else if (auxiliar == 47)
                    {
                        Carac7.Text = "U";
                    }
                    else if (auxiliar == 48)
                    {
                        Carac7.Text = "V";
                    }
                    else if (auxiliar == 49)
                    {
                        Carac7.Text = "W";
                    }
                    else if (auxiliar == 50)
                    {
                        Carac7.Text = "X";
                    }
                    else if (auxiliar == 51)
                    {
                        Carac7.Text = "Y";
                    }
                    else if (auxiliar == 52)
                    {
                        Carac7.Text = "Z";
                    }
                }
                if (carac >= 8)
                {
                    auxiliar = senha.Next(1, 52);

                    Carac1.Visible = true;
                    Carac2.Visible = true;
                    Carac3.Visible = true;
                    Carac4.Visible = true;
                    Carac5.Visible = true;
                    Carac6.Visible = true;
                    Carac7.Visible = true;
                    Carac8.Visible = true;
                    Carac9.Visible = false;
                    Carac10.Visible = false;
                    Carac11.Visible = false;
                    Carac12.Visible = false;
                    Carac13.Visible = false;
                    Carac14.Visible = false;
                    Carac15.Visible = false;

                    if (auxiliar == 1)
                    {
                        Carac8.Text = "a";
                    }
                    else if (auxiliar == 2)
                    {
                        Carac8.Text = "b";
                    }
                    else if (auxiliar == 3)
                    {
                        Carac8.Text = "c";
                    }
                    else if (auxiliar == 4)
                    {
                        Carac8.Text = "d";
                    }
                    else if (auxiliar == 5)
                    {
                        Carac8.Text = "e";
                    }
                    else if (auxiliar == 6)
                    {
                        Carac8.Text = "f";
                    }
                    else if (auxiliar == 7)
                    {
                        Carac8.Text = "g";
                    }
                    else if (auxiliar == 8)
                    {
                        Carac8.Text = "h";
                    }
                    else if (auxiliar == 9)
                    {
                        Carac8.Text = "i";
                    }
                    else if (auxiliar == 10)
                    {
                        Carac8.Text = "j";
                    }
                    else if (auxiliar == 11)
                    {
                        Carac8.Text = "k";
                    }
                    else if (auxiliar == 12)
                    {
                        Carac8.Text = "l";
                    }
                    else if (auxiliar == 13)
                    {
                        Carac8.Text = "m";
                    }
                    else if (auxiliar == 14)
                    {
                        Carac8.Text = "n";
                    }
                    else if (auxiliar == 15)
                    {
                        Carac8.Text = "o";
                    }
                    else if (auxiliar == 16)
                    {
                        Carac8.Text = "p";
                    }
                    else if (auxiliar == 17)
                    {
                        Carac8.Text = "q";
                    }
                    else if (auxiliar == 18)
                    {
                        Carac8.Text = "r";
                    }
                    else if (auxiliar == 19)
                    {
                        Carac8.Text = "s";
                    }
                    else if (auxiliar == 20)
                    {
                        Carac8.Text = "t";
                    }
                    else if (auxiliar == 21)
                    {
                        Carac8.Text = "u";
                    }
                    else if (auxiliar == 22)
                    {
                        Carac8.Text = "v";
                    }
                    else if (auxiliar == 23)
                    {
                        Carac8.Text = "w";
                    }
                    else if (auxiliar == 24)
                    {
                        Carac8.Text = "x";
                    }
                    else if (auxiliar == 25)
                    {
                        Carac8.Text = "y";
                    }
                    else if (auxiliar == 26)
                    {
                        Carac8.Text = "z";
                    }
                    else if (auxiliar == 27)
                    {
                        Carac8.Text = "A";
                    }
                    else if (auxiliar == 28)
                    {
                        Carac8.Text = "B";
                    }
                    else if (auxiliar == 29)
                    {
                        Carac8.Text = "C";
                    }
                    else if (auxiliar == 30)
                    {
                        Carac8.Text = "D";
                    }
                    else if (auxiliar == 31)
                    {
                        Carac8.Text = "E";
                    }
                    else if (auxiliar == 32)
                    {
                        Carac8.Text = "F";
                    }
                    else if (auxiliar == 33)
                    {
                        Carac8.Text = "G";
                    }
                    else if (auxiliar == 34)
                    {
                        Carac8.Text = "H";
                    }
                    else if (auxiliar == 35)
                    {
                        Carac8.Text = "I";
                    }
                    else if (auxiliar == 36)
                    {
                        Carac8.Text = "J";
                    }
                    else if (auxiliar == 37)
                    {
                        Carac8.Text = "K";
                    }
                    else if (auxiliar == 38)
                    {
                        Carac8.Text = "L";
                    }
                    else if (auxiliar == 39)
                    {
                        Carac8.Text = "M";
                    }
                    else if (auxiliar == 40)
                    {
                        Carac8.Text = "N";
                    }
                    else if (auxiliar == 41)
                    {
                        Carac8.Text = "O";
                    }
                    else if (auxiliar == 42)
                    {
                        Carac8.Text = "P";
                    }
                    else if (auxiliar == 43)
                    {
                        Carac8.Text = "Q";
                    }
                    else if (auxiliar == 44)
                    {
                        Carac8.Text = "R";
                    }
                    else if (auxiliar == 45)
                    {
                        Carac8.Text = "S";
                    }
                    else if (auxiliar == 46)
                    {
                        Carac8.Text = "T";
                    }
                    else if (auxiliar == 47)
                    {
                        Carac8.Text = "U";
                    }
                    else if (auxiliar == 48)
                    {
                        Carac8.Text = "V";
                    }
                    else if (auxiliar == 49)
                    {
                        Carac8.Text = "W";
                    }
                    else if (auxiliar == 50)
                    {
                        Carac8.Text = "X";
                    }
                    else if (auxiliar == 51)
                    {
                        Carac8.Text = "Y";
                    }
                    else if (auxiliar == 52)
                    {
                        Carac8.Text = "Z";
                    }
                }
                if (carac >= 9)
                {
                    auxiliar = senha.Next(1, 52);

                    Carac1.Visible = true;
                    Carac2.Visible = true;
                    Carac3.Visible = true;
                    Carac4.Visible = true;
                    Carac5.Visible = true;
                    Carac6.Visible = true;
                    Carac7.Visible = true;
                    Carac8.Visible = true;
                    Carac9.Visible = true;
                    Carac10.Visible = false;
                    Carac11.Visible = false;
                    Carac12.Visible = false;
                    Carac13.Visible = false;
                    Carac14.Visible = false;
                    Carac15.Visible = false;

                    if (auxiliar == 1)
                    {
                        Carac9.Text = "a";
                    }
                    else if (auxiliar == 2)
                    {
                        Carac9.Text = "b";
                    }
                    else if (auxiliar == 3)
                    {
                        Carac9.Text = "c";
                    }
                    else if (auxiliar == 4)
                    {
                        Carac9.Text = "d";
                    }
                    else if (auxiliar == 5)
                    {
                        Carac9.Text = "e";
                    }
                    else if (auxiliar == 6)
                    {
                        Carac9.Text = "f";
                    }
                    else if (auxiliar == 7)
                    {
                        Carac9.Text = "g";
                    }
                    else if (auxiliar == 8)
                    {
                        Carac9.Text = "h";
                    }
                    else if (auxiliar == 9)
                    {
                        Carac9.Text = "i";
                    }
                    else if (auxiliar == 10)
                    {
                        Carac9.Text = "j";
                    }
                    else if (auxiliar == 11)
                    {
                        Carac9.Text = "k";
                    }
                    else if (auxiliar == 12)
                    {
                        Carac9.Text = "l";
                    }
                    else if (auxiliar == 13)
                    {
                        Carac9.Text = "m";
                    }
                    else if (auxiliar == 14)
                    {
                        Carac9.Text = "n";
                    }
                    else if (auxiliar == 15)
                    {
                        Carac9.Text = "o";
                    }
                    else if (auxiliar == 16)
                    {
                        Carac9.Text = "p";
                    }
                    else if (auxiliar == 17)
                    {
                        Carac9.Text = "q";
                    }
                    else if (auxiliar == 18)
                    {
                        Carac9.Text = "r";
                    }
                    else if (auxiliar == 19)
                    {
                        Carac9.Text = "s";
                    }
                    else if (auxiliar == 20)
                    {
                        Carac9.Text = "t";
                    }
                    else if (auxiliar == 21)
                    {
                        Carac9.Text = "u";
                    }
                    else if (auxiliar == 22)
                    {
                        Carac9.Text = "v";
                    }
                    else if (auxiliar == 23)
                    {
                        Carac9.Text = "w";
                    }
                    else if (auxiliar == 24)
                    {
                        Carac9.Text = "x";
                    }
                    else if (auxiliar == 25)
                    {
                        Carac9.Text = "y";
                    }
                    else if (auxiliar == 26)
                    {
                        Carac9.Text = "z";
                    }
                    else if (auxiliar == 27)
                    {
                        Carac9.Text = "A";
                    }
                    else if (auxiliar == 28)
                    {
                        Carac9.Text = "B";
                    }
                    else if (auxiliar == 29)
                    {
                        Carac9.Text = "C";
                    }
                    else if (auxiliar == 30)
                    {
                        Carac9.Text = "D";
                    }
                    else if (auxiliar == 31)
                    {
                        Carac9.Text = "E";
                    }
                    else if (auxiliar == 32)
                    {
                        Carac9.Text = "F";
                    }
                    else if (auxiliar == 33)
                    {
                        Carac9.Text = "G";
                    }
                    else if (auxiliar == 34)
                    {
                        Carac9.Text = "H";
                    }
                    else if (auxiliar == 35)
                    {
                        Carac9.Text = "I";
                    }
                    else if (auxiliar == 36)
                    {
                        Carac9.Text = "J";
                    }
                    else if (auxiliar == 37)
                    {
                        Carac9.Text = "K";
                    }
                    else if (auxiliar == 38)
                    {
                        Carac9.Text = "L";
                    }
                    else if (auxiliar == 39)
                    {
                        Carac9.Text = "M";
                    }
                    else if (auxiliar == 40)
                    {
                        Carac9.Text = "N";
                    }
                    else if (auxiliar == 41)
                    {
                        Carac9.Text = "O";
                    }
                    else if (auxiliar == 42)
                    {
                        Carac9.Text = "P";
                    }
                    else if (auxiliar == 43)
                    {
                        Carac9.Text = "Q";
                    }
                    else if (auxiliar == 44)
                    {
                        Carac9.Text = "R";
                    }
                    else if (auxiliar == 45)
                    {
                        Carac9.Text = "S";
                    }
                    else if (auxiliar == 46)
                    {
                        Carac9.Text = "T";
                    }
                    else if (auxiliar == 47)
                    {
                        Carac9.Text = "U";
                    }
                    else if (auxiliar == 48)
                    {
                        Carac9.Text = "V";
                    }
                    else if (auxiliar == 49)
                    {
                        Carac9.Text = "W";
                    }
                    else if (auxiliar == 50)
                    {
                        Carac9.Text = "X";
                    }
                    else if (auxiliar == 51)
                    {
                        Carac9.Text = "Y";
                    }
                    else if (auxiliar == 52)
                    {
                        Carac9.Text = "Z";
                    }
                }
                if (carac >= 10)
                {
                    auxiliar = senha.Next(1, 52);

                    Carac1.Visible = true;
                    Carac2.Visible = true;
                    Carac3.Visible = true;
                    Carac4.Visible = true;
                    Carac5.Visible = true;
                    Carac6.Visible = true;
                    Carac7.Visible = true;
                    Carac8.Visible = true;
                    Carac9.Visible = true;
                    Carac10.Visible = true;
                    Carac11.Visible = false;
                    Carac12.Visible = false;
                    Carac13.Visible = false;
                    Carac14.Visible = false;
                    Carac15.Visible = false;

                    if (auxiliar == 1)
                    {
                        Carac10.Text = "a";
                    }
                    else if (auxiliar == 2)
                    {
                        Carac10.Text = "b";
                    }
                    else if (auxiliar == 3)
                    {
                        Carac10.Text = "c";
                    }
                    else if (auxiliar == 4)
                    {
                        Carac10.Text = "d";
                    }
                    else if (auxiliar == 5)
                    {
                        Carac10.Text = "e";
                    }
                    else if (auxiliar == 6)
                    {
                        Carac10.Text = "f";
                    }
                    else if (auxiliar == 7)
                    {
                        Carac10.Text = "g";
                    }
                    else if (auxiliar == 8)
                    {
                        Carac10.Text = "h";
                    }
                    else if (auxiliar == 9)
                    {
                        Carac10.Text = "i";
                    }
                    else if (auxiliar == 10)
                    {
                        Carac10.Text = "j";
                    }
                    else if (auxiliar == 11)
                    {
                        Carac10.Text = "k";
                    }
                    else if (auxiliar == 12)
                    {
                        Carac10.Text = "l";
                    }
                    else if (auxiliar == 13)
                    {
                        Carac10.Text = "m";
                    }
                    else if (auxiliar == 14)
                    {
                        Carac10.Text = "n";
                    }
                    else if (auxiliar == 15)
                    {
                        Carac10.Text = "o";
                    }
                    else if (auxiliar == 16)
                    {
                        Carac10.Text = "p";
                    }
                    else if (auxiliar == 17)
                    {
                        Carac10.Text = "q";
                    }
                    else if (auxiliar == 18)
                    {
                        Carac10.Text = "r";
                    }
                    else if (auxiliar == 19)
                    {
                        Carac10.Text = "s";
                    }
                    else if (auxiliar == 20)
                    {
                        Carac10.Text = "t";
                    }
                    else if (auxiliar == 21)
                    {
                        Carac10.Text = "u";
                    }
                    else if (auxiliar == 22)
                    {
                        Carac10.Text = "v";
                    }
                    else if (auxiliar == 23)
                    {
                        Carac10.Text = "w";
                    }
                    else if (auxiliar == 24)
                    {
                        Carac10.Text = "x";
                    }
                    else if (auxiliar == 25)
                    {
                        Carac10.Text = "y";
                    }
                    else if (auxiliar == 26)
                    {
                        Carac10.Text = "z";
                    }
                    else if (auxiliar == 27)
                    {
                        Carac10.Text = "A";
                    }
                    else if (auxiliar == 28)
                    {
                        Carac10.Text = "B";
                    }
                    else if (auxiliar == 29)
                    {
                        Carac10.Text = "C";
                    }
                    else if (auxiliar == 30)
                    {
                        Carac10.Text = "D";
                    }
                    else if (auxiliar == 31)
                    {
                        Carac10.Text = "E";
                    }
                    else if (auxiliar == 32)
                    {
                        Carac10.Text = "F";
                    }
                    else if (auxiliar == 33)
                    {
                        Carac10.Text = "G";
                    }
                    else if (auxiliar == 34)
                    {
                        Carac10.Text = "H";
                    }
                    else if (auxiliar == 35)
                    {
                        Carac10.Text = "I";
                    }
                    else if (auxiliar == 36)
                    {
                        Carac10.Text = "J";
                    }
                    else if (auxiliar == 37)
                    {
                        Carac10.Text = "K";
                    }
                    else if (auxiliar == 38)
                    {
                        Carac10.Text = "L";
                    }
                    else if (auxiliar == 39)
                    {
                        Carac10.Text = "M";
                    }
                    else if (auxiliar == 40)
                    {
                        Carac10.Text = "N";
                    }
                    else if (auxiliar == 41)
                    {
                        Carac10.Text = "O";
                    }
                    else if (auxiliar == 42)
                    {
                        Carac10.Text = "P";
                    }
                    else if (auxiliar == 43)
                    {
                        Carac10.Text = "Q";
                    }
                    else if (auxiliar == 44)
                    {
                        Carac10.Text = "R";
                    }
                    else if (auxiliar == 45)
                    {
                        Carac10.Text = "S";
                    }
                    else if (auxiliar == 46)
                    {
                        Carac10.Text = "T";
                    }
                    else if (auxiliar == 47)
                    {
                        Carac10.Text = "U";
                    }
                    else if (auxiliar == 48)
                    {
                        Carac10.Text = "V";
                    }
                    else if (auxiliar == 49)
                    {
                        Carac10.Text = "W";
                    }
                    else if (auxiliar == 50)
                    {
                        Carac10.Text = "X";
                    }
                    else if (auxiliar == 51)
                    {
                        Carac10.Text = "Y";
                    }
                    else if (auxiliar == 52)
                    {
                        Carac10.Text = "Z";
                    }
                }
                if (carac >= 11)
                {
                    auxiliar = senha.Next(1, 52);

                    Carac1.Visible = true;
                    Carac2.Visible = true;
                    Carac3.Visible = true;
                    Carac4.Visible = true;
                    Carac5.Visible = true;
                    Carac6.Visible = true;
                    Carac7.Visible = true;
                    Carac8.Visible = true;
                    Carac9.Visible = true;
                    Carac10.Visible = true;
                    Carac11.Visible = true;
                    Carac12.Visible = false;
                    Carac13.Visible = false;
                    Carac14.Visible = false;
                    Carac15.Visible = false;

                    if (auxiliar == 1)
                    {
                        Carac11.Text = "a";
                    }
                    else if (auxiliar == 2)
                    {
                        Carac11.Text = "b";
                    }
                    else if (auxiliar == 3)
                    {
                        Carac11.Text = "c";
                    }
                    else if (auxiliar == 4)
                    {
                        Carac11.Text = "d";
                    }
                    else if (auxiliar == 5)
                    {
                        Carac11.Text = "e";
                    }
                    else if (auxiliar == 6)
                    {
                        Carac11.Text = "f";
                    }
                    else if (auxiliar == 7)
                    {
                        Carac11.Text = "g";
                    }
                    else if (auxiliar == 8)
                    {
                        Carac11.Text = "h";
                    }
                    else if (auxiliar == 9)
                    {
                        Carac11.Text = "i";
                    }
                    else if (auxiliar == 10)
                    {
                        Carac11.Text = "j";
                    }
                    else if (auxiliar == 11)
                    {
                        Carac11.Text = "k";
                    }
                    else if (auxiliar == 12)
                    {
                        Carac11.Text = "l";
                    }
                    else if (auxiliar == 13)
                    {
                        Carac11.Text = "m";
                    }
                    else if (auxiliar == 14)
                    {
                        Carac11.Text = "n";
                    }
                    else if (auxiliar == 15)
                    {
                        Carac11.Text = "o";
                    }
                    else if (auxiliar == 16)
                    {
                        Carac11.Text = "p";
                    }
                    else if (auxiliar == 17)
                    {
                        Carac11.Text = "q";
                    }
                    else if (auxiliar == 18)
                    {
                        Carac11.Text = "r";
                    }
                    else if (auxiliar == 19)
                    {
                        Carac11.Text = "s";
                    }
                    else if (auxiliar == 20)
                    {
                        Carac11.Text = "t";
                    }
                    else if (auxiliar == 21)
                    {
                        Carac11.Text = "u";
                    }
                    else if (auxiliar == 22)
                    {
                        Carac11.Text = "v";
                    }
                    else if (auxiliar == 23)
                    {
                        Carac11.Text = "w";
                    }
                    else if (auxiliar == 24)
                    {
                        Carac11.Text = "x";
                    }
                    else if (auxiliar == 25)
                    {
                        Carac11.Text = "y";
                    }
                    else if (auxiliar == 26)
                    {
                        Carac11.Text = "z";
                    }
                    else if (auxiliar == 27)
                    {
                        Carac11.Text = "A";
                    }
                    else if (auxiliar == 28)
                    {
                        Carac11.Text = "B";
                    }
                    else if (auxiliar == 29)
                    {
                        Carac11.Text = "C";
                    }
                    else if (auxiliar == 30)
                    {
                        Carac11.Text = "D";
                    }
                    else if (auxiliar == 31)
                    {
                        Carac11.Text = "E";
                    }
                    else if (auxiliar == 32)
                    {
                        Carac11.Text = "F";
                    }
                    else if (auxiliar == 33)
                    {
                        Carac11.Text = "G";
                    }
                    else if (auxiliar == 34)
                    {
                        Carac11.Text = "H";
                    }
                    else if (auxiliar == 35)
                    {
                        Carac11.Text = "I";
                    }
                    else if (auxiliar == 36)
                    {
                        Carac11.Text = "J";
                    }
                    else if (auxiliar == 37)
                    {
                        Carac11.Text = "K";
                    }
                    else if (auxiliar == 38)
                    {
                        Carac11.Text = "L";
                    }
                    else if (auxiliar == 39)
                    {
                        Carac11.Text = "M";
                    }
                    else if (auxiliar == 40)
                    {
                        Carac11.Text = "N";
                    }
                    else if (auxiliar == 41)
                    {
                        Carac11.Text = "O";
                    }
                    else if (auxiliar == 42)
                    {
                        Carac11.Text = "P";
                    }
                    else if (auxiliar == 43)
                    {
                        Carac11.Text = "Q";
                    }
                    else if (auxiliar == 44)
                    {
                        Carac11.Text = "R";
                    }
                    else if (auxiliar == 45)
                    {
                        Carac11.Text = "S";
                    }
                    else if (auxiliar == 46)
                    {
                        Carac11.Text = "T";
                    }
                    else if (auxiliar == 47)
                    {
                        Carac11.Text = "U";
                    }
                    else if (auxiliar == 48)
                    {
                        Carac11.Text = "V";
                    }
                    else if (auxiliar == 49)
                    {
                        Carac11.Text = "W";
                    }
                    else if (auxiliar == 50)
                    {
                        Carac11.Text = "X";
                    }
                    else if (auxiliar == 51)
                    {
                        Carac11.Text = "Y";
                    }
                    else if (auxiliar == 52)
                    {
                        Carac11.Text = "Z";
                    }
                }
                if (carac >= 12)
                {
                    auxiliar = senha.Next(1, 52);

                    Carac1.Visible = true;
                    Carac2.Visible = true;
                    Carac3.Visible = true;
                    Carac4.Visible = true;
                    Carac5.Visible = true;
                    Carac6.Visible = true;
                    Carac7.Visible = true;
                    Carac8.Visible = true;
                    Carac9.Visible = true;
                    Carac10.Visible = true;
                    Carac11.Visible = true;
                    Carac12.Visible = true;
                    Carac13.Visible = false;
                    Carac14.Visible = false;
                    Carac15.Visible = false;

                    if (auxiliar == 1)
                    {
                        Carac12.Text = "a";
                    }
                    else if (auxiliar == 2)
                    {
                        Carac12.Text = "b";
                    }
                    else if (auxiliar == 3)
                    {
                        Carac12.Text = "c";
                    }
                    else if (auxiliar == 4)
                    {
                        Carac12.Text = "d";
                    }
                    else if (auxiliar == 5)
                    {
                        Carac12.Text = "e";
                    }
                    else if (auxiliar == 6)
                    {
                        Carac12.Text = "f";
                    }
                    else if (auxiliar == 7)
                    {
                        Carac12.Text = "g";
                    }
                    else if (auxiliar == 8)
                    {
                        Carac12.Text = "h";
                    }
                    else if (auxiliar == 9)
                    {
                        Carac12.Text = "i";
                    }
                    else if (auxiliar == 10)
                    {
                        Carac12.Text = "j";
                    }
                    else if (auxiliar == 11)
                    {
                        Carac12.Text = "k";
                    }
                    else if (auxiliar == 12)
                    {
                        Carac12.Text = "l";
                    }
                    else if (auxiliar == 13)
                    {
                        Carac12.Text = "m";
                    }
                    else if (auxiliar == 14)
                    {
                        Carac12.Text = "n";
                    }
                    else if (auxiliar == 15)
                    {
                        Carac12.Text = "o";
                    }
                    else if (auxiliar == 16)
                    {
                        Carac12.Text = "p";
                    }
                    else if (auxiliar == 17)
                    {
                        Carac12.Text = "q";
                    }
                    else if (auxiliar == 18)
                    {
                        Carac12.Text = "r";
                    }
                    else if (auxiliar == 19)
                    {
                        Carac12.Text = "s";
                    }
                    else if (auxiliar == 20)
                    {
                        Carac12.Text = "t";
                    }
                    else if (auxiliar == 21)
                    {
                        Carac12.Text = "u";
                    }
                    else if (auxiliar == 22)
                    {
                        Carac12.Text = "v";
                    }
                    else if (auxiliar == 23)
                    {
                        Carac12.Text = "w";
                    }
                    else if (auxiliar == 24)
                    {
                        Carac12.Text = "x";
                    }
                    else if (auxiliar == 25)
                    {
                        Carac12.Text = "y";
                    }
                    else if (auxiliar == 26)
                    {
                        Carac12.Text = "z";
                    }
                    else if (auxiliar == 27)
                    {
                        Carac12.Text = "A";
                    }
                    else if (auxiliar == 28)
                    {
                        Carac12.Text = "B";
                    }
                    else if (auxiliar == 29)
                    {
                        Carac12.Text = "C";
                    }
                    else if (auxiliar == 30)
                    {
                        Carac12.Text = "D";
                    }
                    else if (auxiliar == 31)
                    {
                        Carac12.Text = "E";
                    }
                    else if (auxiliar == 32)
                    {
                        Carac12.Text = "F";
                    }
                    else if (auxiliar == 33)
                    {
                        Carac12.Text = "G";
                    }
                    else if (auxiliar == 34)
                    {
                        Carac12.Text = "H";
                    }
                    else if (auxiliar == 35)
                    {
                        Carac12.Text = "I";
                    }
                    else if (auxiliar == 36)
                    {
                        Carac12.Text = "J";
                    }
                    else if (auxiliar == 37)
                    {
                        Carac12.Text = "K";
                    }
                    else if (auxiliar == 38)
                    {
                        Carac12.Text = "L";
                    }
                    else if (auxiliar == 39)
                    {
                        Carac12.Text = "M";
                    }
                    else if (auxiliar == 40)
                    {
                        Carac12.Text = "N";
                    }
                    else if (auxiliar == 41)
                    {
                        Carac12.Text = "O";
                    }
                    else if (auxiliar == 42)
                    {
                        Carac12.Text = "P";
                    }
                    else if (auxiliar == 43)
                    {
                        Carac12.Text = "Q";
                    }
                    else if (auxiliar == 44)
                    {
                        Carac12.Text = "R";
                    }
                    else if (auxiliar == 45)
                    {
                        Carac12.Text = "S";
                    }
                    else if (auxiliar == 46)
                    {
                        Carac12.Text = "T";
                    }
                    else if (auxiliar == 47)
                    {
                        Carac12.Text = "U";
                    }
                    else if (auxiliar == 48)
                    {
                        Carac12.Text = "V";
                    }
                    else if (auxiliar == 49)
                    {
                        Carac12.Text = "W";
                    }
                    else if (auxiliar == 50)
                    {
                        Carac12.Text = "X";
                    }
                    else if (auxiliar == 51)
                    {
                        Carac12.Text = "Y";
                    }
                    else if (auxiliar == 52)
                    {
                        Carac12.Text = "Z";
                    }
                }
                if (carac >= 13)
                {
                    auxiliar = senha.Next(1, 52);

                    Carac1.Visible = true;
                    Carac2.Visible = true;
                    Carac3.Visible = true;
                    Carac4.Visible = true;
                    Carac5.Visible = true;
                    Carac6.Visible = true;
                    Carac7.Visible = true;
                    Carac8.Visible = true;
                    Carac9.Visible = true;
                    Carac10.Visible = true;
                    Carac11.Visible = true;
                    Carac12.Visible = true;
                    Carac13.Visible = true;
                    Carac14.Visible = false;
                    Carac15.Visible = false;

                    if (auxiliar == 1)
                    {
                        Carac13.Text = "a";
                    }
                    else if (auxiliar == 2)
                    {
                        Carac13.Text = "b";
                    }
                    else if (auxiliar == 3)
                    {
                        Carac13.Text = "c";
                    }
                    else if (auxiliar == 4)
                    {
                        Carac13.Text = "d";
                    }
                    else if (auxiliar == 5)
                    {
                        Carac13.Text = "e";
                    }
                    else if (auxiliar == 6)
                    {
                        Carac13.Text = "f";
                    }
                    else if (auxiliar == 7)
                    {
                        Carac13.Text = "g";
                    }
                    else if (auxiliar == 8)
                    {
                        Carac13.Text = "h";
                    }
                    else if (auxiliar == 9)
                    {
                        Carac13.Text = "i";
                    }
                    else if (auxiliar == 10)
                    {
                        Carac13.Text = "j";
                    }
                    else if (auxiliar == 11)
                    {
                        Carac13.Text = "k";
                    }
                    else if (auxiliar == 12)
                    {
                        Carac13.Text = "l";
                    }
                    else if (auxiliar == 13)
                    {
                        Carac13.Text = "m";
                    }
                    else if (auxiliar == 14)
                    {
                        Carac13.Text = "n";
                    }
                    else if (auxiliar == 15)
                    {
                        Carac13.Text = "o";
                    }
                    else if (auxiliar == 16)
                    {
                        Carac13.Text = "p";
                    }
                    else if (auxiliar == 17)
                    {
                        Carac13.Text = "q";
                    }
                    else if (auxiliar == 18)
                    {
                        Carac13.Text = "r";
                    }
                    else if (auxiliar == 19)
                    {
                        Carac13.Text = "s";
                    }
                    else if (auxiliar == 20)
                    {
                        Carac13.Text = "t";
                    }
                    else if (auxiliar == 21)
                    {
                        Carac13.Text = "u";
                    }
                    else if (auxiliar == 22)
                    {
                        Carac13.Text = "v";
                    }
                    else if (auxiliar == 23)
                    {
                        Carac13.Text = "w";
                    }
                    else if (auxiliar == 24)
                    {
                        Carac13.Text = "x";
                    }
                    else if (auxiliar == 25)
                    {
                        Carac13.Text = "y";
                    }
                    else if (auxiliar == 26)
                    {
                        Carac13.Text = "z";
                    }
                    else if (auxiliar == 27)
                    {
                        Carac13.Text = "A";
                    }
                    else if (auxiliar == 28)
                    {
                        Carac13.Text = "B";
                    }
                    else if (auxiliar == 29)
                    {
                        Carac13.Text = "C";
                    }
                    else if (auxiliar == 30)
                    {
                        Carac13.Text = "D";
                    }
                    else if (auxiliar == 31)
                    {
                        Carac13.Text = "E";
                    }
                    else if (auxiliar == 32)
                    {
                        Carac13.Text = "F";
                    }
                    else if (auxiliar == 33)
                    {
                        Carac13.Text = "G";
                    }
                    else if (auxiliar == 34)
                    {
                        Carac13.Text = "H";
                    }
                    else if (auxiliar == 35)
                    {
                        Carac13.Text = "I";
                    }
                    else if (auxiliar == 36)
                    {
                        Carac13.Text = "J";
                    }
                    else if (auxiliar == 37)
                    {
                        Carac13.Text = "K";
                    }
                    else if (auxiliar == 38)
                    {
                        Carac13.Text = "L";
                    }
                    else if (auxiliar == 39)
                    {
                        Carac13.Text = "M";
                    }
                    else if (auxiliar == 40)
                    {
                        Carac13.Text = "N";
                    }
                    else if (auxiliar == 41)
                    {
                        Carac13.Text = "O";
                    }
                    else if (auxiliar == 42)
                    {
                        Carac13.Text = "P";
                    }
                    else if (auxiliar == 43)
                    {
                        Carac13.Text = "Q";
                    }
                    else if (auxiliar == 44)
                    {
                        Carac13.Text = "R";
                    }
                    else if (auxiliar == 45)
                    {
                        Carac13.Text = "S";
                    }
                    else if (auxiliar == 46)
                    {
                        Carac13.Text = "T";
                    }
                    else if (auxiliar == 47)
                    {
                        Carac13.Text = "U";
                    }
                    else if (auxiliar == 48)
                    {
                        Carac13.Text = "V";
                    }
                    else if (auxiliar == 49)
                    {
                        Carac13.Text = "W";
                    }
                    else if (auxiliar == 50)
                    {
                        Carac13.Text = "X";
                    }
                    else if (auxiliar == 51)
                    {
                        Carac13.Text = "Y";
                    }
                    else if (auxiliar == 52)
                    {
                        Carac13.Text = "Z";
                    }
                }
                if (carac >= 14)
                {
                    auxiliar = senha.Next(1, 52);

                    Carac1.Visible = true;
                    Carac2.Visible = true;
                    Carac3.Visible = true;
                    Carac4.Visible = true;
                    Carac5.Visible = true;
                    Carac6.Visible = true;
                    Carac7.Visible = true;
                    Carac8.Visible = true;
                    Carac9.Visible = true;
                    Carac10.Visible = true;
                    Carac11.Visible = true;
                    Carac12.Visible = true;
                    Carac13.Visible = true;
                    Carac14.Visible = true;
                    Carac15.Visible = false;

                    if (auxiliar == 1)
                    {
                        Carac14.Text = "a";
                    }
                    else if (auxiliar == 2)
                    {
                        Carac14.Text = "b";
                    }
                    else if (auxiliar == 3)
                    {
                        Carac14.Text = "c";
                    }
                    else if (auxiliar == 4)
                    {
                        Carac14.Text = "d";
                    }
                    else if (auxiliar == 5)
                    {
                        Carac14.Text = "e";
                    }
                    else if (auxiliar == 6)
                    {
                        Carac14.Text = "f";
                    }
                    else if (auxiliar == 7)
                    {
                        Carac14.Text = "g";
                    }
                    else if (auxiliar == 8)
                    {
                        Carac14.Text = "h";
                    }
                    else if (auxiliar == 9)
                    {
                        Carac14.Text = "i";
                    }
                    else if (auxiliar == 10)
                    {
                        Carac14.Text = "j";
                    }
                    else if (auxiliar == 11)
                    {
                        Carac14.Text = "k";
                    }
                    else if (auxiliar == 12)
                    {
                        Carac14.Text = "l";
                    }
                    else if (auxiliar == 13)
                    {
                        Carac14.Text = "m";
                    }
                    else if (auxiliar == 14)
                    {
                        Carac14.Text = "n";
                    }
                    else if (auxiliar == 15)
                    {
                        Carac14.Text = "o";
                    }
                    else if (auxiliar == 16)
                    {
                        Carac14.Text = "p";
                    }
                    else if (auxiliar == 17)
                    {
                        Carac14.Text = "q";
                    }
                    else if (auxiliar == 18)
                    {
                        Carac14.Text = "r";
                    }
                    else if (auxiliar == 19)
                    {
                        Carac14.Text = "s";
                    }
                    else if (auxiliar == 20)
                    {
                        Carac14.Text = "t";
                    }
                    else if (auxiliar == 21)
                    {
                        Carac14.Text = "u";
                    }
                    else if (auxiliar == 22)
                    {
                        Carac14.Text = "v";
                    }
                    else if (auxiliar == 23)
                    {
                        Carac14.Text = "w";
                    }
                    else if (auxiliar == 24)
                    {
                        Carac14.Text = "x";
                    }
                    else if (auxiliar == 25)
                    {
                        Carac14.Text = "y";
                    }
                    else if (auxiliar == 26)
                    {
                        Carac14.Text = "z";
                    }
                    else if (auxiliar == 27)
                    {
                        Carac14.Text = "A";
                    }
                    else if (auxiliar == 28)
                    {
                        Carac14.Text = "B";
                    }
                    else if (auxiliar == 29)
                    {
                        Carac14.Text = "C";
                    }
                    else if (auxiliar == 30)
                    {
                        Carac14.Text = "D";
                    }
                    else if (auxiliar == 31)
                    {
                        Carac14.Text = "E";
                    }
                    else if (auxiliar == 32)
                    {
                        Carac14.Text = "F";
                    }
                    else if (auxiliar == 33)
                    {
                        Carac14.Text = "G";
                    }
                    else if (auxiliar == 34)
                    {
                        Carac14.Text = "H";
                    }
                    else if (auxiliar == 35)
                    {
                        Carac14.Text = "I";
                    }
                    else if (auxiliar == 36)
                    {
                        Carac14.Text = "J";
                    }
                    else if (auxiliar == 37)
                    {
                        Carac14.Text = "K";
                    }
                    else if (auxiliar == 38)
                    {
                        Carac14.Text = "L";
                    }
                    else if (auxiliar == 39)
                    {
                        Carac14.Text = "M";
                    }
                    else if (auxiliar == 40)
                    {
                        Carac14.Text = "N";
                    }
                    else if (auxiliar == 41)
                    {
                        Carac14.Text = "O";
                    }
                    else if (auxiliar == 42)
                    {
                        Carac14.Text = "P";
                    }
                    else if (auxiliar == 43)
                    {
                        Carac14.Text = "Q";
                    }
                    else if (auxiliar == 44)
                    {
                        Carac14.Text = "R";
                    }
                    else if (auxiliar == 45)
                    {
                        Carac14.Text = "S";
                    }
                    else if (auxiliar == 46)
                    {
                        Carac14.Text = "T";
                    }
                    else if (auxiliar == 47)
                    {
                        Carac14.Text = "U";
                    }
                    else if (auxiliar == 48)
                    {
                        Carac14.Text = "V";
                    }
                    else if (auxiliar == 49)
                    {
                        Carac14.Text = "W";
                    }
                    else if (auxiliar == 50)
                    {
                        Carac14.Text = "X";
                    }
                    else if (auxiliar == 51)
                    {
                        Carac14.Text = "Y";
                    }
                    else if (auxiliar == 52)
                    {
                        Carac14.Text = "Z";
                    }
                }
                if (carac >= 15)
                {
                    auxiliar = senha.Next(1, 52);

                    Carac1.Visible = true;
                    Carac2.Visible = true;
                    Carac3.Visible = true;
                    Carac4.Visible = true;
                    Carac5.Visible = true;
                    Carac6.Visible = true;
                    Carac7.Visible = true;
                    Carac8.Visible = true;
                    Carac9.Visible = true;
                    Carac10.Visible = true;
                    Carac11.Visible = true;
                    Carac12.Visible = true;
                    Carac13.Visible = true;
                    Carac14.Visible = true;
                    Carac15.Visible = true;

                    if (auxiliar == 1)
                    {
                        Carac15.Text = "a";
                    }
                    else if (auxiliar == 2)
                    {
                        Carac15.Text = "b";
                    }
                    else if (auxiliar == 3)
                    {
                        Carac15.Text = "c";
                    }
                    else if (auxiliar == 4)
                    {
                        Carac15.Text = "d";
                    }
                    else if (auxiliar == 5)
                    {
                        Carac15.Text = "e";
                    }
                    else if (auxiliar == 6)
                    {
                        Carac15.Text = "f";
                    }
                    else if (auxiliar == 7)
                    {
                        Carac15.Text = "g";
                    }
                    else if (auxiliar == 8)
                    {
                        Carac15.Text = "h";
                    }
                    else if (auxiliar == 9)
                    {
                        Carac15.Text = "i";
                    }
                    else if (auxiliar == 10)
                    {
                        Carac15.Text = "j";
                    }
                    else if (auxiliar == 11)
                    {
                        Carac15.Text = "k";
                    }
                    else if (auxiliar == 12)
                    {
                        Carac15.Text = "l";
                    }
                    else if (auxiliar == 13)
                    {
                        Carac15.Text = "m";
                    }
                    else if (auxiliar == 14)
                    {
                        Carac15.Text = "n";
                    }
                    else if (auxiliar == 15)
                    {
                        Carac15.Text = "o";
                    }
                    else if (auxiliar == 16)
                    {
                        Carac15.Text = "p";
                    }
                    else if (auxiliar == 17)
                    {
                        Carac15.Text = "q";
                    }
                    else if (auxiliar == 18)
                    {
                        Carac15.Text = "r";
                    }
                    else if (auxiliar == 19)
                    {
                        Carac15.Text = "s";
                    }
                    else if (auxiliar == 20)
                    {
                        Carac15.Text = "t";
                    }
                    else if (auxiliar == 21)
                    {
                        Carac15.Text = "u";
                    }
                    else if (auxiliar == 22)
                    {
                        Carac15.Text = "v";
                    }
                    else if (auxiliar == 23)
                    {
                        Carac15.Text = "w";
                    }
                    else if (auxiliar == 24)
                    {
                        Carac15.Text = "x";
                    }
                    else if (auxiliar == 25)
                    {
                        Carac15.Text = "y";
                    }
                    else if (auxiliar == 26)
                    {
                        Carac15.Text = "z";
                    }
                    else if (auxiliar == 27)
                    {
                        Carac15.Text = "A";
                    }
                    else if (auxiliar == 28)
                    {
                        Carac15.Text = "B";
                    }
                    else if (auxiliar == 29)
                    {
                        Carac15.Text = "C";
                    }
                    else if (auxiliar == 30)
                    {
                        Carac15.Text = "D";
                    }
                    else if (auxiliar == 31)
                    {
                        Carac15.Text = "E";
                    }
                    else if (auxiliar == 32)
                    {
                        Carac15.Text = "F";
                    }
                    else if (auxiliar == 33)
                    {
                        Carac15.Text = "G";
                    }
                    else if (auxiliar == 34)
                    {
                        Carac15.Text = "H";
                    }
                    else if (auxiliar == 35)
                    {
                        Carac15.Text = "I";
                    }
                    else if (auxiliar == 36)
                    {
                        Carac15.Text = "J";
                    }
                    else if (auxiliar == 37)
                    {
                        Carac15.Text = "K";
                    }
                    else if (auxiliar == 38)
                    {
                        Carac15.Text = "L";
                    }
                    else if (auxiliar == 39)
                    {
                        Carac15.Text = "M";
                    }
                    else if (auxiliar == 40)
                    {
                        Carac15.Text = "N";
                    }
                    else if (auxiliar == 41)
                    {
                        Carac15.Text = "O";
                    }
                    else if (auxiliar == 42)
                    {
                        Carac15.Text = "P";
                    }
                    else if (auxiliar == 43)
                    {
                        Carac15.Text = "Q";
                    }
                    else if (auxiliar == 44)
                    {
                        Carac15.Text = "R";
                    }
                    else if (auxiliar == 45)
                    {
                        Carac15.Text = "S";
                    }
                    else if (auxiliar == 46)
                    {
                        Carac15.Text = "T";
                    }
                    else if (auxiliar == 47)
                    {
                        Carac15.Text = "U";
                    }
                    else if (auxiliar == 48)
                    {
                        Carac15.Text = "V";
                    }
                    else if (auxiliar == 49)
                    {
                        Carac15.Text = "W";
                    }
                    else if (auxiliar == 50)
                    {
                        Carac15.Text = "X";
                    }
                    else if (auxiliar == 51)
                    {
                        Carac15.Text = "Y";
                    }
                    else if (auxiliar == 52)
                    {
                        Carac15.Text = "Z";
                    }
                }
                //52
            }

            else if (letra == 1 && mudacar == 1 && num == 1)
            {
                if (carac >= 1)
                {
                    auxiliar = senha.Next(1, 62);

                    Carac1.Visible = true;
                    Carac2.Visible = false;
                    Carac3.Visible = false;
                    Carac4.Visible = false;
                    Carac5.Visible = false;
                    Carac6.Visible = false;
                    Carac7.Visible = false;
                    Carac8.Visible = false;
                    Carac9.Visible = false;
                    Carac10.Visible = false;
                    Carac11.Visible = false;
                    Carac12.Visible = false;
                    Carac13.Visible = false;
                    Carac14.Visible = false;
                    Carac15.Visible = false;

                    if (auxiliar == 1)
                    {
                        Carac1.Text = "a";
                    }
                    else if (auxiliar == 2)
                    {
                        Carac1.Text = "b";
                    }
                    else if (auxiliar == 3)
                    {
                        Carac1.Text = "c";
                    }
                    else if (auxiliar == 4)
                    {
                        Carac1.Text = "d";
                    }
                    else if (auxiliar == 5)
                    {
                        Carac1.Text = "e";
                    }
                    else if (auxiliar == 6)
                    {
                        Carac1.Text = "f";
                    }
                    else if (auxiliar == 7)
                    {
                        Carac1.Text = "g";
                    }
                    else if (auxiliar == 8)
                    {
                        Carac1.Text = "h";
                    }
                    else if (auxiliar == 9)
                    {
                        Carac1.Text = "i";
                    }
                    else if (auxiliar == 10)
                    {
                        Carac1.Text = "j";
                    }
                    else if (auxiliar == 11)
                    {
                        Carac1.Text = "k";
                    }
                    else if (auxiliar == 12)
                    {
                        Carac1.Text = "l";
                    }
                    else if (auxiliar == 13)
                    {
                        Carac1.Text = "m";
                    }
                    else if (auxiliar == 14)
                    {
                        Carac1.Text = "n";
                    }
                    else if (auxiliar == 15)
                    {
                        Carac1.Text = "o";
                    }
                    else if (auxiliar == 16)
                    {
                        Carac1.Text = "p";
                    }
                    else if (auxiliar == 17)
                    {
                        Carac1.Text = "q";
                    }
                    else if (auxiliar == 18)
                    {
                        Carac1.Text = "r";
                    }
                    else if (auxiliar == 19)
                    {
                        Carac1.Text = "s";
                    }
                    else if (auxiliar == 20)
                    {
                        Carac1.Text = "t";
                    }
                    else if (auxiliar == 21)
                    {
                        Carac1.Text = "u";
                    }
                    else if (auxiliar == 22)
                    {
                        Carac1.Text = "v";
                    }
                    else if (auxiliar == 23)
                    {
                        Carac1.Text = "w";
                    }
                    else if (auxiliar == 24)
                    {
                        Carac1.Text = "x";
                    }
                    else if (auxiliar == 25)
                    {
                        Carac1.Text = "y";
                    }
                    else if (auxiliar == 26)
                    {
                        Carac1.Text = "z";
                    }
                    else if (auxiliar == 27)
                    {
                        Carac1.Text = "A";
                    }
                    else if (auxiliar == 28)
                    {
                        Carac1.Text = "B";
                    }
                    else if (auxiliar == 29)
                    {
                        Carac1.Text = "C";
                    }
                    else if (auxiliar == 30)
                    {
                        Carac1.Text = "D";
                    }
                    else if (auxiliar == 31)
                    {
                        Carac1.Text = "E";
                    }
                    else if (auxiliar == 32)
                    {
                        Carac1.Text = "F";
                    }
                    else if (auxiliar == 33)
                    {
                        Carac1.Text = "G";
                    }
                    else if (auxiliar == 34)
                    {
                        Carac1.Text = "H";
                    }
                    else if (auxiliar == 35)
                    {
                        Carac1.Text = "I";
                    }
                    else if (auxiliar == 36)
                    {
                        Carac1.Text = "J";
                    }
                    else if (auxiliar == 37)
                    {
                        Carac1.Text = "K";
                    }
                    else if (auxiliar == 38)
                    {
                        Carac1.Text = "L";
                    }
                    else if (auxiliar == 39)
                    {
                        Carac1.Text = "M";
                    }
                    else if (auxiliar == 40)
                    {
                        Carac1.Text = "N";
                    }
                    else if (auxiliar == 41)
                    {
                        Carac1.Text = "O";
                    }
                    else if (auxiliar == 42)
                    {
                        Carac1.Text = "P";
                    }
                    else if (auxiliar == 43)
                    {
                        Carac1.Text = "Q";
                    }
                    else if (auxiliar == 44)
                    {
                        Carac1.Text = "R";
                    }
                    else if (auxiliar == 45)
                    {
                        Carac1.Text = "S";
                    }
                    else if (auxiliar == 46)
                    {
                        Carac1.Text = "T";
                    }
                    else if (auxiliar == 47)
                    {
                        Carac1.Text = "U";
                    }
                    else if (auxiliar == 48)
                    {
                        Carac1.Text = "V";
                    }
                    else if (auxiliar == 49)
                    {
                        Carac1.Text = "W";
                    }
                    else if (auxiliar == 50)
                    {
                        Carac1.Text = "X";
                    }
                    else if (auxiliar == 51)
                    {
                        Carac1.Text = "Y";
                    }
                    else if (auxiliar == 52)
                    {
                        Carac1.Text = "Z";
                    }
                    else if (auxiliar == 53)
                    {
                        Carac1.Text = "0";
                    }
                    else if (auxiliar == 54)
                    {
                        Carac1.Text = "1";
                    }
                    else if (auxiliar == 55)
                    {
                        Carac1.Text = "2";
                    }
                    else if (auxiliar == 56)
                    {
                        Carac1.Text = "3";
                    }
                    else if (auxiliar == 57)
                    {
                        Carac1.Text = "4";
                    }
                    else if (auxiliar == 58)
                    {
                        Carac1.Text = "5";
                    }
                    else if (auxiliar == 59)
                    {
                        Carac1.Text = "6";
                    }
                    else if (auxiliar == 60)
                    {
                        Carac1.Text = "7";
                    }
                    else if (auxiliar == 61)
                    {
                        Carac1.Text = "8";
                    }
                    else if (auxiliar == 62)
                    {
                        Carac1.Text = "9";
                    }
                }
                if (carac >= 2)
                {
                    auxiliar = senha.Next(1, 62);

                    Carac1.Visible = true;
                    Carac2.Visible = true;
                    Carac3.Visible = false;
                    Carac4.Visible = false;
                    Carac5.Visible = false;
                    Carac6.Visible = false;
                    Carac7.Visible = false;
                    Carac8.Visible = false;
                    Carac9.Visible = false;
                    Carac10.Visible = false;
                    Carac11.Visible = false;
                    Carac12.Visible = false;
                    Carac13.Visible = false;
                    Carac14.Visible = false;
                    Carac15.Visible = false;

                    if (auxiliar == 1)
                    {
                        Carac2.Text = "a";
                    }
                    else if (auxiliar == 2)
                    {
                        Carac2.Text = "b";
                    }
                    else if (auxiliar == 3)
                    {
                        Carac2.Text = "c";
                    }
                    else if (auxiliar == 4)
                    {
                        Carac2.Text = "d";
                    }
                    else if (auxiliar == 5)
                    {
                        Carac2.Text = "e";
                    }
                    else if (auxiliar == 6)
                    {
                        Carac2.Text = "f";
                    }
                    else if (auxiliar == 7)
                    {
                        Carac2.Text = "g";
                    }
                    else if (auxiliar == 8)
                    {
                        Carac2.Text = "h";
                    }
                    else if (auxiliar == 9)
                    {
                        Carac2.Text = "i";
                    }
                    else if (auxiliar == 10)
                    {
                        Carac2.Text = "j";
                    }
                    else if (auxiliar == 11)
                    {
                        Carac2.Text = "k";
                    }
                    else if (auxiliar == 12)
                    {
                        Carac2.Text = "l";
                    }
                    else if (auxiliar == 13)
                    {
                        Carac2.Text = "m";
                    }
                    else if (auxiliar == 14)
                    {
                        Carac2.Text = "n";
                    }
                    else if (auxiliar == 15)
                    {
                        Carac2.Text = "o";
                    }
                    else if (auxiliar == 16)
                    {
                        Carac2.Text = "p";
                    }
                    else if (auxiliar == 17)
                    {
                        Carac2.Text = "q";
                    }
                    else if (auxiliar == 18)
                    {
                        Carac2.Text = "r";
                    }
                    else if (auxiliar == 19)
                    {
                        Carac2.Text = "s";
                    }
                    else if (auxiliar == 20)
                    {
                        Carac2.Text = "t";
                    }
                    else if (auxiliar == 21)
                    {
                        Carac2.Text = "u";
                    }
                    else if (auxiliar == 22)
                    {
                        Carac2.Text = "v";
                    }
                    else if (auxiliar == 23)
                    {
                        Carac2.Text = "w";
                    }
                    else if (auxiliar == 24)
                    {
                        Carac2.Text = "x";
                    }
                    else if (auxiliar == 25)
                    {
                        Carac2.Text = "y";
                    }
                    else if (auxiliar == 26)
                    {
                        Carac2.Text = "z";
                    }
                    else if (auxiliar == 27)
                    {
                        Carac2.Text = "A";
                    }
                    else if (auxiliar == 28)
                    {
                        Carac2.Text = "B";
                    }
                    else if (auxiliar == 29)
                    {
                        Carac2.Text = "C";
                    }
                    else if (auxiliar == 30)
                    {
                        Carac2.Text = "D";
                    }
                    else if (auxiliar == 31)
                    {
                        Carac2.Text = "E";
                    }
                    else if (auxiliar == 32)
                    {
                        Carac2.Text = "F";
                    }
                    else if (auxiliar == 33)
                    {
                        Carac2.Text = "G";
                    }
                    else if (auxiliar == 34)
                    {
                        Carac2.Text = "H";
                    }
                    else if (auxiliar == 35)
                    {
                        Carac2.Text = "I";
                    }
                    else if (auxiliar == 36)
                    {
                        Carac2.Text = "J";
                    }
                    else if (auxiliar == 37)
                    {
                        Carac2.Text = "K";
                    }
                    else if (auxiliar == 38)
                    {
                        Carac2.Text = "L";
                    }
                    else if (auxiliar == 39)
                    {
                        Carac2.Text = "M";
                    }
                    else if (auxiliar == 40)
                    {
                        Carac2.Text = "N";
                    }
                    else if (auxiliar == 41)
                    {
                        Carac2.Text = "O";
                    }
                    else if (auxiliar == 42)
                    {
                        Carac2.Text = "P";
                    }
                    else if (auxiliar == 43)
                    {
                        Carac2.Text = "Q";
                    }
                    else if (auxiliar == 44)
                    {
                        Carac2.Text = "R";
                    }
                    else if (auxiliar == 45)
                    {
                        Carac2.Text = "S";
                    }
                    else if (auxiliar == 46)
                    {
                        Carac2.Text = "T";
                    }
                    else if (auxiliar == 47)
                    {
                        Carac2.Text = "U";
                    }
                    else if (auxiliar == 48)
                    {
                        Carac2.Text = "V";
                    }
                    else if (auxiliar == 49)
                    {
                        Carac2.Text = "W";
                    }
                    else if (auxiliar == 50)
                    {
                        Carac2.Text = "X";
                    }
                    else if (auxiliar == 51)
                    {
                        Carac2.Text = "Y";
                    }
                    else if (auxiliar == 52)
                    {
                        Carac2.Text = "Z";
                    }
                    else if (auxiliar == 53)
                    {
                        Carac2.Text = "0";
                    }
                    else if (auxiliar == 54)
                    {
                        Carac2.Text = "1";
                    }
                    else if (auxiliar == 55)
                    {
                        Carac2.Text = "2";
                    }
                    else if (auxiliar == 56)
                    {
                        Carac2.Text = "3";
                    }
                    else if (auxiliar == 57)
                    {
                        Carac2.Text = "4";
                    }
                    else if (auxiliar == 58)
                    {
                        Carac2.Text = "5";
                    }
                    else if (auxiliar == 59)
                    {
                        Carac2.Text = "6";
                    }
                    else if (auxiliar == 60)
                    {
                        Carac2.Text = "7";
                    }
                    else if (auxiliar == 61)
                    {
                        Carac2.Text = "8";
                    }
                    else if (auxiliar == 62)
                    {
                        Carac2.Text = "9";
                    }
                }
                if (carac >= 3)
                {
                    auxiliar = senha.Next(1, 62);

                    Carac1.Visible = true;
                    Carac2.Visible = true;
                    Carac3.Visible = true;
                    Carac4.Visible = false;
                    Carac5.Visible = false;
                    Carac6.Visible = false;
                    Carac7.Visible = false;
                    Carac8.Visible = false;
                    Carac9.Visible = false;
                    Carac10.Visible = false;
                    Carac11.Visible = false;
                    Carac12.Visible = false;
                    Carac13.Visible = false;
                    Carac14.Visible = false;
                    Carac15.Visible = false;

                    if (auxiliar == 1)
                    {
                        Carac3.Text = "a";
                    }
                    else if (auxiliar == 2)
                    {
                        Carac3.Text = "b";
                    }
                    else if (auxiliar == 3)
                    {
                        Carac3.Text = "c";
                    }
                    else if (auxiliar == 4)
                    {
                        Carac3.Text = "d";
                    }
                    else if (auxiliar == 5)
                    {
                        Carac3.Text = "e";
                    }
                    else if (auxiliar == 6)
                    {
                        Carac3.Text = "f";
                    }
                    else if (auxiliar == 7)
                    {
                        Carac3.Text = "g";
                    }
                    else if (auxiliar == 8)
                    {
                        Carac3.Text = "h";
                    }
                    else if (auxiliar == 9)
                    {
                        Carac3.Text = "i";
                    }
                    else if (auxiliar == 10)
                    {
                        Carac3.Text = "j";
                    }
                    else if (auxiliar == 11)
                    {
                        Carac3.Text = "k";
                    }
                    else if (auxiliar == 12)
                    {
                        Carac3.Text = "l";
                    }
                    else if (auxiliar == 13)
                    {
                        Carac3.Text = "m";
                    }
                    else if (auxiliar == 14)
                    {
                        Carac3.Text = "n";
                    }
                    else if (auxiliar == 15)
                    {
                        Carac3.Text = "o";
                    }
                    else if (auxiliar == 16)
                    {
                        Carac3.Text = "p";
                    }
                    else if (auxiliar == 17)
                    {
                        Carac3.Text = "q";
                    }
                    else if (auxiliar == 18)
                    {
                        Carac3.Text = "r";
                    }
                    else if (auxiliar == 19)
                    {
                        Carac3.Text = "s";
                    }
                    else if (auxiliar == 20)
                    {
                        Carac3.Text = "t";
                    }
                    else if (auxiliar == 21)
                    {
                        Carac3.Text = "u";
                    }
                    else if (auxiliar == 22)
                    {
                        Carac3.Text = "v";
                    }
                    else if (auxiliar == 23)
                    {
                        Carac3.Text = "w";
                    }
                    else if (auxiliar == 24)
                    {
                        Carac3.Text = "x";
                    }
                    else if (auxiliar == 25)
                    {
                        Carac3.Text = "y";
                    }
                    else if (auxiliar == 26)
                    {
                        Carac3.Text = "z";
                    }
                    else if (auxiliar == 27)
                    {
                        Carac3.Text = "A";
                    }
                    else if (auxiliar == 28)
                    {
                        Carac3.Text = "B";
                    }
                    else if (auxiliar == 29)
                    {
                        Carac3.Text = "C";
                    }
                    else if (auxiliar == 30)
                    {
                        Carac3.Text = "D";
                    }
                    else if (auxiliar == 31)
                    {
                        Carac3.Text = "E";
                    }
                    else if (auxiliar == 32)
                    {
                        Carac3.Text = "F";
                    }
                    else if (auxiliar == 33)
                    {
                        Carac3.Text = "G";
                    }
                    else if (auxiliar == 34)
                    {
                        Carac3.Text = "H";
                    }
                    else if (auxiliar == 35)
                    {
                        Carac3.Text = "I";
                    }
                    else if (auxiliar == 36)
                    {
                        Carac3.Text = "J";
                    }
                    else if (auxiliar == 37)
                    {
                        Carac3.Text = "K";
                    }
                    else if (auxiliar == 38)
                    {
                        Carac3.Text = "L";
                    }
                    else if (auxiliar == 39)
                    {
                        Carac3.Text = "M";
                    }
                    else if (auxiliar == 40)
                    {
                        Carac3.Text = "N";
                    }
                    else if (auxiliar == 41)
                    {
                        Carac3.Text = "O";
                    }
                    else if (auxiliar == 42)
                    {
                        Carac3.Text = "P";
                    }
                    else if (auxiliar == 43)
                    {
                        Carac3.Text = "Q";
                    }
                    else if (auxiliar == 44)
                    {
                        Carac3.Text = "R";
                    }
                    else if (auxiliar == 45)
                    {
                        Carac3.Text = "S";
                    }
                    else if (auxiliar == 46)
                    {
                        Carac3.Text = "T";
                    }
                    else if (auxiliar == 47)
                    {
                        Carac3.Text = "U";
                    }
                    else if (auxiliar == 48)
                    {
                        Carac3.Text = "V";
                    }
                    else if (auxiliar == 49)
                    {
                        Carac3.Text = "W";
                    }
                    else if (auxiliar == 50)
                    {
                        Carac3.Text = "X";
                    }
                    else if (auxiliar == 51)
                    {
                        Carac3.Text = "Y";
                    }
                    else if (auxiliar == 52)
                    {
                        Carac3.Text = "Z";
                    }
                    else if (auxiliar == 53)
                    {
                        Carac3.Text = "0";
                    }
                    else if (auxiliar == 54)
                    {
                        Carac3.Text = "1";
                    }
                    else if (auxiliar == 55)
                    {
                        Carac3.Text = "2";
                    }
                    else if (auxiliar == 56)
                    {
                        Carac3.Text = "3";
                    }
                    else if (auxiliar == 57)
                    {
                        Carac3.Text = "4";
                    }
                    else if (auxiliar == 58)
                    {
                        Carac3.Text = "5";
                    }
                    else if (auxiliar == 59)
                    {
                        Carac3.Text = "6";
                    }
                    else if (auxiliar == 60)
                    {
                        Carac3.Text = "7";
                    }
                    else if (auxiliar == 61)
                    {
                        Carac3.Text = "8";
                    }
                    else if (auxiliar == 62)
                    {
                        Carac3.Text = "9";
                    }
                }
                if (carac >= 4)
                {
                    auxiliar = senha.Next(1, 62);

                    Carac1.Visible = true;
                    Carac2.Visible = true;
                    Carac3.Visible = true;
                    Carac4.Visible = true;
                    Carac5.Visible = false;
                    Carac6.Visible = false;
                    Carac7.Visible = false;
                    Carac8.Visible = false;
                    Carac9.Visible = false;
                    Carac10.Visible = false;
                    Carac11.Visible = false;
                    Carac12.Visible = false;
                    Carac13.Visible = false;
                    Carac14.Visible = false;
                    Carac15.Visible = false;

                    if (auxiliar == 1)
                    {
                        Carac4.Text = "a";
                    }
                    else if (auxiliar == 2)
                    {
                        Carac4.Text = "b";
                    }
                    else if (auxiliar == 3)
                    {
                        Carac4.Text = "c";
                    }
                    else if (auxiliar == 4)
                    {
                        Carac4.Text = "d";
                    }
                    else if (auxiliar == 5)
                    {
                        Carac4.Text = "e";
                    }
                    else if (auxiliar == 6)
                    {
                        Carac4.Text = "f";
                    }
                    else if (auxiliar == 7)
                    {
                        Carac4.Text = "g";
                    }
                    else if (auxiliar == 8)
                    {
                        Carac4.Text = "h";
                    }
                    else if (auxiliar == 9)
                    {
                        Carac4.Text = "i";
                    }
                    else if (auxiliar == 10)
                    {
                        Carac4.Text = "j";
                    }
                    else if (auxiliar == 11)
                    {
                        Carac4.Text = "k";
                    }
                    else if (auxiliar == 12)
                    {
                        Carac4.Text = "l";
                    }
                    else if (auxiliar == 13)
                    {
                        Carac4.Text = "m";
                    }
                    else if (auxiliar == 14)
                    {
                        Carac4.Text = "n";
                    }
                    else if (auxiliar == 15)
                    {
                        Carac4.Text = "o";
                    }
                    else if (auxiliar == 16)
                    {
                        Carac4.Text = "p";
                    }
                    else if (auxiliar == 17)
                    {
                        Carac4.Text = "q";
                    }
                    else if (auxiliar == 18)
                    {
                        Carac4.Text = "r";
                    }
                    else if (auxiliar == 19)
                    {
                        Carac4.Text = "s";
                    }
                    else if (auxiliar == 20)
                    {
                        Carac4.Text = "t";
                    }
                    else if (auxiliar == 21)
                    {
                        Carac4.Text = "u";
                    }
                    else if (auxiliar == 22)
                    {
                        Carac4.Text = "v";
                    }
                    else if (auxiliar == 23)
                    {
                        Carac4.Text = "w";
                    }
                    else if (auxiliar == 24)
                    {
                        Carac4.Text = "x";
                    }
                    else if (auxiliar == 25)
                    {
                        Carac4.Text = "y";
                    }
                    else if (auxiliar == 26)
                    {
                        Carac4.Text = "z";
                    }
                    else if (auxiliar == 27)
                    {
                        Carac4.Text = "A";
                    }
                    else if (auxiliar == 28)
                    {
                        Carac4.Text = "B";
                    }
                    else if (auxiliar == 29)
                    {
                        Carac4.Text = "C";
                    }
                    else if (auxiliar == 30)
                    {
                        Carac4.Text = "D";
                    }
                    else if (auxiliar == 31)
                    {
                        Carac4.Text = "E";
                    }
                    else if (auxiliar == 32)
                    {
                        Carac4.Text = "F";
                    }
                    else if (auxiliar == 33)
                    {
                        Carac4.Text = "G";
                    }
                    else if (auxiliar == 34)
                    {
                        Carac4.Text = "H";
                    }
                    else if (auxiliar == 35)
                    {
                        Carac4.Text = "I";
                    }
                    else if (auxiliar == 36)
                    {
                        Carac4.Text = "J";
                    }
                    else if (auxiliar == 37)
                    {
                        Carac4.Text = "K";
                    }
                    else if (auxiliar == 38)
                    {
                        Carac4.Text = "L";
                    }
                    else if (auxiliar == 39)
                    {
                        Carac4.Text = "M";
                    }
                    else if (auxiliar == 40)
                    {
                        Carac4.Text = "N";
                    }
                    else if (auxiliar == 41)
                    {
                        Carac4.Text = "O";
                    }
                    else if (auxiliar == 42)
                    {
                        Carac4.Text = "P";
                    }
                    else if (auxiliar == 43)
                    {
                        Carac4.Text = "Q";
                    }
                    else if (auxiliar == 44)
                    {
                        Carac4.Text = "R";
                    }
                    else if (auxiliar == 45)
                    {
                        Carac4.Text = "S";
                    }
                    else if (auxiliar == 46)
                    {
                        Carac4.Text = "T";
                    }
                    else if (auxiliar == 47)
                    {
                        Carac4.Text = "U";
                    }
                    else if (auxiliar == 48)
                    {
                        Carac4.Text = "V";
                    }
                    else if (auxiliar == 49)
                    {
                        Carac4.Text = "W";
                    }
                    else if (auxiliar == 50)
                    {
                        Carac4.Text = "X";
                    }
                    else if (auxiliar == 51)
                    {
                        Carac4.Text = "Y";
                    }
                    else if (auxiliar == 52)
                    {
                        Carac4.Text = "Z";
                    }
                    else if (auxiliar == 53)
                    {
                        Carac4.Text = "0";
                    }
                    else if (auxiliar == 54)
                    {
                        Carac4.Text = "1";
                    }
                    else if (auxiliar == 55)
                    {
                        Carac4.Text = "2";
                    }
                    else if (auxiliar == 56)
                    {
                        Carac4.Text = "3";
                    }
                    else if (auxiliar == 57)
                    {
                        Carac4.Text = "4";
                    }
                    else if (auxiliar == 58)
                    {
                        Carac4.Text = "5";
                    }
                    else if (auxiliar == 59)
                    {
                        Carac4.Text = "6";
                    }
                    else if (auxiliar == 60)
                    {
                        Carac4.Text = "7";
                    }
                    else if (auxiliar == 61)
                    {
                        Carac4.Text = "8";
                    }
                    else if (auxiliar == 62)
                    {
                        Carac4.Text = "9";
                    }
                }
                if (carac >= 5)
                {
                    auxiliar = senha.Next(1, 62);

                    Carac1.Visible = true;
                    Carac2.Visible = true;
                    Carac3.Visible = true;
                    Carac4.Visible = true;
                    Carac5.Visible = true;
                    Carac6.Visible = false;
                    Carac7.Visible = false;
                    Carac8.Visible = false;
                    Carac9.Visible = false;
                    Carac10.Visible = false;
                    Carac11.Visible = false;
                    Carac12.Visible = false;
                    Carac13.Visible = false;
                    Carac14.Visible = false;
                    Carac15.Visible = false;

                    if (auxiliar == 1)
                    {
                        Carac5.Text = "a";
                    }
                    else if (auxiliar == 2)
                    {
                        Carac5.Text = "b";
                    }
                    else if (auxiliar == 3)
                    {
                        Carac5.Text = "c";
                    }
                    else if (auxiliar == 4)
                    {
                        Carac5.Text = "d";
                    }
                    else if (auxiliar == 5)
                    {
                        Carac5.Text = "e";
                    }
                    else if (auxiliar == 6)
                    {
                        Carac5.Text = "f";
                    }
                    else if (auxiliar == 7)
                    {
                        Carac5.Text = "g";
                    }
                    else if (auxiliar == 8)
                    {
                        Carac5.Text = "h";
                    }
                    else if (auxiliar == 9)
                    {
                        Carac5.Text = "i";
                    }
                    else if (auxiliar == 10)
                    {
                        Carac5.Text = "j";
                    }
                    else if (auxiliar == 11)
                    {
                        Carac5.Text = "k";
                    }
                    else if (auxiliar == 12)
                    {
                        Carac5.Text = "l";
                    }
                    else if (auxiliar == 13)
                    {
                        Carac5.Text = "m";
                    }
                    else if (auxiliar == 14)
                    {
                        Carac5.Text = "n";
                    }
                    else if (auxiliar == 15)
                    {
                        Carac5.Text = "o";
                    }
                    else if (auxiliar == 16)
                    {
                        Carac5.Text = "p";
                    }
                    else if (auxiliar == 17)
                    {
                        Carac5.Text = "q";
                    }
                    else if (auxiliar == 18)
                    {
                        Carac5.Text = "r";
                    }
                    else if (auxiliar == 19)
                    {
                        Carac5.Text = "s";
                    }
                    else if (auxiliar == 20)
                    {
                        Carac5.Text = "t";
                    }
                    else if (auxiliar == 21)
                    {
                        Carac5.Text = "u";
                    }
                    else if (auxiliar == 22)
                    {
                        Carac5.Text = "v";
                    }
                    else if (auxiliar == 23)
                    {
                        Carac5.Text = "w";
                    }
                    else if (auxiliar == 24)
                    {
                        Carac5.Text = "x";
                    }
                    else if (auxiliar == 25)
                    {
                        Carac5.Text = "y";
                    }
                    else if (auxiliar == 26)
                    {
                        Carac5.Text = "z";
                    }
                    else if (auxiliar == 27)
                    {
                        Carac5.Text = "A";
                    }
                    else if (auxiliar == 28)
                    {
                        Carac5.Text = "B";
                    }
                    else if (auxiliar == 29)
                    {
                        Carac5.Text = "C";
                    }
                    else if (auxiliar == 30)
                    {
                        Carac5.Text = "D";
                    }
                    else if (auxiliar == 31)
                    {
                        Carac5.Text = "E";
                    }
                    else if (auxiliar == 32)
                    {
                        Carac5.Text = "F";
                    }
                    else if (auxiliar == 33)
                    {
                        Carac5.Text = "G";
                    }
                    else if (auxiliar == 34)
                    {
                        Carac5.Text = "H";
                    }
                    else if (auxiliar == 35)
                    {
                        Carac5.Text = "I";
                    }
                    else if (auxiliar == 36)
                    {
                        Carac5.Text = "J";
                    }
                    else if (auxiliar == 37)
                    {
                        Carac5.Text = "K";
                    }
                    else if (auxiliar == 38)
                    {
                        Carac5.Text = "L";
                    }
                    else if (auxiliar == 39)
                    {
                        Carac5.Text = "M";
                    }
                    else if (auxiliar == 40)
                    {
                        Carac5.Text = "N";
                    }
                    else if (auxiliar == 41)
                    {
                        Carac5.Text = "O";
                    }
                    else if (auxiliar == 42)
                    {
                        Carac5.Text = "P";
                    }
                    else if (auxiliar == 43)
                    {
                        Carac5.Text = "Q";
                    }
                    else if (auxiliar == 44)
                    {
                        Carac5.Text = "R";
                    }
                    else if (auxiliar == 45)
                    {
                        Carac5.Text = "S";
                    }
                    else if (auxiliar == 46)
                    {
                        Carac5.Text = "T";
                    }
                    else if (auxiliar == 47)
                    {
                        Carac5.Text = "U";
                    }
                    else if (auxiliar == 48)
                    {
                        Carac5.Text = "V";
                    }
                    else if (auxiliar == 49)
                    {
                        Carac5.Text = "W";
                    }
                    else if (auxiliar == 50)
                    {
                        Carac5.Text = "X";
                    }
                    else if (auxiliar == 51)
                    {
                        Carac5.Text = "Y";
                    }
                    else if (auxiliar == 52)
                    {
                        Carac5.Text = "Z";
                    }
                    else if (auxiliar == 53)
                    {
                        Carac5.Text = "0";
                    }
                    else if (auxiliar == 54)
                    {
                        Carac5.Text = "1";
                    }
                    else if (auxiliar == 55)
                    {
                        Carac5.Text = "2";
                    }
                    else if (auxiliar == 56)
                    {
                        Carac5.Text = "3";
                    }
                    else if (auxiliar == 57)
                    {
                        Carac5.Text = "4";
                    }
                    else if (auxiliar == 58)
                    {
                        Carac5.Text = "5";
                    }
                    else if (auxiliar == 59)
                    {
                        Carac5.Text = "6";
                    }
                    else if (auxiliar == 60)
                    {
                        Carac5.Text = "7";
                    }
                    else if (auxiliar == 61)
                    {
                        Carac5.Text = "8";
                    }
                    else if (auxiliar == 62)
                    {
                        Carac5.Text = "9";
                    }
                }
                if (carac >= 6)
                {
                    auxiliar = senha.Next(1, 62);

                    Carac1.Visible = true;
                    Carac2.Visible = true;
                    Carac3.Visible = true;
                    Carac4.Visible = true;
                    Carac5.Visible = true;
                    Carac6.Visible = true;
                    Carac7.Visible = false;
                    Carac8.Visible = false;
                    Carac9.Visible = false;
                    Carac10.Visible = false;
                    Carac11.Visible = false;
                    Carac12.Visible = false;
                    Carac13.Visible = false;
                    Carac14.Visible = false;
                    Carac15.Visible = false;

                    if (auxiliar == 1)
                    {
                        Carac6.Text = "a";
                    }
                    else if (auxiliar == 2)
                    {
                        Carac6.Text = "b";
                    }
                    else if (auxiliar == 3)
                    {
                        Carac6.Text = "c";
                    }
                    else if (auxiliar == 4)
                    {
                        Carac6.Text = "d";
                    }
                    else if (auxiliar == 5)
                    {
                        Carac6.Text = "e";
                    }
                    else if (auxiliar == 6)
                    {
                        Carac6.Text = "f";
                    }
                    else if (auxiliar == 7)
                    {
                        Carac6.Text = "g";
                    }
                    else if (auxiliar == 8)
                    {
                        Carac6.Text = "h";
                    }
                    else if (auxiliar == 9)
                    {
                        Carac6.Text = "i";
                    }
                    else if (auxiliar == 10)
                    {
                        Carac6.Text = "j";
                    }
                    else if (auxiliar == 11)
                    {
                        Carac6.Text = "k";
                    }
                    else if (auxiliar == 12)
                    {
                        Carac6.Text = "l";
                    }
                    else if (auxiliar == 13)
                    {
                        Carac6.Text = "m";
                    }
                    else if (auxiliar == 14)
                    {
                        Carac6.Text = "n";
                    }
                    else if (auxiliar == 15)
                    {
                        Carac6.Text = "o";
                    }
                    else if (auxiliar == 16)
                    {
                        Carac6.Text = "p";
                    }
                    else if (auxiliar == 17)
                    {
                        Carac6.Text = "q";
                    }
                    else if (auxiliar == 18)
                    {
                        Carac6.Text = "r";
                    }
                    else if (auxiliar == 19)
                    {
                        Carac6.Text = "s";
                    }
                    else if (auxiliar == 20)
                    {
                        Carac6.Text = "t";
                    }
                    else if (auxiliar == 21)
                    {
                        Carac6.Text = "u";
                    }
                    else if (auxiliar == 22)
                    {
                        Carac6.Text = "v";
                    }
                    else if (auxiliar == 23)
                    {
                        Carac6.Text = "w";
                    }
                    else if (auxiliar == 24)
                    {
                        Carac6.Text = "x";
                    }
                    else if (auxiliar == 25)
                    {
                        Carac6.Text = "y";
                    }
                    else if (auxiliar == 26)
                    {
                        Carac6.Text = "z";
                    }
                    else if (auxiliar == 27)
                    {
                        Carac6.Text = "A";
                    }
                    else if (auxiliar == 28)
                    {
                        Carac6.Text = "B";
                    }
                    else if (auxiliar == 29)
                    {
                        Carac6.Text = "C";
                    }
                    else if (auxiliar == 30)
                    {
                        Carac6.Text = "D";
                    }
                    else if (auxiliar == 31)
                    {
                        Carac6.Text = "E";
                    }
                    else if (auxiliar == 32)
                    {
                        Carac6.Text = "F";
                    }
                    else if (auxiliar == 33)
                    {
                        Carac6.Text = "G";
                    }
                    else if (auxiliar == 34)
                    {
                        Carac6.Text = "H";
                    }
                    else if (auxiliar == 35)
                    {
                        Carac6.Text = "I";
                    }
                    else if (auxiliar == 36)
                    {
                        Carac6.Text = "J";
                    }
                    else if (auxiliar == 37)
                    {
                        Carac6.Text = "K";
                    }
                    else if (auxiliar == 38)
                    {
                        Carac6.Text = "L";
                    }
                    else if (auxiliar == 39)
                    {
                        Carac6.Text = "M";
                    }
                    else if (auxiliar == 40)
                    {
                        Carac6.Text = "N";
                    }
                    else if (auxiliar == 41)
                    {
                        Carac6.Text = "O";
                    }
                    else if (auxiliar == 42)
                    {
                        Carac6.Text = "P";
                    }
                    else if (auxiliar == 43)
                    {
                        Carac6.Text = "Q";
                    }
                    else if (auxiliar == 44)
                    {
                        Carac6.Text = "R";
                    }
                    else if (auxiliar == 45)
                    {
                        Carac6.Text = "S";
                    }
                    else if (auxiliar == 46)
                    {
                        Carac6.Text = "T";
                    }
                    else if (auxiliar == 47)
                    {
                        Carac6.Text = "U";
                    }
                    else if (auxiliar == 48)
                    {
                        Carac6.Text = "V";
                    }
                    else if (auxiliar == 49)
                    {
                        Carac6.Text = "W";
                    }
                    else if (auxiliar == 50)
                    {
                        Carac6.Text = "X";
                    }
                    else if (auxiliar == 51)
                    {
                        Carac6.Text = "Y";
                    }
                    else if (auxiliar == 52)
                    {
                        Carac6.Text = "Z";
                    }
                    else if (auxiliar == 53)
                    {
                        Carac6.Text = "0";
                    }
                    else if (auxiliar == 54)
                    {
                        Carac6.Text = "1";
                    }
                    else if (auxiliar == 55)
                    {
                        Carac6.Text = "2";
                    }
                    else if (auxiliar == 56)
                    {
                        Carac6.Text = "3";
                    }
                    else if (auxiliar == 57)
                    {
                        Carac6.Text = "4";
                    }
                    else if (auxiliar == 58)
                    {
                        Carac6.Text = "5";
                    }
                    else if (auxiliar == 59)
                    {
                        Carac6.Text = "6";
                    }
                    else if (auxiliar == 60)
                    {
                        Carac6.Text = "7";
                    }
                    else if (auxiliar == 61)
                    {
                        Carac6.Text = "8";
                    }
                    else if (auxiliar == 62)
                    {
                        Carac6.Text = "9";
                    }
                }
                if (carac >= 7)
                {
                    auxiliar = senha.Next(1, 62);

                    Carac1.Visible = true;
                    Carac2.Visible = true;
                    Carac3.Visible = true;
                    Carac4.Visible = true;
                    Carac5.Visible = true;
                    Carac6.Visible = true;
                    Carac7.Visible = true;
                    Carac8.Visible = false;
                    Carac9.Visible = false;
                    Carac10.Visible = false;
                    Carac11.Visible = false;
                    Carac12.Visible = false;
                    Carac13.Visible = false;
                    Carac14.Visible = false;
                    Carac15.Visible = false;

                    if (auxiliar == 1)
                    {
                        Carac7.Text = "a";
                    }
                    else if (auxiliar == 2)
                    {
                        Carac7.Text = "b";
                    }
                    else if (auxiliar == 3)
                    {
                        Carac7.Text = "c";
                    }
                    else if (auxiliar == 4)
                    {
                        Carac7.Text = "d";
                    }
                    else if (auxiliar == 5)
                    {
                        Carac7.Text = "e";
                    }
                    else if (auxiliar == 6)
                    {
                        Carac7.Text = "f";
                    }
                    else if (auxiliar == 7)
                    {
                        Carac7.Text = "g";
                    }
                    else if (auxiliar == 8)
                    {
                        Carac7.Text = "h";
                    }
                    else if (auxiliar == 9)
                    {
                        Carac7.Text = "i";
                    }
                    else if (auxiliar == 10)
                    {
                        Carac7.Text = "j";
                    }
                    else if (auxiliar == 11)
                    {
                        Carac7.Text = "k";
                    }
                    else if (auxiliar == 12)
                    {
                        Carac7.Text = "l";
                    }
                    else if (auxiliar == 13)
                    {
                        Carac7.Text = "m";
                    }
                    else if (auxiliar == 14)
                    {
                        Carac7.Text = "n";
                    }
                    else if (auxiliar == 15)
                    {
                        Carac7.Text = "o";
                    }
                    else if (auxiliar == 16)
                    {
                        Carac7.Text = "p";
                    }
                    else if (auxiliar == 17)
                    {
                        Carac7.Text = "q";
                    }
                    else if (auxiliar == 18)
                    {
                        Carac7.Text = "r";
                    }
                    else if (auxiliar == 19)
                    {
                        Carac7.Text = "s";
                    }
                    else if (auxiliar == 20)
                    {
                        Carac7.Text = "t";
                    }
                    else if (auxiliar == 21)
                    {
                        Carac7.Text = "u";
                    }
                    else if (auxiliar == 22)
                    {
                        Carac7.Text = "v";
                    }
                    else if (auxiliar == 23)
                    {
                        Carac7.Text = "w";
                    }
                    else if (auxiliar == 24)
                    {
                        Carac7.Text = "x";
                    }
                    else if (auxiliar == 25)
                    {
                        Carac7.Text = "y";
                    }
                    else if (auxiliar == 26)
                    {
                        Carac7.Text = "z";
                    }
                    else if (auxiliar == 27)
                    {
                        Carac7.Text = "A";
                    }
                    else if (auxiliar == 28)
                    {
                        Carac7.Text = "B";
                    }
                    else if (auxiliar == 29)
                    {
                        Carac7.Text = "C";
                    }
                    else if (auxiliar == 30)
                    {
                        Carac7.Text = "D";
                    }
                    else if (auxiliar == 31)
                    {
                        Carac7.Text = "E";
                    }
                    else if (auxiliar == 32)
                    {
                        Carac7.Text = "F";
                    }
                    else if (auxiliar == 33)
                    {
                        Carac7.Text = "G";
                    }
                    else if (auxiliar == 34)
                    {
                        Carac7.Text = "H";
                    }
                    else if (auxiliar == 35)
                    {
                        Carac7.Text = "I";
                    }
                    else if (auxiliar == 36)
                    {
                        Carac7.Text = "J";
                    }
                    else if (auxiliar == 37)
                    {
                        Carac7.Text = "K";
                    }
                    else if (auxiliar == 38)
                    {
                        Carac7.Text = "L";
                    }
                    else if (auxiliar == 39)
                    {
                        Carac7.Text = "M";
                    }
                    else if (auxiliar == 40)
                    {
                        Carac7.Text = "N";
                    }
                    else if (auxiliar == 41)
                    {
                        Carac7.Text = "O";
                    }
                    else if (auxiliar == 42)
                    {
                        Carac7.Text = "P";
                    }
                    else if (auxiliar == 43)
                    {
                        Carac7.Text = "Q";
                    }
                    else if (auxiliar == 44)
                    {
                        Carac7.Text = "R";
                    }
                    else if (auxiliar == 45)
                    {
                        Carac7.Text = "S";
                    }
                    else if (auxiliar == 46)
                    {
                        Carac7.Text = "T";
                    }
                    else if (auxiliar == 47)
                    {
                        Carac7.Text = "U";
                    }
                    else if (auxiliar == 48)
                    {
                        Carac7.Text = "V";
                    }
                    else if (auxiliar == 49)
                    {
                        Carac7.Text = "W";
                    }
                    else if (auxiliar == 50)
                    {
                        Carac7.Text = "X";
                    }
                    else if (auxiliar == 51)
                    {
                        Carac7.Text = "Y";
                    }
                    else if (auxiliar == 52)
                    {
                        Carac7.Text = "Z";
                    }
                    else if (auxiliar == 53)
                    {
                        Carac7.Text = "0";
                    }
                    else if (auxiliar == 54)
                    {
                        Carac7.Text = "1";
                    }
                    else if (auxiliar == 55)
                    {
                        Carac7.Text = "2";
                    }
                    else if (auxiliar == 56)
                    {
                        Carac7.Text = "3";
                    }
                    else if (auxiliar == 57)
                    {
                        Carac7.Text = "4";
                    }
                    else if (auxiliar == 58)
                    {
                        Carac7.Text = "5";
                    }
                    else if (auxiliar == 59)
                    {
                        Carac7.Text = "6";
                    }
                    else if (auxiliar == 60)
                    {
                        Carac7.Text = "7";
                    }
                    else if (auxiliar == 61)
                    {
                        Carac7.Text = "8";
                    }
                    else if (auxiliar == 62)
                    {
                        Carac7.Text = "9";
                    }
                }
                if (carac >= 8)
                {
                    auxiliar = senha.Next(1, 62);

                    Carac1.Visible = true;
                    Carac2.Visible = true;
                    Carac3.Visible = true;
                    Carac4.Visible = true;
                    Carac5.Visible = true;
                    Carac6.Visible = true;
                    Carac7.Visible = true;
                    Carac8.Visible = true;
                    Carac9.Visible = false;
                    Carac10.Visible = false;
                    Carac11.Visible = false;
                    Carac12.Visible = false;
                    Carac13.Visible = false;
                    Carac14.Visible = false;
                    Carac15.Visible = false;

                    if (auxiliar == 1)
                    {
                        Carac8.Text = "a";
                    }
                    else if (auxiliar == 2)
                    {
                        Carac8.Text = "b";
                    }
                    else if (auxiliar == 3)
                    {
                        Carac8.Text = "c";
                    }
                    else if (auxiliar == 4)
                    {
                        Carac8.Text = "d";
                    }
                    else if (auxiliar == 5)
                    {
                        Carac8.Text = "e";
                    }
                    else if (auxiliar == 6)
                    {
                        Carac8.Text = "f";
                    }
                    else if (auxiliar == 7)
                    {
                        Carac8.Text = "g";
                    }
                    else if (auxiliar == 8)
                    {
                        Carac8.Text = "h";
                    }
                    else if (auxiliar == 9)
                    {
                        Carac8.Text = "i";
                    }
                    else if (auxiliar == 10)
                    {
                        Carac8.Text = "j";
                    }
                    else if (auxiliar == 11)
                    {
                        Carac8.Text = "k";
                    }
                    else if (auxiliar == 12)
                    {
                        Carac8.Text = "l";
                    }
                    else if (auxiliar == 13)
                    {
                        Carac8.Text = "m";
                    }
                    else if (auxiliar == 14)
                    {
                        Carac8.Text = "n";
                    }
                    else if (auxiliar == 15)
                    {
                        Carac8.Text = "o";
                    }
                    else if (auxiliar == 16)
                    {
                        Carac8.Text = "p";
                    }
                    else if (auxiliar == 17)
                    {
                        Carac8.Text = "q";
                    }
                    else if (auxiliar == 18)
                    {
                        Carac8.Text = "r";
                    }
                    else if (auxiliar == 19)
                    {
                        Carac8.Text = "s";
                    }
                    else if (auxiliar == 20)
                    {
                        Carac8.Text = "t";
                    }
                    else if (auxiliar == 21)
                    {
                        Carac8.Text = "u";
                    }
                    else if (auxiliar == 22)
                    {
                        Carac8.Text = "v";
                    }
                    else if (auxiliar == 23)
                    {
                        Carac8.Text = "w";
                    }
                    else if (auxiliar == 24)
                    {
                        Carac8.Text = "x";
                    }
                    else if (auxiliar == 25)
                    {
                        Carac8.Text = "y";
                    }
                    else if (auxiliar == 26)
                    {
                        Carac8.Text = "z";
                    }
                    else if (auxiliar == 27)
                    {
                        Carac8.Text = "A";
                    }
                    else if (auxiliar == 28)
                    {
                        Carac8.Text = "B";
                    }
                    else if (auxiliar == 29)
                    {
                        Carac8.Text = "C";
                    }
                    else if (auxiliar == 30)
                    {
                        Carac8.Text = "D";
                    }
                    else if (auxiliar == 31)
                    {
                        Carac8.Text = "E";
                    }
                    else if (auxiliar == 32)
                    {
                        Carac8.Text = "F";
                    }
                    else if (auxiliar == 33)
                    {
                        Carac8.Text = "G";
                    }
                    else if (auxiliar == 34)
                    {
                        Carac8.Text = "H";
                    }
                    else if (auxiliar == 35)
                    {
                        Carac8.Text = "I";
                    }
                    else if (auxiliar == 36)
                    {
                        Carac8.Text = "J";
                    }
                    else if (auxiliar == 37)
                    {
                        Carac8.Text = "K";
                    }
                    else if (auxiliar == 38)
                    {
                        Carac8.Text = "L";
                    }
                    else if (auxiliar == 39)
                    {
                        Carac8.Text = "M";
                    }
                    else if (auxiliar == 40)
                    {
                        Carac8.Text = "N";
                    }
                    else if (auxiliar == 41)
                    {
                        Carac8.Text = "O";
                    }
                    else if (auxiliar == 42)
                    {
                        Carac8.Text = "P";
                    }
                    else if (auxiliar == 43)
                    {
                        Carac8.Text = "Q";
                    }
                    else if (auxiliar == 44)
                    {
                        Carac8.Text = "R";
                    }
                    else if (auxiliar == 45)
                    {
                        Carac8.Text = "S";
                    }
                    else if (auxiliar == 46)
                    {
                        Carac8.Text = "T";
                    }
                    else if (auxiliar == 47)
                    {
                        Carac8.Text = "U";
                    }
                    else if (auxiliar == 48)
                    {
                        Carac8.Text = "V";
                    }
                    else if (auxiliar == 49)
                    {
                        Carac8.Text = "W";
                    }
                    else if (auxiliar == 50)
                    {
                        Carac8.Text = "X";
                    }
                    else if (auxiliar == 51)
                    {
                        Carac8.Text = "Y";
                    }
                    else if (auxiliar == 52)
                    {
                        Carac8.Text = "Z";
                    }
                    else if (auxiliar == 53)
                    {
                        Carac8.Text = "0";
                    }
                    else if (auxiliar == 54)
                    {
                        Carac8.Text = "1";
                    }
                    else if (auxiliar == 55)
                    {
                        Carac8.Text = "2";
                    }
                    else if (auxiliar == 56)
                    {
                        Carac8.Text = "3";
                    }
                    else if (auxiliar == 57)
                    {
                        Carac8.Text = "4";
                    }
                    else if (auxiliar == 58)
                    {
                        Carac8.Text = "5";
                    }
                    else if (auxiliar == 59)
                    {
                        Carac8.Text = "6";
                    }
                    else if (auxiliar == 60)
                    {
                        Carac8.Text = "7";
                    }
                    else if (auxiliar == 61)
                    {
                        Carac8.Text = "8";
                    }
                    else if (auxiliar == 62)
                    {
                        Carac8.Text = "9";
                    }
                }
                if (carac >= 9)
                {
                    auxiliar = senha.Next(1, 62);

                    Carac1.Visible = true;
                    Carac2.Visible = true;
                    Carac3.Visible = true;
                    Carac4.Visible = true;
                    Carac5.Visible = true;
                    Carac6.Visible = true;
                    Carac7.Visible = true;
                    Carac8.Visible = true;
                    Carac9.Visible = true;
                    Carac10.Visible = false;
                    Carac11.Visible = false;
                    Carac12.Visible = false;
                    Carac13.Visible = false;
                    Carac14.Visible = false;
                    Carac15.Visible = false;

                    if (auxiliar == 1)
                    {
                        Carac9.Text = "a";
                    }
                    else if (auxiliar == 2)
                    {
                        Carac9.Text = "b";
                    }
                    else if (auxiliar == 3)
                    {
                        Carac9.Text = "c";
                    }
                    else if (auxiliar == 4)
                    {
                        Carac9.Text = "d";
                    }
                    else if (auxiliar == 5)
                    {
                        Carac9.Text = "e";
                    }
                    else if (auxiliar == 6)
                    {
                        Carac9.Text = "f";
                    }
                    else if (auxiliar == 7)
                    {
                        Carac9.Text = "g";
                    }
                    else if (auxiliar == 8)
                    {
                        Carac9.Text = "h";
                    }
                    else if (auxiliar == 9)
                    {
                        Carac9.Text = "i";
                    }
                    else if (auxiliar == 10)
                    {
                        Carac9.Text = "j";
                    }
                    else if (auxiliar == 11)
                    {
                        Carac9.Text = "k";
                    }
                    else if (auxiliar == 12)
                    {
                        Carac9.Text = "l";
                    }
                    else if (auxiliar == 13)
                    {
                        Carac9.Text = "m";
                    }
                    else if (auxiliar == 14)
                    {
                        Carac9.Text = "n";
                    }
                    else if (auxiliar == 15)
                    {
                        Carac9.Text = "o";
                    }
                    else if (auxiliar == 16)
                    {
                        Carac9.Text = "p";
                    }
                    else if (auxiliar == 17)
                    {
                        Carac9.Text = "q";
                    }
                    else if (auxiliar == 18)
                    {
                        Carac9.Text = "r";
                    }
                    else if (auxiliar == 19)
                    {
                        Carac9.Text = "s";
                    }
                    else if (auxiliar == 20)
                    {
                        Carac9.Text = "t";
                    }
                    else if (auxiliar == 21)
                    {
                        Carac9.Text = "u";
                    }
                    else if (auxiliar == 22)
                    {
                        Carac9.Text = "v";
                    }
                    else if (auxiliar == 23)
                    {
                        Carac9.Text = "w";
                    }
                    else if (auxiliar == 24)
                    {
                        Carac9.Text = "x";
                    }
                    else if (auxiliar == 25)
                    {
                        Carac9.Text = "y";
                    }
                    else if (auxiliar == 26)
                    {
                        Carac9.Text = "z";
                    }
                    else if (auxiliar == 27)
                    {
                        Carac9.Text = "A";
                    }
                    else if (auxiliar == 28)
                    {
                        Carac9.Text = "B";
                    }
                    else if (auxiliar == 29)
                    {
                        Carac9.Text = "C";
                    }
                    else if (auxiliar == 30)
                    {
                        Carac9.Text = "D";
                    }
                    else if (auxiliar == 31)
                    {
                        Carac9.Text = "E";
                    }
                    else if (auxiliar == 32)
                    {
                        Carac9.Text = "F";
                    }
                    else if (auxiliar == 33)
                    {
                        Carac9.Text = "G";
                    }
                    else if (auxiliar == 34)
                    {
                        Carac9.Text = "H";
                    }
                    else if (auxiliar == 35)
                    {
                        Carac9.Text = "I";
                    }
                    else if (auxiliar == 36)
                    {
                        Carac9.Text = "J";
                    }
                    else if (auxiliar == 37)
                    {
                        Carac9.Text = "K";
                    }
                    else if (auxiliar == 38)
                    {
                        Carac9.Text = "L";
                    }
                    else if (auxiliar == 39)
                    {
                        Carac9.Text = "M";
                    }
                    else if (auxiliar == 40)
                    {
                        Carac9.Text = "N";
                    }
                    else if (auxiliar == 41)
                    {
                        Carac9.Text = "O";
                    }
                    else if (auxiliar == 42)
                    {
                        Carac9.Text = "P";
                    }
                    else if (auxiliar == 43)
                    {
                        Carac9.Text = "Q";
                    }
                    else if (auxiliar == 44)
                    {
                        Carac9.Text = "R";
                    }
                    else if (auxiliar == 45)
                    {
                        Carac9.Text = "S";
                    }
                    else if (auxiliar == 46)
                    {
                        Carac9.Text = "T";
                    }
                    else if (auxiliar == 47)
                    {
                        Carac9.Text = "U";
                    }
                    else if (auxiliar == 48)
                    {
                        Carac9.Text = "V";
                    }
                    else if (auxiliar == 49)
                    {
                        Carac9.Text = "W";
                    }
                    else if (auxiliar == 50)
                    {
                        Carac9.Text = "X";
                    }
                    else if (auxiliar == 51)
                    {
                        Carac9.Text = "Y";
                    }
                    else if (auxiliar == 52)
                    {
                        Carac9.Text = "Z";
                    }
                    else if (auxiliar == 53)
                    {
                        Carac9.Text = "0";
                    }
                    else if (auxiliar == 54)
                    {
                        Carac9.Text = "1";
                    }
                    else if (auxiliar == 55)
                    {
                        Carac9.Text = "2";
                    }
                    else if (auxiliar == 56)
                    {
                        Carac9.Text = "3";
                    }
                    else if (auxiliar == 57)
                    {
                        Carac9.Text = "4";
                    }
                    else if (auxiliar == 58)
                    {
                        Carac9.Text = "5";
                    }
                    else if (auxiliar == 59)
                    {
                        Carac9.Text = "6";
                    }
                    else if (auxiliar == 60)
                    {
                        Carac9.Text = "7";
                    }
                    else if (auxiliar == 61)
                    {
                        Carac9.Text = "8";
                    }
                    else if (auxiliar == 62)
                    {
                        Carac9.Text = "9";
                    }
                }
                if (carac >= 10)
                {
                    auxiliar = senha.Next(1, 62);

                    Carac1.Visible = true;
                    Carac2.Visible = true;
                    Carac3.Visible = true;
                    Carac4.Visible = true;
                    Carac5.Visible = true;
                    Carac6.Visible = true;
                    Carac7.Visible = true;
                    Carac8.Visible = true;
                    Carac9.Visible = true;
                    Carac10.Visible = true;
                    Carac11.Visible = false;
                    Carac12.Visible = false;
                    Carac13.Visible = false;
                    Carac14.Visible = false;
                    Carac15.Visible = false;

                    if (auxiliar == 1)
                    {
                        Carac10.Text = "a";
                    }
                    else if (auxiliar == 2)
                    {
                        Carac10.Text = "b";
                    }
                    else if (auxiliar == 3)
                    {
                        Carac10.Text = "c";
                    }
                    else if (auxiliar == 4)
                    {
                        Carac10.Text = "d";
                    }
                    else if (auxiliar == 5)
                    {
                        Carac10.Text = "e";
                    }
                    else if (auxiliar == 6)
                    {
                        Carac10.Text = "f";
                    }
                    else if (auxiliar == 7)
                    {
                        Carac10.Text = "g";
                    }
                    else if (auxiliar == 8)
                    {
                        Carac10.Text = "h";
                    }
                    else if (auxiliar == 9)
                    {
                        Carac10.Text = "i";
                    }
                    else if (auxiliar == 10)
                    {
                        Carac10.Text = "j";
                    }
                    else if (auxiliar == 11)
                    {
                        Carac10.Text = "k";
                    }
                    else if (auxiliar == 12)
                    {
                        Carac10.Text = "l";
                    }
                    else if (auxiliar == 13)
                    {
                        Carac10.Text = "m";
                    }
                    else if (auxiliar == 14)
                    {
                        Carac10.Text = "n";
                    }
                    else if (auxiliar == 15)
                    {
                        Carac10.Text = "o";
                    }
                    else if (auxiliar == 16)
                    {
                        Carac10.Text = "p";
                    }
                    else if (auxiliar == 17)
                    {
                        Carac10.Text = "q";
                    }
                    else if (auxiliar == 18)
                    {
                        Carac10.Text = "r";
                    }
                    else if (auxiliar == 19)
                    {
                        Carac10.Text = "s";
                    }
                    else if (auxiliar == 20)
                    {
                        Carac10.Text = "t";
                    }
                    else if (auxiliar == 21)
                    {
                        Carac10.Text = "u";
                    }
                    else if (auxiliar == 22)
                    {
                        Carac10.Text = "v";
                    }
                    else if (auxiliar == 23)
                    {
                        Carac10.Text = "w";
                    }
                    else if (auxiliar == 24)
                    {
                        Carac10.Text = "x";
                    }
                    else if (auxiliar == 25)
                    {
                        Carac10.Text = "y";
                    }
                    else if (auxiliar == 26)
                    {
                        Carac10.Text = "z";
                    }
                    else if (auxiliar == 27)
                    {
                        Carac10.Text = "A";
                    }
                    else if (auxiliar == 28)
                    {
                        Carac10.Text = "B";
                    }
                    else if (auxiliar == 29)
                    {
                        Carac10.Text = "C";
                    }
                    else if (auxiliar == 30)
                    {
                        Carac10.Text = "D";
                    }
                    else if (auxiliar == 31)
                    {
                        Carac10.Text = "E";
                    }
                    else if (auxiliar == 32)
                    {
                        Carac10.Text = "F";
                    }
                    else if (auxiliar == 33)
                    {
                        Carac10.Text = "G";
                    }
                    else if (auxiliar == 34)
                    {
                        Carac10.Text = "H";
                    }
                    else if (auxiliar == 35)
                    {
                        Carac10.Text = "I";
                    }
                    else if (auxiliar == 36)
                    {
                        Carac10.Text = "J";
                    }
                    else if (auxiliar == 37)
                    {
                        Carac10.Text = "K";
                    }
                    else if (auxiliar == 38)
                    {
                        Carac10.Text = "L";
                    }
                    else if (auxiliar == 39)
                    {
                        Carac10.Text = "M";
                    }
                    else if (auxiliar == 40)
                    {
                        Carac10.Text = "N";
                    }
                    else if (auxiliar == 41)
                    {
                        Carac10.Text = "O";
                    }
                    else if (auxiliar == 42)
                    {
                        Carac10.Text = "P";
                    }
                    else if (auxiliar == 43)
                    {
                        Carac10.Text = "Q";
                    }
                    else if (auxiliar == 44)
                    {
                        Carac10.Text = "R";
                    }
                    else if (auxiliar == 45)
                    {
                        Carac10.Text = "S";
                    }
                    else if (auxiliar == 46)
                    {
                        Carac10.Text = "T";
                    }
                    else if (auxiliar == 47)
                    {
                        Carac10.Text = "U";
                    }
                    else if (auxiliar == 48)
                    {
                        Carac10.Text = "V";
                    }
                    else if (auxiliar == 49)
                    {
                        Carac10.Text = "W";
                    }
                    else if (auxiliar == 50)
                    {
                        Carac10.Text = "X";
                    }
                    else if (auxiliar == 51)
                    {
                        Carac10.Text = "Y";
                    }
                    else if (auxiliar == 52)
                    {
                        Carac10.Text = "Z";
                    }
                    else if (auxiliar == 53)
                    {
                        Carac10.Text = "0";
                    }
                    else if (auxiliar == 54)
                    {
                        Carac10.Text = "1";
                    }
                    else if (auxiliar == 55)
                    {
                        Carac10.Text = "2";
                    }
                    else if (auxiliar == 56)
                    {
                        Carac10.Text = "3";
                    }
                    else if (auxiliar == 57)
                    {
                        Carac10.Text = "4";
                    }
                    else if (auxiliar == 58)
                    {
                        Carac10.Text = "5";
                    }
                    else if (auxiliar == 59)
                    {
                        Carac10.Text = "6";
                    }
                    else if (auxiliar == 60)
                    {
                        Carac10.Text = "7";
                    }
                    else if (auxiliar == 61)
                    {
                        Carac10.Text = "8";
                    }
                    else if (auxiliar == 62)
                    {
                        Carac10.Text = "9";
                    }
                }
                if (carac >= 11)
                {
                    auxiliar = senha.Next(1, 62);

                    Carac1.Visible = true;
                    Carac2.Visible = true;
                    Carac3.Visible = true;
                    Carac4.Visible = true;
                    Carac5.Visible = true;
                    Carac6.Visible = true;
                    Carac7.Visible = true;
                    Carac8.Visible = true;
                    Carac9.Visible = true;
                    Carac10.Visible = true;
                    Carac11.Visible = true;
                    Carac12.Visible = false;
                    Carac13.Visible = false;
                    Carac14.Visible = false;
                    Carac15.Visible = false;

                    if (auxiliar == 1)
                    {
                        Carac11.Text = "a";
                    }
                    else if (auxiliar == 2)
                    {
                        Carac11.Text = "b";
                    }
                    else if (auxiliar == 3)
                    {
                        Carac11.Text = "c";
                    }
                    else if (auxiliar == 4)
                    {
                        Carac11.Text = "d";
                    }
                    else if (auxiliar == 5)
                    {
                        Carac11.Text = "e";
                    }
                    else if (auxiliar == 6)
                    {
                        Carac11.Text = "f";
                    }
                    else if (auxiliar == 7)
                    {
                        Carac11.Text = "g";
                    }
                    else if (auxiliar == 8)
                    {
                        Carac11.Text = "h";
                    }
                    else if (auxiliar == 9)
                    {
                        Carac11.Text = "i";
                    }
                    else if (auxiliar == 10)
                    {
                        Carac11.Text = "j";
                    }
                    else if (auxiliar == 11)
                    {
                        Carac11.Text = "k";
                    }
                    else if (auxiliar == 12)
                    {
                        Carac11.Text = "l";
                    }
                    else if (auxiliar == 13)
                    {
                        Carac11.Text = "m";
                    }
                    else if (auxiliar == 14)
                    {
                        Carac11.Text = "n";
                    }
                    else if (auxiliar == 15)
                    {
                        Carac11.Text = "o";
                    }
                    else if (auxiliar == 16)
                    {
                        Carac11.Text = "p";
                    }
                    else if (auxiliar == 17)
                    {
                        Carac11.Text = "q";
                    }
                    else if (auxiliar == 18)
                    {
                        Carac11.Text = "r";
                    }
                    else if (auxiliar == 19)
                    {
                        Carac11.Text = "s";
                    }
                    else if (auxiliar == 20)
                    {
                        Carac11.Text = "t";
                    }
                    else if (auxiliar == 21)
                    {
                        Carac11.Text = "u";
                    }
                    else if (auxiliar == 22)
                    {
                        Carac11.Text = "v";
                    }
                    else if (auxiliar == 23)
                    {
                        Carac11.Text = "w";
                    }
                    else if (auxiliar == 24)
                    {
                        Carac11.Text = "x";
                    }
                    else if (auxiliar == 25)
                    {
                        Carac11.Text = "y";
                    }
                    else if (auxiliar == 26)
                    {
                        Carac11.Text = "z";
                    }
                    else if (auxiliar == 27)
                    {
                        Carac11.Text = "A";
                    }
                    else if (auxiliar == 28)
                    {
                        Carac11.Text = "B";
                    }
                    else if (auxiliar == 29)
                    {
                        Carac11.Text = "C";
                    }
                    else if (auxiliar == 30)
                    {
                        Carac11.Text = "D";
                    }
                    else if (auxiliar == 31)
                    {
                        Carac11.Text = "E";
                    }
                    else if (auxiliar == 32)
                    {
                        Carac11.Text = "F";
                    }
                    else if (auxiliar == 33)
                    {
                        Carac11.Text = "G";
                    }
                    else if (auxiliar == 34)
                    {
                        Carac11.Text = "H";
                    }
                    else if (auxiliar == 35)
                    {
                        Carac11.Text = "I";
                    }
                    else if (auxiliar == 36)
                    {
                        Carac11.Text = "J";
                    }
                    else if (auxiliar == 37)
                    {
                        Carac11.Text = "K";
                    }
                    else if (auxiliar == 38)
                    {
                        Carac11.Text = "L";
                    }
                    else if (auxiliar == 39)
                    {
                        Carac11.Text = "M";
                    }
                    else if (auxiliar == 40)
                    {
                        Carac11.Text = "N";
                    }
                    else if (auxiliar == 41)
                    {
                        Carac11.Text = "O";
                    }
                    else if (auxiliar == 42)
                    {
                        Carac11.Text = "P";
                    }
                    else if (auxiliar == 43)
                    {
                        Carac11.Text = "Q";
                    }
                    else if (auxiliar == 44)
                    {
                        Carac11.Text = "R";
                    }
                    else if (auxiliar == 45)
                    {
                        Carac11.Text = "S";
                    }
                    else if (auxiliar == 46)
                    {
                        Carac11.Text = "T";
                    }
                    else if (auxiliar == 47)
                    {
                        Carac11.Text = "U";
                    }
                    else if (auxiliar == 48)
                    {
                        Carac11.Text = "V";
                    }
                    else if (auxiliar == 49)
                    {
                        Carac11.Text = "W";
                    }
                    else if (auxiliar == 50)
                    {
                        Carac11.Text = "X";
                    }
                    else if (auxiliar == 51)
                    {
                        Carac11.Text = "Y";
                    }
                    else if (auxiliar == 52)
                    {
                        Carac11.Text = "Z";
                    }
                    else if (auxiliar == 53)
                    {
                        Carac11.Text = "0";
                    }
                    else if (auxiliar == 54)
                    {
                        Carac11.Text = "1";
                    }
                    else if (auxiliar == 55)
                    {
                        Carac11.Text = "2";
                    }
                    else if (auxiliar == 56)
                    {
                        Carac11.Text = "3";
                    }
                    else if (auxiliar == 57)
                    {
                        Carac11.Text = "4";
                    }
                    else if (auxiliar == 58)
                    {
                        Carac11.Text = "5";
                    }
                    else if (auxiliar == 59)
                    {
                        Carac11.Text = "6";
                    }
                    else if (auxiliar == 60)
                    {
                        Carac11.Text = "7";
                    }
                    else if (auxiliar == 61)
                    {
                        Carac11.Text = "8";
                    }
                    else if (auxiliar == 62)
                    {
                        Carac11.Text = "9";
                    }
                }
                if (carac >= 12)
                {
                    auxiliar = senha.Next(1, 62);

                    Carac1.Visible = true;
                    Carac2.Visible = true;
                    Carac3.Visible = true;
                    Carac4.Visible = true;
                    Carac5.Visible = true;
                    Carac6.Visible = true;
                    Carac7.Visible = true;
                    Carac8.Visible = true;
                    Carac9.Visible = true;
                    Carac10.Visible = true;
                    Carac11.Visible = true;
                    Carac12.Visible = true;
                    Carac13.Visible = false;
                    Carac14.Visible = false;
                    Carac15.Visible = false;

                    if (auxiliar == 1)
                    {
                        Carac12.Text = "a";
                    }
                    else if (auxiliar == 2)
                    {
                        Carac12.Text = "b";
                    }
                    else if (auxiliar == 3)
                    {
                        Carac12.Text = "c";
                    }
                    else if (auxiliar == 4)
                    {
                        Carac12.Text = "d";
                    }
                    else if (auxiliar == 5)
                    {
                        Carac12.Text = "e";
                    }
                    else if (auxiliar == 6)
                    {
                        Carac12.Text = "f";
                    }
                    else if (auxiliar == 7)
                    {
                        Carac12.Text = "g";
                    }
                    else if (auxiliar == 8)
                    {
                        Carac12.Text = "h";
                    }
                    else if (auxiliar == 9)
                    {
                        Carac12.Text = "i";
                    }
                    else if (auxiliar == 10)
                    {
                        Carac12.Text = "j";
                    }
                    else if (auxiliar == 11)
                    {
                        Carac12.Text = "k";
                    }
                    else if (auxiliar == 12)
                    {
                        Carac12.Text = "l";
                    }
                    else if (auxiliar == 13)
                    {
                        Carac12.Text = "m";
                    }
                    else if (auxiliar == 14)
                    {
                        Carac12.Text = "n";
                    }
                    else if (auxiliar == 15)
                    {
                        Carac12.Text = "o";
                    }
                    else if (auxiliar == 16)
                    {
                        Carac12.Text = "p";
                    }
                    else if (auxiliar == 17)
                    {
                        Carac12.Text = "q";
                    }
                    else if (auxiliar == 18)
                    {
                        Carac12.Text = "r";
                    }
                    else if (auxiliar == 19)
                    {
                        Carac12.Text = "s";
                    }
                    else if (auxiliar == 20)
                    {
                        Carac12.Text = "t";
                    }
                    else if (auxiliar == 21)
                    {
                        Carac12.Text = "u";
                    }
                    else if (auxiliar == 22)
                    {
                        Carac12.Text = "v";
                    }
                    else if (auxiliar == 23)
                    {
                        Carac12.Text = "w";
                    }
                    else if (auxiliar == 24)
                    {
                        Carac12.Text = "x";
                    }
                    else if (auxiliar == 25)
                    {
                        Carac12.Text = "y";
                    }
                    else if (auxiliar == 26)
                    {
                        Carac12.Text = "z";
                    }
                    else if (auxiliar == 27)
                    {
                        Carac12.Text = "A";
                    }
                    else if (auxiliar == 28)
                    {
                        Carac12.Text = "B";
                    }
                    else if (auxiliar == 29)
                    {
                        Carac12.Text = "C";
                    }
                    else if (auxiliar == 30)
                    {
                        Carac12.Text = "D";
                    }
                    else if (auxiliar == 31)
                    {
                        Carac12.Text = "E";
                    }
                    else if (auxiliar == 32)
                    {
                        Carac12.Text = "F";
                    }
                    else if (auxiliar == 33)
                    {
                        Carac12.Text = "G";
                    }
                    else if (auxiliar == 34)
                    {
                        Carac12.Text = "H";
                    }
                    else if (auxiliar == 35)
                    {
                        Carac12.Text = "I";
                    }
                    else if (auxiliar == 36)
                    {
                        Carac12.Text = "J";
                    }
                    else if (auxiliar == 37)
                    {
                        Carac12.Text = "K";
                    }
                    else if (auxiliar == 38)
                    {
                        Carac12.Text = "L";
                    }
                    else if (auxiliar == 39)
                    {
                        Carac12.Text = "M";
                    }
                    else if (auxiliar == 40)
                    {
                        Carac12.Text = "N";
                    }
                    else if (auxiliar == 41)
                    {
                        Carac12.Text = "O";
                    }
                    else if (auxiliar == 42)
                    {
                        Carac12.Text = "P";
                    }
                    else if (auxiliar == 43)
                    {
                        Carac12.Text = "Q";
                    }
                    else if (auxiliar == 44)
                    {
                        Carac12.Text = "R";
                    }
                    else if (auxiliar == 45)
                    {
                        Carac12.Text = "S";
                    }
                    else if (auxiliar == 46)
                    {
                        Carac12.Text = "T";
                    }
                    else if (auxiliar == 47)
                    {
                        Carac12.Text = "U";
                    }
                    else if (auxiliar == 48)
                    {
                        Carac12.Text = "V";
                    }
                    else if (auxiliar == 49)
                    {
                        Carac12.Text = "W";
                    }
                    else if (auxiliar == 50)
                    {
                        Carac12.Text = "X";
                    }
                    else if (auxiliar == 51)
                    {
                        Carac12.Text = "Y";
                    }
                    else if (auxiliar == 52)
                    {
                        Carac12.Text = "Z";
                    }
                    else if (auxiliar == 53)
                    {
                        Carac12.Text = "0";
                    }
                    else if (auxiliar == 54)
                    {
                        Carac12.Text = "1";
                    }
                    else if (auxiliar == 55)
                    {
                        Carac12.Text = "2";
                    }
                    else if (auxiliar == 56)
                    {
                        Carac12.Text = "3";
                    }
                    else if (auxiliar == 57)
                    {
                        Carac12.Text = "4";
                    }
                    else if (auxiliar == 58)
                    {
                        Carac12.Text = "5";
                    }
                    else if (auxiliar == 59)
                    {
                        Carac12.Text = "6";
                    }
                    else if (auxiliar == 60)
                    {
                        Carac12.Text = "7";
                    }
                    else if (auxiliar == 61)
                    {
                        Carac12.Text = "8";
                    }
                    else if (auxiliar == 62)
                    {
                        Carac12.Text = "9";
                    }
                }
                if (carac >= 13)
                {
                    auxiliar = senha.Next(1, 62);

                    Carac1.Visible = true;
                    Carac2.Visible = true;
                    Carac3.Visible = true;
                    Carac4.Visible = true;
                    Carac5.Visible = true;
                    Carac6.Visible = true;
                    Carac7.Visible = true;
                    Carac8.Visible = true;
                    Carac9.Visible = true;
                    Carac10.Visible = true;
                    Carac11.Visible = true;
                    Carac12.Visible = true;
                    Carac13.Visible = true;
                    Carac14.Visible = false;
                    Carac15.Visible = false;

                    if (auxiliar == 1)
                    {
                        Carac13.Text = "a";
                    }
                    else if (auxiliar == 2)
                    {
                        Carac13.Text = "b";
                    }
                    else if (auxiliar == 3)
                    {
                        Carac13.Text = "c";
                    }
                    else if (auxiliar == 4)
                    {
                        Carac13.Text = "d";
                    }
                    else if (auxiliar == 5)
                    {
                        Carac13.Text = "e";
                    }
                    else if (auxiliar == 6)
                    {
                        Carac13.Text = "f";
                    }
                    else if (auxiliar == 7)
                    {
                        Carac13.Text = "g";
                    }
                    else if (auxiliar == 8)
                    {
                        Carac13.Text = "h";
                    }
                    else if (auxiliar == 9)
                    {
                        Carac13.Text = "i";
                    }
                    else if (auxiliar == 10)
                    {
                        Carac13.Text = "j";
                    }
                    else if (auxiliar == 11)
                    {
                        Carac13.Text = "k";
                    }
                    else if (auxiliar == 12)
                    {
                        Carac13.Text = "l";
                    }
                    else if (auxiliar == 13)
                    {
                        Carac13.Text = "m";
                    }
                    else if (auxiliar == 14)
                    {
                        Carac13.Text = "n";
                    }
                    else if (auxiliar == 15)
                    {
                        Carac13.Text = "o";
                    }
                    else if (auxiliar == 16)
                    {
                        Carac13.Text = "p";
                    }
                    else if (auxiliar == 17)
                    {
                        Carac13.Text = "q";
                    }
                    else if (auxiliar == 18)
                    {
                        Carac13.Text = "r";
                    }
                    else if (auxiliar == 19)
                    {
                        Carac13.Text = "s";
                    }
                    else if (auxiliar == 20)
                    {
                        Carac13.Text = "t";
                    }
                    else if (auxiliar == 21)
                    {
                        Carac13.Text = "u";
                    }
                    else if (auxiliar == 22)
                    {
                        Carac13.Text = "v";
                    }
                    else if (auxiliar == 23)
                    {
                        Carac13.Text = "w";
                    }
                    else if (auxiliar == 24)
                    {
                        Carac13.Text = "x";
                    }
                    else if (auxiliar == 25)
                    {
                        Carac13.Text = "y";
                    }
                    else if (auxiliar == 26)
                    {
                        Carac13.Text = "z";
                    }
                    else if (auxiliar == 27)
                    {
                        Carac13.Text = "A";
                    }
                    else if (auxiliar == 28)
                    {
                        Carac13.Text = "B";
                    }
                    else if (auxiliar == 29)
                    {
                        Carac13.Text = "C";
                    }
                    else if (auxiliar == 30)
                    {
                        Carac13.Text = "D";
                    }
                    else if (auxiliar == 31)
                    {
                        Carac13.Text = "E";
                    }
                    else if (auxiliar == 32)
                    {
                        Carac13.Text = "F";
                    }
                    else if (auxiliar == 33)
                    {
                        Carac13.Text = "G";
                    }
                    else if (auxiliar == 34)
                    {
                        Carac13.Text = "H";
                    }
                    else if (auxiliar == 35)
                    {
                        Carac13.Text = "I";
                    }
                    else if (auxiliar == 36)
                    {
                        Carac13.Text = "J";
                    }
                    else if (auxiliar == 37)
                    {
                        Carac13.Text = "K";
                    }
                    else if (auxiliar == 38)
                    {
                        Carac13.Text = "L";
                    }
                    else if (auxiliar == 39)
                    {
                        Carac13.Text = "M";
                    }
                    else if (auxiliar == 40)
                    {
                        Carac13.Text = "N";
                    }
                    else if (auxiliar == 41)
                    {
                        Carac13.Text = "O";
                    }
                    else if (auxiliar == 42)
                    {
                        Carac13.Text = "P";
                    }
                    else if (auxiliar == 43)
                    {
                        Carac13.Text = "Q";
                    }
                    else if (auxiliar == 44)
                    {
                        Carac13.Text = "R";
                    }
                    else if (auxiliar == 45)
                    {
                        Carac13.Text = "S";
                    }
                    else if (auxiliar == 46)
                    {
                        Carac13.Text = "T";
                    }
                    else if (auxiliar == 47)
                    {
                        Carac13.Text = "U";
                    }
                    else if (auxiliar == 48)
                    {
                        Carac13.Text = "V";
                    }
                    else if (auxiliar == 49)
                    {
                        Carac13.Text = "W";
                    }
                    else if (auxiliar == 50)
                    {
                        Carac13.Text = "X";
                    }
                    else if (auxiliar == 51)
                    {
                        Carac13.Text = "Y";
                    }
                    else if (auxiliar == 52)
                    {
                        Carac13.Text = "Z";
                    }
                    else if (auxiliar == 53)
                    {
                        Carac13.Text = "0";
                    }
                    else if (auxiliar == 54)
                    {
                        Carac13.Text = "1";
                    }
                    else if (auxiliar == 55)
                    {
                        Carac13.Text = "2";
                    }
                    else if (auxiliar == 56)
                    {
                        Carac13.Text = "3";
                    }
                    else if (auxiliar == 57)
                    {
                        Carac13.Text = "4";
                    }
                    else if (auxiliar == 58)
                    {
                        Carac13.Text = "5";
                    }
                    else if (auxiliar == 59)
                    {
                        Carac13.Text = "6";
                    }
                    else if (auxiliar == 60)
                    {
                        Carac13.Text = "7";
                    }
                    else if (auxiliar == 61)
                    {
                        Carac13.Text = "8";
                    }
                    else if (auxiliar == 62)
                    {
                        Carac13.Text = "9";
                    }
                }
                if (carac >= 14)
                {
                    auxiliar = senha.Next(1, 62);

                    Carac1.Visible = true;
                    Carac2.Visible = true;
                    Carac3.Visible = true;
                    Carac4.Visible = true;
                    Carac5.Visible = true;
                    Carac6.Visible = true;
                    Carac7.Visible = true;
                    Carac8.Visible = true;
                    Carac9.Visible = true;
                    Carac10.Visible = true;
                    Carac11.Visible = true;
                    Carac12.Visible = true;
                    Carac13.Visible = true;
                    Carac14.Visible = true;
                    Carac15.Visible = false;

                    if (auxiliar == 1)
                    {
                        Carac14.Text = "a";
                    }
                    else if (auxiliar == 2)
                    {
                        Carac14.Text = "b";
                    }
                    else if (auxiliar == 3)
                    {
                        Carac14.Text = "c";
                    }
                    else if (auxiliar == 4)
                    {
                        Carac14.Text = "d";
                    }
                    else if (auxiliar == 5)
                    {
                        Carac14.Text = "e";
                    }
                    else if (auxiliar == 6)
                    {
                        Carac14.Text = "f";
                    }
                    else if (auxiliar == 7)
                    {
                        Carac14.Text = "g";
                    }
                    else if (auxiliar == 8)
                    {
                        Carac14.Text = "h";
                    }
                    else if (auxiliar == 9)
                    {
                        Carac14.Text = "i";
                    }
                    else if (auxiliar == 10)
                    {
                        Carac14.Text = "j";
                    }
                    else if (auxiliar == 11)
                    {
                        Carac14.Text = "k";
                    }
                    else if (auxiliar == 12)
                    {
                        Carac14.Text = "l";
                    }
                    else if (auxiliar == 13)
                    {
                        Carac14.Text = "m";
                    }
                    else if (auxiliar == 14)
                    {
                        Carac14.Text = "n";
                    }
                    else if (auxiliar == 15)
                    {
                        Carac14.Text = "o";
                    }
                    else if (auxiliar == 16)
                    {
                        Carac14.Text = "p";
                    }
                    else if (auxiliar == 17)
                    {
                        Carac14.Text = "q";
                    }
                    else if (auxiliar == 18)
                    {
                        Carac14.Text = "r";
                    }
                    else if (auxiliar == 19)
                    {
                        Carac14.Text = "s";
                    }
                    else if (auxiliar == 20)
                    {
                        Carac14.Text = "t";
                    }
                    else if (auxiliar == 21)
                    {
                        Carac14.Text = "u";
                    }
                    else if (auxiliar == 22)
                    {
                        Carac14.Text = "v";
                    }
                    else if (auxiliar == 23)
                    {
                        Carac14.Text = "w";
                    }
                    else if (auxiliar == 24)
                    {
                        Carac14.Text = "x";
                    }
                    else if (auxiliar == 25)
                    {
                        Carac14.Text = "y";
                    }
                    else if (auxiliar == 26)
                    {
                        Carac14.Text = "z";
                    }
                    else if (auxiliar == 27)
                    {
                        Carac14.Text = "A";
                    }
                    else if (auxiliar == 28)
                    {
                        Carac14.Text = "B";
                    }
                    else if (auxiliar == 29)
                    {
                        Carac14.Text = "C";
                    }
                    else if (auxiliar == 30)
                    {
                        Carac14.Text = "D";
                    }
                    else if (auxiliar == 31)
                    {
                        Carac14.Text = "E";
                    }
                    else if (auxiliar == 32)
                    {
                        Carac14.Text = "F";
                    }
                    else if (auxiliar == 33)
                    {
                        Carac14.Text = "G";
                    }
                    else if (auxiliar == 34)
                    {
                        Carac14.Text = "H";
                    }
                    else if (auxiliar == 35)
                    {
                        Carac14.Text = "I";
                    }
                    else if (auxiliar == 36)
                    {
                        Carac14.Text = "J";
                    }
                    else if (auxiliar == 37)
                    {
                        Carac14.Text = "K";
                    }
                    else if (auxiliar == 38)
                    {
                        Carac14.Text = "L";
                    }
                    else if (auxiliar == 39)
                    {
                        Carac14.Text = "M";
                    }
                    else if (auxiliar == 40)
                    {
                        Carac14.Text = "N";
                    }
                    else if (auxiliar == 41)
                    {
                        Carac14.Text = "O";
                    }
                    else if (auxiliar == 42)
                    {
                        Carac14.Text = "P";
                    }
                    else if (auxiliar == 43)
                    {
                        Carac14.Text = "Q";
                    }
                    else if (auxiliar == 44)
                    {
                        Carac14.Text = "R";
                    }
                    else if (auxiliar == 45)
                    {
                        Carac14.Text = "S";
                    }
                    else if (auxiliar == 46)
                    {
                        Carac14.Text = "T";
                    }
                    else if (auxiliar == 47)
                    {
                        Carac14.Text = "U";
                    }
                    else if (auxiliar == 48)
                    {
                        Carac14.Text = "V";
                    }
                    else if (auxiliar == 49)
                    {
                        Carac14.Text = "W";
                    }
                    else if (auxiliar == 50)
                    {
                        Carac14.Text = "X";
                    }
                    else if (auxiliar == 51)
                    {
                        Carac14.Text = "Y";
                    }
                    else if (auxiliar == 52)
                    {
                        Carac14.Text = "Z";
                    }
                    else if (auxiliar == 53)
                    {
                        Carac14.Text = "0";
                    }
                    else if (auxiliar == 54)
                    {
                        Carac14.Text = "1";
                    }
                    else if (auxiliar == 55)
                    {
                        Carac14.Text = "2";
                    }
                    else if (auxiliar == 56)
                    {
                        Carac14.Text = "3";
                    }
                    else if (auxiliar == 57)
                    {
                        Carac14.Text = "4";
                    }
                    else if (auxiliar == 58)
                    {
                        Carac14.Text = "5";
                    }
                    else if (auxiliar == 59)
                    {
                        Carac14.Text = "6";
                    }
                    else if (auxiliar == 60)
                    {
                        Carac14.Text = "7";
                    }
                    else if (auxiliar == 61)
                    {
                        Carac14.Text = "8";
                    }
                    else if (auxiliar == 62)
                    {
                        Carac14.Text = "9";
                    }
                }
                if (carac >= 15)
                {
                    auxiliar = senha.Next(1, 62);

                    Carac1.Visible = true;
                    Carac2.Visible = true;
                    Carac3.Visible = true;
                    Carac4.Visible = true;
                    Carac5.Visible = true;
                    Carac6.Visible = true;
                    Carac7.Visible = true;
                    Carac8.Visible = true;
                    Carac9.Visible = true;
                    Carac10.Visible = true;
                    Carac11.Visible = true;
                    Carac12.Visible = true;
                    Carac13.Visible = true;
                    Carac14.Visible = true;
                    Carac15.Visible = true;

                    if (auxiliar == 1)
                    {
                        Carac15.Text = "a";
                    }
                    else if (auxiliar == 2)
                    {
                        Carac15.Text = "b";
                    }
                    else if (auxiliar == 3)
                    {
                        Carac15.Text = "c";
                    }
                    else if (auxiliar == 4)
                    {
                        Carac15.Text = "d";
                    }
                    else if (auxiliar == 5)
                    {
                        Carac15.Text = "e";
                    }
                    else if (auxiliar == 6)
                    {
                        Carac15.Text = "f";
                    }
                    else if (auxiliar == 7)
                    {
                        Carac15.Text = "g";
                    }
                    else if (auxiliar == 8)
                    {
                        Carac15.Text = "h";
                    }
                    else if (auxiliar == 9)
                    {
                        Carac15.Text = "i";
                    }
                    else if (auxiliar == 10)
                    {
                        Carac15.Text = "j";
                    }
                    else if (auxiliar == 11)
                    {
                        Carac15.Text = "k";
                    }
                    else if (auxiliar == 12)
                    {
                        Carac15.Text = "l";
                    }
                    else if (auxiliar == 13)
                    {
                        Carac15.Text = "m";
                    }
                    else if (auxiliar == 14)
                    {
                        Carac15.Text = "n";
                    }
                    else if (auxiliar == 15)
                    {
                        Carac15.Text = "o";
                    }
                    else if (auxiliar == 16)
                    {
                        Carac15.Text = "p";
                    }
                    else if (auxiliar == 17)
                    {
                        Carac15.Text = "q";
                    }
                    else if (auxiliar == 18)
                    {
                        Carac15.Text = "r";
                    }
                    else if (auxiliar == 19)
                    {
                        Carac15.Text = "s";
                    }
                    else if (auxiliar == 20)
                    {
                        Carac15.Text = "t";
                    }
                    else if (auxiliar == 21)
                    {
                        Carac15.Text = "u";
                    }
                    else if (auxiliar == 22)
                    {
                        Carac15.Text = "v";
                    }
                    else if (auxiliar == 23)
                    {
                        Carac15.Text = "w";
                    }
                    else if (auxiliar == 24)
                    {
                        Carac15.Text = "x";
                    }
                    else if (auxiliar == 25)
                    {
                        Carac15.Text = "y";
                    }
                    else if (auxiliar == 26)
                    {
                        Carac15.Text = "z";
                    }
                    else if (auxiliar == 27)
                    {
                        Carac15.Text = "A";
                    }
                    else if (auxiliar == 28)
                    {
                        Carac15.Text = "B";
                    }
                    else if (auxiliar == 29)
                    {
                        Carac15.Text = "C";
                    }
                    else if (auxiliar == 30)
                    {
                        Carac15.Text = "D";
                    }
                    else if (auxiliar == 31)
                    {
                        Carac15.Text = "E";
                    }
                    else if (auxiliar == 32)
                    {
                        Carac15.Text = "F";
                    }
                    else if (auxiliar == 33)
                    {
                        Carac15.Text = "G";
                    }
                    else if (auxiliar == 34)
                    {
                        Carac15.Text = "H";
                    }
                    else if (auxiliar == 35)
                    {
                        Carac15.Text = "I";
                    }
                    else if (auxiliar == 36)
                    {
                        Carac15.Text = "J";
                    }
                    else if (auxiliar == 37)
                    {
                        Carac15.Text = "K";
                    }
                    else if (auxiliar == 38)
                    {
                        Carac15.Text = "L";
                    }
                    else if (auxiliar == 39)
                    {
                        Carac15.Text = "M";
                    }
                    else if (auxiliar == 40)
                    {
                        Carac15.Text = "N";
                    }
                    else if (auxiliar == 41)
                    {
                        Carac15.Text = "O";
                    }
                    else if (auxiliar == 42)
                    {
                        Carac15.Text = "P";
                    }
                    else if (auxiliar == 43)
                    {
                        Carac15.Text = "Q";
                    }
                    else if (auxiliar == 44)
                    {
                        Carac15.Text = "R";
                    }
                    else if (auxiliar == 45)
                    {
                        Carac15.Text = "S";
                    }
                    else if (auxiliar == 46)
                    {
                        Carac15.Text = "T";
                    }
                    else if (auxiliar == 47)
                    {
                        Carac15.Text = "U";
                    }
                    else if (auxiliar == 48)
                    {
                        Carac15.Text = "V";
                    }
                    else if (auxiliar == 49)
                    {
                        Carac15.Text = "W";
                    }
                    else if (auxiliar == 50)
                    {
                        Carac15.Text = "X";
                    }
                    else if (auxiliar == 51)
                    {
                        Carac15.Text = "Y";
                    }
                    else if (auxiliar == 52)
                    {
                        Carac15.Text = "Z";
                    }
                    else if (auxiliar == 53)
                    {
                        Carac15.Text = "0";
                    }
                    else if (auxiliar == 54)
                    {
                        Carac15.Text = "1";
                    }
                    else if (auxiliar == 55)
                    {
                        Carac15.Text = "2";
                    }
                    else if (auxiliar == 56)
                    {
                        Carac15.Text = "3";
                    }
                    else if (auxiliar == 57)
                    {
                        Carac15.Text = "4";
                    }
                    else if (auxiliar == 58)
                    {
                        Carac15.Text = "5";
                    }
                    else if (auxiliar == 59)
                    {
                        Carac15.Text = "6";
                    }
                    else if (auxiliar == 60)
                    {
                        Carac15.Text = "7";
                    }
                    else if (auxiliar == 61)
                    {
                        Carac15.Text = "8";
                    }
                    else if (auxiliar == 62)
                    {
                        Carac15.Text = "9";
                    }
                }
                //62
            }

            else if (letra == 0 && mudacar == 0 && num == 1)
            {
                if (carac >= 1)
                {
                    auxiliar = senha.Next(0, 9);

                    Carac1.Visible = true;
                    Carac2.Visible = false;
                    Carac3.Visible = false;
                    Carac4.Visible = false;
                    Carac5.Visible = false;
                    Carac6.Visible = false;
                    Carac7.Visible = false;
                    Carac8.Visible = false;
                    Carac9.Visible = false;
                    Carac10.Visible = false;
                    Carac11.Visible = false;
                    Carac12.Visible = false;
                    Carac13.Visible = false;
                    Carac14.Visible = false;
                    Carac15.Visible = false;

                    Carac1.Text = Convert.ToString(auxiliar);
                }
                if (carac >= 2)
                {
                    auxiliar = senha.Next(0, 9);

                    Carac1.Visible = true;
                    Carac2.Visible = true;
                    Carac3.Visible = false;
                    Carac4.Visible = false;
                    Carac5.Visible = false;
                    Carac6.Visible = false;
                    Carac7.Visible = false;
                    Carac8.Visible = false;
                    Carac9.Visible = false;
                    Carac10.Visible = false;
                    Carac11.Visible = false;
                    Carac12.Visible = false;
                    Carac13.Visible = false;
                    Carac14.Visible = false;
                    Carac15.Visible = false;

                    Carac2.Text = Convert.ToString(auxiliar);

                }
                if (carac >= 3)
                {
                    auxiliar = senha.Next(0, 9);

                    Carac1.Visible = true;
                    Carac2.Visible = true;
                    Carac3.Visible = true;
                    Carac4.Visible = false;
                    Carac5.Visible = false;
                    Carac6.Visible = false;
                    Carac7.Visible = false;
                    Carac8.Visible = false;
                    Carac9.Visible = false;
                    Carac10.Visible = false;
                    Carac11.Visible = false;
                    Carac12.Visible = false;
                    Carac13.Visible = false;
                    Carac14.Visible = false;
                    Carac15.Visible = false;

                    Carac3.Text = Convert.ToString(auxiliar);

                }
                if (carac >= 4)
                {
                    auxiliar = senha.Next(0, 9);

                    Carac1.Visible = true;
                    Carac2.Visible = true;
                    Carac3.Visible = true;
                    Carac4.Visible = true;
                    Carac5.Visible = false;
                    Carac6.Visible = false;
                    Carac7.Visible = false;
                    Carac8.Visible = false;
                    Carac9.Visible = false;
                    Carac10.Visible = false;
                    Carac11.Visible = false;
                    Carac12.Visible = false;
                    Carac13.Visible = false;
                    Carac14.Visible = false;
                    Carac15.Visible = false;

                    Carac4.Text = Convert.ToString(auxiliar);

                }
                if (carac >= 5)
                {
                    auxiliar = senha.Next(0, 9);

                    Carac1.Visible = true;
                    Carac2.Visible = true;
                    Carac3.Visible = true;
                    Carac4.Visible = true;
                    Carac5.Visible = true;
                    Carac6.Visible = false;
                    Carac7.Visible = false;
                    Carac8.Visible = false;
                    Carac9.Visible = false;
                    Carac10.Visible = false;
                    Carac11.Visible = false;
                    Carac12.Visible = false;
                    Carac13.Visible = false;
                    Carac14.Visible = false;
                    Carac15.Visible = false;

                    Carac5.Text = Convert.ToString(auxiliar);

                }
                if (carac >= 6)
                {
                    auxiliar = senha.Next(0, 9);

                    Carac1.Visible = true;
                    Carac2.Visible = true;
                    Carac3.Visible = true;
                    Carac4.Visible = true;
                    Carac5.Visible = true;
                    Carac6.Visible = true;
                    Carac7.Visible = false;
                    Carac8.Visible = false;
                    Carac9.Visible = false;
                    Carac10.Visible = false;
                    Carac11.Visible = false;
                    Carac12.Visible = false;
                    Carac13.Visible = false;
                    Carac14.Visible = false;
                    Carac15.Visible = false;

                    Carac6.Text = Convert.ToString(auxiliar);

                }
                if (carac >= 7)
                {
                    auxiliar = senha.Next(0, 9);

                    Carac1.Visible = true;
                    Carac2.Visible = true;
                    Carac3.Visible = true;
                    Carac4.Visible = true;
                    Carac5.Visible = true;
                    Carac6.Visible = true;
                    Carac7.Visible = true;
                    Carac8.Visible = false;
                    Carac9.Visible = false;
                    Carac10.Visible = false;
                    Carac11.Visible = false;
                    Carac12.Visible = false;
                    Carac13.Visible = false;
                    Carac14.Visible = false;
                    Carac15.Visible = false;

                    Carac7.Text = Convert.ToString(auxiliar);

                }
                if (carac >= 8)
                {
                    auxiliar = senha.Next(0, 9);

                    Carac1.Visible = true;
                    Carac2.Visible = true;
                    Carac3.Visible = true;
                    Carac4.Visible = true;
                    Carac5.Visible = true;
                    Carac6.Visible = true;
                    Carac7.Visible = true;
                    Carac8.Visible = true;
                    Carac9.Visible = false;
                    Carac10.Visible = false;
                    Carac11.Visible = false;
                    Carac12.Visible = false;
                    Carac13.Visible = false;
                    Carac14.Visible = false;
                    Carac15.Visible = false;

                    Carac8.Text = Convert.ToString(auxiliar);

                }
                if (carac >= 9)
                {
                    auxiliar = senha.Next(0, 9);

                    Carac1.Visible = true;
                    Carac2.Visible = true;
                    Carac3.Visible = true;
                    Carac4.Visible = true;
                    Carac5.Visible = true;
                    Carac6.Visible = true;
                    Carac7.Visible = true;
                    Carac8.Visible = true;
                    Carac9.Visible = true;
                    Carac10.Visible = false;
                    Carac11.Visible = false;
                    Carac12.Visible = false;
                    Carac13.Visible = false;
                    Carac14.Visible = false;
                    Carac15.Visible = false;

                    Carac9.Text = Convert.ToString(auxiliar);

                }
                if (carac >= 10)
                {
                    auxiliar = senha.Next(0, 9);

                    Carac1.Visible = true;
                    Carac2.Visible = true;
                    Carac3.Visible = true;
                    Carac4.Visible = true;
                    Carac5.Visible = true;
                    Carac6.Visible = true;
                    Carac7.Visible = true;
                    Carac8.Visible = true;
                    Carac9.Visible = true;
                    Carac10.Visible = true;
                    Carac11.Visible = false;
                    Carac12.Visible = false;
                    Carac13.Visible = false;
                    Carac14.Visible = false;
                    Carac15.Visible = false;

                    Carac10.Text = Convert.ToString(auxiliar);

                }
                if (carac >= 11)
                {
                    auxiliar = senha.Next(0, 9);

                    Carac1.Visible = true;
                    Carac2.Visible = true;
                    Carac3.Visible = true;
                    Carac4.Visible = true;
                    Carac5.Visible = true;
                    Carac6.Visible = true;
                    Carac7.Visible = true;
                    Carac8.Visible = true;
                    Carac9.Visible = true;
                    Carac10.Visible = true;
                    Carac11.Visible = true;
                    Carac12.Visible = false;
                    Carac13.Visible = false;
                    Carac14.Visible = false;
                    Carac15.Visible = false;

                    Carac11.Text = Convert.ToString(auxiliar);

                }
                if (carac >= 12)
                {
                    auxiliar = senha.Next(0, 9);

                    Carac1.Visible = true;
                    Carac2.Visible = false;
                    Carac3.Visible = false;
                    Carac4.Visible = false;
                    Carac5.Visible = false;
                    Carac6.Visible = false;
                    Carac7.Visible = false;
                    Carac8.Visible = false;
                    Carac9.Visible = false;
                    Carac10.Visible = false;
                    Carac11.Visible = false;
                    Carac12.Visible = false;
                    Carac13.Visible = false;
                    Carac14.Visible = false;
                    Carac15.Visible = false;

                    Carac12.Text = Convert.ToString(auxiliar);

                }
                if (carac >= 13)
                {
                    auxiliar = senha.Next(0, 9);

                    Carac1.Visible = true;
                    Carac2.Visible = false;
                    Carac3.Visible = false;
                    Carac4.Visible = false;
                    Carac5.Visible = false;
                    Carac6.Visible = false;
                    Carac7.Visible = false;
                    Carac8.Visible = false;
                    Carac9.Visible = false;
                    Carac10.Visible = false;
                    Carac11.Visible = false;
                    Carac12.Visible = false;
                    Carac13.Visible = false;
                    Carac14.Visible = false;
                    Carac15.Visible = false;

                    Carac13.Text = Convert.ToString(auxiliar);

                }
                if (carac >= 14)
                {
                    auxiliar = senha.Next(0, 9);

                    Carac1.Visible = true;
                    Carac2.Visible = true;
                    Carac3.Visible = true;
                    Carac4.Visible = true;
                    Carac5.Visible = true;
                    Carac6.Visible = true;
                    Carac7.Visible = true;
                    Carac8.Visible = true;
                    Carac9.Visible = true;
                    Carac10.Visible = true;
                    Carac11.Visible = true;
                    Carac12.Visible = true;
                    Carac13.Visible = true;
                    Carac14.Visible = true;
                    Carac15.Visible = false;

                    Carac14.Text = Convert.ToString(auxiliar);

                }
                if (carac >= 15)
                {
                    auxiliar = senha.Next(0, 9);

                    Carac1.Visible = true;
                    Carac2.Visible = true;
                    Carac3.Visible = true;
                    Carac4.Visible = true;
                    Carac5.Visible = true;
                    Carac6.Visible = true;
                    Carac7.Visible = true;
                    Carac8.Visible = true;
                    Carac9.Visible = true;
                    Carac10.Visible = true;
                    Carac11.Visible = true;
                    Carac12.Visible = true;
                    Carac13.Visible = true;
                    Carac14.Visible = true;
                    Carac15.Visible = true;

                    Carac15.Text = Convert.ToString(auxiliar);

                }
                //10
            }

            else if (letra == 0 && mudacar == 1 && num == 1)
            { 
                if (carac >= 1)
                    {
                        auxiliar = senha.Next(0, 9);

                        Carac1.Visible = true;
                        Carac2.Visible = false;
                        Carac3.Visible = false;
                        Carac4.Visible = false;
                        Carac5.Visible = false;
                        Carac6.Visible = false;
                        Carac7.Visible = false;
                        Carac8.Visible = false;
                        Carac9.Visible = false;
                        Carac10.Visible = false;
                        Carac11.Visible = false;
                        Carac12.Visible = false;
                        Carac13.Visible = false;
                        Carac14.Visible = false;
                        Carac15.Visible = false;

                        Carac1.Text = Convert.ToString(auxiliar);
                    }
                if (carac >= 2)
                    {
                        auxiliar = senha.Next(0, 9);

                        Carac1.Visible = true;
                        Carac2.Visible = true;
                        Carac3.Visible = false;
                        Carac4.Visible = false;
                        Carac5.Visible = false;
                        Carac6.Visible = false;
                        Carac7.Visible = false;
                        Carac8.Visible = false;
                        Carac9.Visible = false;
                        Carac10.Visible = false;
                        Carac11.Visible = false;
                        Carac12.Visible = false;
                        Carac13.Visible = false;
                        Carac14.Visible = false;
                        Carac15.Visible = false;

                        Carac2.Text = Convert.ToString(auxiliar);

                    }
                if (carac >= 3)
                    {
                        auxiliar = senha.Next(0, 9);

                        Carac1.Visible = true;
                        Carac2.Visible = true;
                        Carac3.Visible = true;
                        Carac4.Visible = false;
                        Carac5.Visible = false;
                        Carac6.Visible = false;
                        Carac7.Visible = false;
                        Carac8.Visible = false;
                        Carac9.Visible = false;
                        Carac10.Visible = false;
                        Carac11.Visible = false;
                        Carac12.Visible = false;
                        Carac13.Visible = false;
                        Carac14.Visible = false;
                        Carac15.Visible = false;

                        Carac3.Text = Convert.ToString(auxiliar);

                    }
                if (carac >= 4)
                    {
                        auxiliar = senha.Next(0, 9);

                        Carac1.Visible = true;
                        Carac2.Visible = true;
                        Carac3.Visible = true;
                        Carac4.Visible = true;
                        Carac5.Visible = false;
                        Carac6.Visible = false;
                        Carac7.Visible = false;
                        Carac8.Visible = false;
                        Carac9.Visible = false;
                        Carac10.Visible = false;
                        Carac11.Visible = false;
                        Carac12.Visible = false;
                        Carac13.Visible = false;
                        Carac14.Visible = false;
                        Carac15.Visible = false;

                        Carac4.Text = Convert.ToString(auxiliar);

                    }
                if (carac >= 5)
                    {
                        auxiliar = senha.Next(0, 9);

                        Carac1.Visible = true;
                        Carac2.Visible = true;
                        Carac3.Visible = true;
                        Carac4.Visible = true;
                        Carac5.Visible = true;
                        Carac6.Visible = false;
                        Carac7.Visible = false;
                        Carac8.Visible = false;
                        Carac9.Visible = false;
                        Carac10.Visible = false;
                        Carac11.Visible = false;
                        Carac12.Visible = false;
                        Carac13.Visible = false;
                        Carac14.Visible = false;
                        Carac15.Visible = false;

                        Carac5.Text = Convert.ToString(auxiliar);

                    }
                if (carac >= 6)
                    {
                        auxiliar = senha.Next(0, 9);

                        Carac1.Visible = true;
                        Carac2.Visible = true;
                        Carac3.Visible = true;
                        Carac4.Visible = true;
                        Carac5.Visible = true;
                        Carac6.Visible = true;
                        Carac7.Visible = false;
                        Carac8.Visible = false;
                        Carac9.Visible = false;
                        Carac10.Visible = false;
                        Carac11.Visible = false;
                        Carac12.Visible = false;
                        Carac13.Visible = false;
                        Carac14.Visible = false;
                        Carac15.Visible = false;

                        Carac6.Text = Convert.ToString(auxiliar);

                    }
                if (carac >= 7)
                    {
                        auxiliar = senha.Next(0, 9);

                        Carac1.Visible = true;
                        Carac2.Visible = true;
                        Carac3.Visible = true;
                        Carac4.Visible = true;
                        Carac5.Visible = true;
                        Carac6.Visible = true;
                        Carac7.Visible = true;
                        Carac8.Visible = false;
                        Carac9.Visible = false;
                        Carac10.Visible = false;
                        Carac11.Visible = false;
                        Carac12.Visible = false;
                        Carac13.Visible = false;
                        Carac14.Visible = false;
                        Carac15.Visible = false;

                        Carac7.Text = Convert.ToString(auxiliar);

                    }
                if (carac >= 8)
                    {
                        auxiliar = senha.Next(0, 9);

                        Carac1.Visible = true;
                        Carac2.Visible = true;
                        Carac3.Visible = true;
                        Carac4.Visible = true;
                        Carac5.Visible = true;
                        Carac6.Visible = true;
                        Carac7.Visible = true;
                        Carac8.Visible = true;
                        Carac9.Visible = false;
                        Carac10.Visible = false;
                        Carac11.Visible = false;
                        Carac12.Visible = false;
                        Carac13.Visible = false;
                        Carac14.Visible = false;
                        Carac15.Visible = false;

                        Carac8.Text = Convert.ToString(auxiliar);

                    }
                if (carac >= 9)
                    {
                        auxiliar = senha.Next(0, 9);

                        Carac1.Visible = true;
                        Carac2.Visible = true;
                        Carac3.Visible = true;
                        Carac4.Visible = true;
                        Carac5.Visible = true;
                        Carac6.Visible = true;
                        Carac7.Visible = true;
                        Carac8.Visible = true;
                        Carac9.Visible = true;
                        Carac10.Visible = false;
                        Carac11.Visible = false;
                        Carac12.Visible = false;
                        Carac13.Visible = false;
                        Carac14.Visible = false;
                        Carac15.Visible = false;

                        Carac9.Text = Convert.ToString(auxiliar);

                    }
                if (carac >= 10)
                    {
                        auxiliar = senha.Next(0, 9);

                        Carac1.Visible = true;
                        Carac2.Visible = true;
                        Carac3.Visible = true;
                        Carac4.Visible = true;
                        Carac5.Visible = true;
                        Carac6.Visible = true;
                        Carac7.Visible = true;
                        Carac8.Visible = true;
                        Carac9.Visible = true;
                        Carac10.Visible = true;
                        Carac11.Visible = false;
                        Carac12.Visible = false;
                        Carac13.Visible = false;
                        Carac14.Visible = false;
                        Carac15.Visible = false;

                        Carac10.Text = Convert.ToString(auxiliar);

                    }
                if (carac >= 11)
                    {
                        auxiliar = senha.Next(0, 9);

                        Carac1.Visible = true;
                        Carac2.Visible = true;
                        Carac3.Visible = true;
                        Carac4.Visible = true;
                        Carac5.Visible = true;
                        Carac6.Visible = true;
                        Carac7.Visible = true;
                        Carac8.Visible = true;
                        Carac9.Visible = true;
                        Carac10.Visible = true;
                        Carac11.Visible = true;
                        Carac12.Visible = false;
                        Carac13.Visible = false;
                        Carac14.Visible = false;
                        Carac15.Visible = false;

                        Carac11.Text = Convert.ToString(auxiliar);

                    }
                if (carac >= 12)
                    {
                        auxiliar = senha.Next(0, 9);

                        Carac1.Visible = true;
                        Carac2.Visible = false;
                        Carac3.Visible = false;
                        Carac4.Visible = false;
                        Carac5.Visible = false;
                        Carac6.Visible = false;
                        Carac7.Visible = false;
                        Carac8.Visible = false;
                        Carac9.Visible = false;
                        Carac10.Visible = false;
                        Carac11.Visible = false;
                        Carac12.Visible = false;
                        Carac13.Visible = false;
                        Carac14.Visible = false;
                        Carac15.Visible = false;

                        Carac12.Text = Convert.ToString(auxiliar);

                    }
                if (carac >= 13)
                    {
                        auxiliar = senha.Next(0, 9);

                        Carac1.Visible = true;
                        Carac2.Visible = false;
                        Carac3.Visible = false;
                        Carac4.Visible = false;
                        Carac5.Visible = false;
                        Carac6.Visible = false;
                        Carac7.Visible = false;
                        Carac8.Visible = false;
                        Carac9.Visible = false;
                        Carac10.Visible = false;
                        Carac11.Visible = false;
                        Carac12.Visible = false;
                        Carac13.Visible = false;
                        Carac14.Visible = false;
                        Carac15.Visible = false;

                        Carac13.Text = Convert.ToString(auxiliar);

                }
                if (carac >= 14)
                {
                        auxiliar = senha.Next(0, 9);

                    Carac1.Visible = true;
                    Carac2.Visible = true;
                    Carac3.Visible = true;
                    Carac4.Visible = true;
                    Carac5.Visible = true;
                    Carac6.Visible = true;
                    Carac7.Visible = true;
                    Carac8.Visible = true;
                    Carac9.Visible = true;
                    Carac10.Visible = true;
                    Carac11.Visible = true;
                    Carac12.Visible = true;
                    Carac13.Visible = true;
                    Carac14.Visible = true;
                    Carac15.Visible = false;

                    Carac14.Text = Convert.ToString(auxiliar);

                }
                if (carac >= 15)
                {
                    auxiliar = senha.Next(0, 9);

                        Carac1.Visible = true;
                        Carac2.Visible = true;
                        Carac3.Visible = true;
                        Carac4.Visible = true;
                        Carac5.Visible = true;
                        Carac6.Visible = true;
                        Carac7.Visible = true;
                        Carac8.Visible = true;
                        Carac9.Visible = true;
                        Carac10.Visible = true;
                        Carac11.Visible = true;
                        Carac12.Visible = true;
                        Carac13.Visible = true;
                        Carac14.Visible = true;
                        Carac15.Visible = true;

                        Carac15.Text = Convert.ToString(auxiliar);

                }
                //10
            }
            else if(letra == 1 && mudacar == 0 && num == 1)
            {
                if (carac >= 1)
                {
                    auxiliar = senha.Next(1, 36);

                    Carac1.Visible = true;
                    Carac2.Visible = false;
                    Carac3.Visible = false;
                    Carac4.Visible = false;
                    Carac5.Visible = false;
                    Carac6.Visible = false;
                    Carac7.Visible = false;
                    Carac8.Visible = false;
                    Carac9.Visible = false;
                    Carac10.Visible = false;
                    Carac11.Visible = false;
                    Carac12.Visible = false;
                    Carac13.Visible = false;
                    Carac14.Visible = false;
                    Carac15.Visible = false;

                    if (auxiliar == 1)
                    {
                        Carac1.Text = "a";
                    }
                    else if (auxiliar == 2)
                    {
                        Carac1.Text = "b";
                    }
                    else if (auxiliar == 3)
                    {
                        Carac1.Text = "c";
                    }
                    else if (auxiliar == 4)
                    {
                        Carac1.Text = "d";
                    }
                    else if (auxiliar == 5)
                    {
                        Carac1.Text = "e";
                    }
                    else if (auxiliar == 6)
                    {
                        Carac1.Text = "f";
                    }
                    else if (auxiliar == 7)
                    {
                        Carac1.Text = "g";
                    }
                    else if (auxiliar == 8)
                    {
                        Carac1.Text = "h";
                    }
                    else if (auxiliar == 9)
                    {
                        Carac1.Text = "i";
                    }
                    else if (auxiliar == 10)
                    {
                        Carac1.Text = "j";
                    }
                    else if (auxiliar == 11)
                    {
                        Carac1.Text = "k";
                    }
                    else if (auxiliar == 12)
                    {
                        Carac1.Text = "l";
                    }
                    else if (auxiliar == 13)
                    {
                        Carac1.Text = "m";
                    }
                    else if (auxiliar == 14)
                    {
                        Carac1.Text = "n";
                    }
                    else if (auxiliar == 15)
                    {
                        Carac1.Text = "o";
                    }
                    else if (auxiliar == 16)
                    {
                        Carac1.Text = "p";
                    }
                    else if (auxiliar == 17)
                    {
                        Carac1.Text = "q";
                    }
                    else if (auxiliar == 18)
                    {
                        Carac1.Text = "r";
                    }
                    else if (auxiliar == 19)
                    {
                        Carac1.Text = "s";
                    }
                    else if (auxiliar == 20)
                    {
                        Carac1.Text = "t";
                    }
                    else if (auxiliar == 21)
                    {
                        Carac1.Text = "u";
                    }
                    else if (auxiliar == 22)
                    {
                        Carac1.Text = "v";
                    }
                    else if (auxiliar == 23)
                    {
                        Carac1.Text = "w";
                    }
                    else if (auxiliar == 24)
                    {
                        Carac1.Text = "x";
                    }
                    else if (auxiliar == 25)
                    {
                        Carac1.Text = "y";
                    }
                    else if (auxiliar == 26)
                    {
                        Carac1.Text = "z";
                    }
                    else if (auxiliar == 27)
                    {
                        Carac1.Text = "0";
                    }
                    else if (auxiliar == 28)
                    {
                        Carac1.Text = "1";
                    }
                    else if (auxiliar == 29)
                    {
                        Carac1.Text = "2";
                    }
                    else if (auxiliar == 30)
                    {
                        Carac1.Text = "3";
                    }
                    else if (auxiliar == 31)
                    {
                        Carac1.Text = "4";
                    }
                    else if (auxiliar == 32)
                    {
                        Carac1.Text = "5";
                    }
                    else if (auxiliar == 33)
                    {
                        Carac1.Text = "6";
                    }
                    else if (auxiliar == 34)
                    {
                        Carac1.Text = "7";
                    }
                    else if (auxiliar == 35)
                    {
                        Carac1.Text = "8";
                    }
                    else if (auxiliar == 36)
                    {
                        Carac1.Text = "9";
                    }
                }
                if (carac >= 2)
                {
                    auxiliar = senha.Next(1, 36);

                    Carac1.Visible = true;
                    Carac2.Visible = true;
                    Carac3.Visible = false;
                    Carac4.Visible = false;
                    Carac5.Visible = false;
                    Carac6.Visible = false;
                    Carac7.Visible = false;
                    Carac8.Visible = false;
                    Carac9.Visible = false;
                    Carac10.Visible = false;
                    Carac11.Visible = false;
                    Carac12.Visible = false;
                    Carac13.Visible = false;
                    Carac14.Visible = false;
                    Carac15.Visible = false;

                    if (auxiliar == 1)
                    {
                        Carac2.Text = "a";
                    }
                    else if (auxiliar == 2)
                    {
                        Carac2.Text = "b";
                    }
                    else if (auxiliar == 3)
                    {
                        Carac2.Text = "c";
                    }
                    else if (auxiliar == 4)
                    {
                        Carac2.Text = "d";
                    }
                    else if (auxiliar == 5)
                    {
                        Carac2.Text = "e";
                    }
                    else if (auxiliar == 6)
                    {
                        Carac2.Text = "f";
                    }
                    else if (auxiliar == 7)
                    {
                        Carac2.Text = "g";
                    }
                    else if (auxiliar == 8)
                    {
                        Carac2.Text = "h";
                    }
                    else if (auxiliar == 9)
                    {
                        Carac2.Text = "i";
                    }
                    else if (auxiliar == 10)
                    {
                        Carac2.Text = "j";
                    }
                    else if (auxiliar == 11)
                    {
                        Carac2.Text = "k";
                    }
                    else if (auxiliar == 12)
                    {
                        Carac2.Text = "l";
                    }
                    else if (auxiliar == 13)
                    {
                        Carac2.Text = "m";
                    }
                    else if (auxiliar == 14)
                    {
                        Carac2.Text = "n";
                    }
                    else if (auxiliar == 15)
                    {
                        Carac2.Text = "o";
                    }
                    else if (auxiliar == 16)
                    {
                        Carac2.Text = "p";
                    }
                    else if (auxiliar == 17)
                    {
                        Carac2.Text = "q";
                    }
                    else if (auxiliar == 18)
                    {
                        Carac2.Text = "r";
                    }
                    else if (auxiliar == 19)
                    {
                        Carac2.Text = "s";
                    }
                    else if (auxiliar == 20)
                    {
                        Carac2.Text = "t";
                    }
                    else if (auxiliar == 21)
                    {
                        Carac2.Text = "u";
                    }
                    else if (auxiliar == 22)
                    {
                        Carac2.Text = "v";
                    }
                    else if (auxiliar == 23)
                    {
                        Carac2.Text = "w";
                    }
                    else if (auxiliar == 24)
                    {
                        Carac2.Text = "x";
                    }
                    else if (auxiliar == 25)
                    {
                        Carac2.Text = "y";
                    }
                    else if (auxiliar == 26)
                    {
                        Carac2.Text = "z";
                    }
                    else if (auxiliar == 27)
                    {
                        Carac2.Text = "0";
                    }
                    else if (auxiliar == 28)
                    {
                        Carac2.Text = "1";
                    }
                    else if (auxiliar == 29)
                    {
                        Carac2.Text = "2";
                    }
                    else if (auxiliar == 30)
                    {
                        Carac2.Text = "3";
                    }
                    else if (auxiliar == 31)
                    {
                        Carac2.Text = "4";
                    }
                    else if (auxiliar == 32)
                    {
                        Carac2.Text = "5";
                    }
                    else if (auxiliar == 33)
                    {
                        Carac2.Text = "6";
                    }
                    else if (auxiliar == 34)
                    {
                        Carac2.Text = "7";
                    }
                    else if (auxiliar == 35)
                    {
                        Carac2.Text = "8";
                    }
                    else if (auxiliar == 36)
                    {
                        Carac2.Text = "9";
                    }
                }
                if (carac >= 3)
                {
                    auxiliar = senha.Next(1, 36);

                    Carac1.Visible = true;
                    Carac2.Visible = true;
                    Carac3.Visible = true;
                    Carac4.Visible = false;
                    Carac5.Visible = false;
                    Carac6.Visible = false;
                    Carac7.Visible = false;
                    Carac8.Visible = false;
                    Carac9.Visible = false;
                    Carac10.Visible = false;
                    Carac11.Visible = false;
                    Carac12.Visible = false;
                    Carac13.Visible = false;
                    Carac14.Visible = false;
                    Carac15.Visible = false;

                    if (auxiliar == 1)
                    {
                        Carac3.Text = "a";
                    }
                    else if (auxiliar == 2)
                    {
                        Carac3.Text = "b";
                    }
                    else if (auxiliar == 3)
                    {
                        Carac3.Text = "c";
                    }
                    else if (auxiliar == 4)
                    {
                        Carac3.Text = "d";
                    }
                    else if (auxiliar == 5)
                    {
                        Carac3.Text = "e";
                    }
                    else if (auxiliar == 6)
                    {
                        Carac3.Text = "f";
                    }
                    else if (auxiliar == 7)
                    {
                        Carac3.Text = "g";
                    }
                    else if (auxiliar == 8)
                    {
                        Carac3.Text = "h";
                    }
                    else if (auxiliar == 9)
                    {
                        Carac3.Text = "i";
                    }
                    else if (auxiliar == 10)
                    {
                        Carac3.Text = "j";
                    }
                    else if (auxiliar == 11)
                    {
                        Carac3.Text = "k";
                    }
                    else if (auxiliar == 12)
                    {
                        Carac3.Text = "l";
                    }
                    else if (auxiliar == 13)
                    {
                        Carac3.Text = "m";
                    }
                    else if (auxiliar == 14)
                    {
                        Carac3.Text = "n";
                    }
                    else if (auxiliar == 15)
                    {
                        Carac3.Text = "o";
                    }
                    else if (auxiliar == 16)
                    {
                        Carac3.Text = "p";
                    }
                    else if (auxiliar == 17)
                    {
                        Carac3.Text = "q";
                    }
                    else if (auxiliar == 18)
                    {
                        Carac3.Text = "r";
                    }
                    else if (auxiliar == 19)
                    {
                        Carac3.Text = "s";
                    }
                    else if (auxiliar == 20)
                    {
                        Carac3.Text = "t";
                    }
                    else if (auxiliar == 21)
                    {
                        Carac3.Text = "u";
                    }
                    else if (auxiliar == 22)
                    {
                        Carac3.Text = "v";
                    }
                    else if (auxiliar == 23)
                    {
                        Carac3.Text = "w";
                    }
                    else if (auxiliar == 24)
                    {
                        Carac3.Text = "x";
                    }
                    else if (auxiliar == 25)
                    {
                        Carac3.Text = "y";
                    }
                    else if (auxiliar == 26)
                    {
                        Carac3.Text = "z";
                    }
                    else if (auxiliar == 27)
                    {
                        Carac3.Text = "0";
                    }
                    else if (auxiliar == 28)
                    {
                        Carac3.Text = "1";
                    }
                    else if (auxiliar == 29)
                    {
                        Carac3.Text = "2";
                    }
                    else if (auxiliar == 30)
                    {
                        Carac3.Text = "3";
                    }
                    else if (auxiliar == 31)
                    {
                        Carac3.Text = "4";
                    }
                    else if (auxiliar == 32)
                    {
                        Carac3.Text = "5";
                    }
                    else if (auxiliar == 33)
                    {
                        Carac3.Text = "6";
                    }
                    else if (auxiliar == 34)
                    {
                        Carac3.Text = "7";
                    }
                    else if (auxiliar == 35)
                    {
                        Carac3.Text = "8";
                    }
                    else if (auxiliar == 36)
                    {
                        Carac3.Text = "9";
                    }
                }
                if (carac >= 4)
                {
                    auxiliar = senha.Next(1, 36);

                    Carac1.Visible = true;
                    Carac2.Visible = true;
                    Carac3.Visible = true;
                    Carac4.Visible = true;
                    Carac5.Visible = false;
                    Carac6.Visible = false;
                    Carac7.Visible = false;
                    Carac8.Visible = false;
                    Carac9.Visible = false;
                    Carac10.Visible = false;
                    Carac11.Visible = false;
                    Carac12.Visible = false;
                    Carac13.Visible = false;
                    Carac14.Visible = false;
                    Carac15.Visible = false;

                    if (auxiliar == 1)
                    {
                        Carac4.Text = "a";
                    }
                    else if (auxiliar == 2)
                    {
                        Carac4.Text = "b";
                    }
                    else if (auxiliar == 3)
                    {
                        Carac4.Text = "c";
                    }
                    else if (auxiliar == 4)
                    {
                        Carac4.Text = "d";
                    }
                    else if (auxiliar == 5)
                    {
                        Carac4.Text = "e";
                    }
                    else if (auxiliar == 6)
                    {
                        Carac4.Text = "f";
                    }
                    else if (auxiliar == 7)
                    {
                        Carac4.Text = "g";
                    }
                    else if (auxiliar == 8)
                    {
                        Carac4.Text = "h";
                    }
                    else if (auxiliar == 9)
                    {
                        Carac4.Text = "i";
                    }
                    else if (auxiliar == 10)
                    {
                        Carac4.Text = "j";
                    }
                    else if (auxiliar == 11)
                    {
                        Carac4.Text = "k";
                    }
                    else if (auxiliar == 12)
                    {
                        Carac4.Text = "l";
                    }
                    else if (auxiliar == 13)
                    {
                        Carac4.Text = "m";
                    }
                    else if (auxiliar == 14)
                    {
                        Carac4.Text = "n";
                    }
                    else if (auxiliar == 15)
                    {
                        Carac4.Text = "o";
                    }
                    else if (auxiliar == 16)
                    {
                        Carac4.Text = "p";
                    }
                    else if (auxiliar == 17)
                    {
                        Carac4.Text = "q";
                    }
                    else if (auxiliar == 18)
                    {
                        Carac4.Text = "r";
                    }
                    else if (auxiliar == 19)
                    {
                        Carac4.Text = "s";
                    }
                    else if (auxiliar == 20)
                    {
                        Carac4.Text = "t";
                    }
                    else if (auxiliar == 21)
                    {
                        Carac4.Text = "u";
                    }
                    else if (auxiliar == 22)
                    {
                        Carac4.Text = "v";
                    }
                    else if (auxiliar == 23)
                    {
                        Carac4.Text = "w";
                    }
                    else if (auxiliar == 24)
                    {
                        Carac4.Text = "x";
                    }
                    else if (auxiliar == 25)
                    {
                        Carac4.Text = "y";
                    }
                    else if (auxiliar == 26)
                    {
                        Carac4.Text = "z";
                    }
                    else if (auxiliar == 27)
                    {
                        Carac4.Text = "0";
                    }
                    else if (auxiliar == 28)
                    {
                        Carac4.Text = "1";
                    }
                    else if (auxiliar == 29)
                    {
                        Carac4.Text = "2";
                    }
                    else if (auxiliar == 30)
                    {
                        Carac4.Text = "3";
                    }
                    else if (auxiliar == 31)
                    {
                        Carac4.Text = "4";
                    }
                    else if (auxiliar == 32)
                    {
                        Carac4.Text = "5";
                    }
                    else if (auxiliar == 33)
                    {
                        Carac4.Text = "6";
                    }
                    else if (auxiliar == 34)
                    {
                        Carac4.Text = "7";
                    }
                    else if (auxiliar == 35)
                    {
                        Carac4.Text = "8";
                    }
                    else if (auxiliar == 36)
                    {
                        Carac4.Text = "9";
                    }
                }
                if (carac >= 5)
                {
                    auxiliar = senha.Next(1, 36);

                    Carac1.Visible = true;
                    Carac2.Visible = true;
                    Carac3.Visible = true;
                    Carac4.Visible = true;
                    Carac5.Visible = true;
                    Carac6.Visible = false;
                    Carac7.Visible = false;
                    Carac8.Visible = false;
                    Carac9.Visible = false;
                    Carac10.Visible = false;
                    Carac11.Visible = false;
                    Carac12.Visible = false;
                    Carac13.Visible = false;
                    Carac14.Visible = false;
                    Carac15.Visible = false;

                    if (auxiliar == 1)
                    {
                        Carac5.Text = "a";
                    }
                    else if (auxiliar == 2)
                    {
                        Carac5.Text = "b";
                    }
                    else if (auxiliar == 3)
                    {
                        Carac5.Text = "c";
                    }
                    else if (auxiliar == 4)
                    {
                        Carac5.Text = "d";
                    }
                    else if (auxiliar == 5)
                    {
                        Carac5.Text = "e";
                    }
                    else if (auxiliar == 6)
                    {
                        Carac5.Text = "f";
                    }
                    else if (auxiliar == 7)
                    {
                        Carac5.Text = "g";
                    }
                    else if (auxiliar == 8)
                    {
                        Carac5.Text = "h";
                    }
                    else if (auxiliar == 9)
                    {
                        Carac5.Text = "i";
                    }
                    else if (auxiliar == 10)
                    {
                        Carac5.Text = "j";
                    }
                    else if (auxiliar == 11)
                    {
                        Carac5.Text = "k";
                    }
                    else if (auxiliar == 12)
                    {
                        Carac5.Text = "l";
                    }
                    else if (auxiliar == 13)
                    {
                        Carac5.Text = "m";
                    }
                    else if (auxiliar == 14)
                    {
                        Carac5.Text = "n";
                    }
                    else if (auxiliar == 15)
                    {
                        Carac5.Text = "o";
                    }
                    else if (auxiliar == 16)
                    {
                        Carac5.Text = "p";
                    }
                    else if (auxiliar == 17)
                    {
                        Carac5.Text = "q";
                    }
                    else if (auxiliar == 18)
                    {
                        Carac5.Text = "r";
                    }
                    else if (auxiliar == 19)
                    {
                        Carac5.Text = "s";
                    }
                    else if (auxiliar == 20)
                    {
                        Carac5.Text = "t";
                    }
                    else if (auxiliar == 21)
                    {
                        Carac5.Text = "u";
                    }
                    else if (auxiliar == 22)
                    {
                        Carac5.Text = "v";
                    }
                    else if (auxiliar == 23)
                    {
                        Carac5.Text = "w";
                    }
                    else if (auxiliar == 24)
                    {
                        Carac5.Text = "x";
                    }
                    else if (auxiliar == 25)
                    {
                        Carac5.Text = "y";
                    }
                    else if (auxiliar == 26)
                    {
                        Carac5.Text = "z";
                    }
                    else if (auxiliar == 27)
                    {
                        Carac5.Text = "0";
                    }
                    else if (auxiliar == 28)
                    {
                        Carac5.Text = "1";
                    }
                    else if (auxiliar == 29)
                    {
                        Carac5.Text = "2";
                    }
                    else if (auxiliar == 30)
                    {
                        Carac5.Text = "3";
                    }
                    else if (auxiliar == 31)
                    {
                        Carac5.Text = "4";
                    }
                    else if (auxiliar == 32)
                    {
                        Carac5.Text = "5";
                    }
                    else if (auxiliar == 33)
                    {
                        Carac5.Text = "6";
                    }
                    else if (auxiliar == 34)
                    {
                        Carac5.Text = "7";
                    }
                    else if (auxiliar == 35)
                    {
                        Carac5.Text = "8";
                    }
                    else if (auxiliar == 36)
                    {
                        Carac5.Text = "9";
                    }
                }
                if (carac >= 6)
                {
                    auxiliar = senha.Next(1, 36);

                    Carac1.Visible = true;
                    Carac2.Visible = true;
                    Carac3.Visible = true;
                    Carac4.Visible = true;
                    Carac5.Visible = true;
                    Carac6.Visible = true;
                    Carac7.Visible = false;
                    Carac8.Visible = false;
                    Carac9.Visible = false;
                    Carac10.Visible = false;
                    Carac11.Visible = false;
                    Carac12.Visible = false;
                    Carac13.Visible = false;
                    Carac14.Visible = false;
                    Carac15.Visible = false;

                    if (auxiliar == 1)
                    {
                        Carac6.Text = "a";
                    }
                    else if (auxiliar == 2)
                    {
                        Carac6.Text = "b";
                    }
                    else if (auxiliar == 3)
                    {
                        Carac6.Text = "c";
                    }
                    else if (auxiliar == 4)
                    {
                        Carac6.Text = "d";
                    }
                    else if (auxiliar == 5)
                    {
                        Carac6.Text = "e";
                    }
                    else if (auxiliar == 6)
                    {
                        Carac6.Text = "f";
                    }
                    else if (auxiliar == 7)
                    {
                        Carac6.Text = "g";
                    }
                    else if (auxiliar == 8)
                    {
                        Carac6.Text = "h";
                    }
                    else if (auxiliar == 9)
                    {
                        Carac6.Text = "i";
                    }
                    else if (auxiliar == 10)
                    {
                        Carac6.Text = "j";
                    }
                    else if (auxiliar == 11)
                    {
                        Carac6.Text = "k";
                    }
                    else if (auxiliar == 12)
                    {
                        Carac6.Text = "l";
                    }
                    else if (auxiliar == 13)
                    {
                        Carac6.Text = "m";
                    }
                    else if (auxiliar == 14)
                    {
                        Carac6.Text = "n";
                    }
                    else if (auxiliar == 15)
                    {
                        Carac6.Text = "o";
                    }
                    else if (auxiliar == 16)
                    {
                        Carac6.Text = "p";
                    }
                    else if (auxiliar == 17)
                    {
                        Carac6.Text = "q";
                    }
                    else if (auxiliar == 18)
                    {
                        Carac6.Text = "r";
                    }
                    else if (auxiliar == 19)
                    {
                        Carac6.Text = "s";
                    }
                    else if (auxiliar == 20)
                    {
                        Carac6.Text = "t";
                    }
                    else if (auxiliar == 21)
                    {
                        Carac6.Text = "u";
                    }
                    else if (auxiliar == 22)
                    {
                        Carac6.Text = "v";
                    }
                    else if (auxiliar == 23)
                    {
                        Carac6.Text = "w";
                    }
                    else if (auxiliar == 24)
                    {
                        Carac6.Text = "x";
                    }
                    else if (auxiliar == 25)
                    {
                        Carac6.Text = "y";
                    }
                    else if (auxiliar == 26)
                    {
                        Carac6.Text = "z";
                    }
                    else if (auxiliar == 27)
                    {
                        Carac6.Text = "0";
                    }
                    else if (auxiliar == 28)
                    {
                        Carac6.Text = "1";
                    }
                    else if (auxiliar == 29)
                    {
                        Carac6.Text = "2";
                    }
                    else if (auxiliar == 30)
                    {
                        Carac6.Text = "3";
                    }
                    else if (auxiliar == 31)
                    {
                        Carac6.Text = "4";
                    }
                    else if (auxiliar == 32)
                    {
                        Carac6.Text = "5";
                    }
                    else if (auxiliar == 33)
                    {
                        Carac6.Text = "6";
                    }
                    else if (auxiliar == 34)
                    {
                        Carac6.Text = "7";
                    }
                    else if (auxiliar == 35)
                    {
                        Carac6.Text = "8";
                    }
                    else if (auxiliar == 36)
                    {
                        Carac6.Text = "9";
                    }
                }
                if (carac >= 7)
                {
                    auxiliar = senha.Next(1, 36);

                    Carac1.Visible = true;
                    Carac2.Visible = true;
                    Carac3.Visible = true;
                    Carac4.Visible = true;
                    Carac5.Visible = true;
                    Carac6.Visible = true;
                    Carac7.Visible = true;
                    Carac8.Visible = false;
                    Carac9.Visible = false;
                    Carac10.Visible = false;
                    Carac11.Visible = false;
                    Carac12.Visible = false;
                    Carac13.Visible = false;
                    Carac14.Visible = false;
                    Carac15.Visible = false;

                    if (auxiliar == 1)
                    {
                        Carac7.Text = "a";
                    }
                    else if (auxiliar == 2)
                    {
                        Carac7.Text = "b";
                    }
                    else if (auxiliar == 3)
                    {
                        Carac7.Text = "c";
                    }
                    else if (auxiliar == 4)
                    {
                        Carac7.Text = "d";
                    }
                    else if (auxiliar == 5)
                    {
                        Carac7.Text = "e";
                    }
                    else if (auxiliar == 6)
                    {
                        Carac7.Text = "f";
                    }
                    else if (auxiliar == 7)
                    {
                        Carac7.Text = "g";
                    }
                    else if (auxiliar == 8)
                    {
                        Carac7.Text = "h";
                    }
                    else if (auxiliar == 9)
                    {
                        Carac7.Text = "i";
                    }
                    else if (auxiliar == 10)
                    {
                        Carac7.Text = "j";
                    }
                    else if (auxiliar == 11)
                    {
                        Carac7.Text = "k";
                    }
                    else if (auxiliar == 12)
                    {
                        Carac7.Text = "l";
                    }
                    else if (auxiliar == 13)
                    {
                        Carac7.Text = "m";
                    }
                    else if (auxiliar == 14)
                    {
                        Carac7.Text = "n";
                    }
                    else if (auxiliar == 15)
                    {
                        Carac7.Text = "o";
                    }
                    else if (auxiliar == 16)
                    {
                        Carac7.Text = "p";
                    }
                    else if (auxiliar == 17)
                    {
                        Carac7.Text = "q";
                    }
                    else if (auxiliar == 18)
                    {
                        Carac7.Text = "r";
                    }
                    else if (auxiliar == 19)
                    {
                        Carac7.Text = "s";
                    }
                    else if (auxiliar == 20)
                    {
                        Carac7.Text = "t";
                    }
                    else if (auxiliar == 21)
                    {
                        Carac7.Text = "u";
                    }
                    else if (auxiliar == 22)
                    {
                        Carac7.Text = "v";
                    }
                    else if (auxiliar == 23)
                    {
                        Carac7.Text = "w";
                    }
                    else if (auxiliar == 24)
                    {
                        Carac7.Text = "x";
                    }
                    else if (auxiliar == 25)
                    {
                        Carac7.Text = "y";
                    }
                    else if (auxiliar == 26)
                    {
                        Carac7.Text = "z";
                    }
                    else if (auxiliar == 27)
                    {
                        Carac7.Text = "0";
                    }
                    else if (auxiliar == 28)
                    {
                        Carac7.Text = "1";
                    }
                    else if (auxiliar == 29)
                    {
                        Carac7.Text = "2";
                    }
                    else if (auxiliar == 30)
                    {
                        Carac7.Text = "3";
                    }
                    else if (auxiliar == 31)
                    {
                        Carac7.Text = "4";
                    }
                    else if (auxiliar == 32)
                    {
                        Carac7.Text = "5";
                    }
                    else if (auxiliar == 33)
                    {
                        Carac7.Text = "6";
                    }
                    else if (auxiliar == 34)
                    {
                        Carac7.Text = "7";
                    }
                    else if (auxiliar == 35)
                    {
                        Carac7.Text = "8";
                    }
                    else if (auxiliar == 36)
                    {
                        Carac7.Text = "9";
                    }
                }
                if (carac >= 8)
                {
                    auxiliar = senha.Next(1, 36);

                    Carac1.Visible = true;
                    Carac2.Visible = true;
                    Carac3.Visible = true;
                    Carac4.Visible = true;
                    Carac5.Visible = true;
                    Carac6.Visible = true;
                    Carac7.Visible = true;
                    Carac8.Visible = true;
                    Carac9.Visible = false;
                    Carac10.Visible = false;
                    Carac11.Visible = false;
                    Carac12.Visible = false;
                    Carac13.Visible = false;
                    Carac14.Visible = false;
                    Carac15.Visible = false;

                    if (auxiliar == 1)
                    {
                        Carac8.Text = "a";
                    }
                    else if (auxiliar == 2)
                    {
                        Carac8.Text = "b";
                    }
                    else if (auxiliar == 3)
                    {
                        Carac8.Text = "c";
                    }
                    else if (auxiliar == 4)
                    {
                        Carac8.Text = "d";
                    }
                    else if (auxiliar == 5)
                    {
                        Carac8.Text = "e";
                    }
                    else if (auxiliar == 6)
                    {
                        Carac8.Text = "f";
                    }
                    else if (auxiliar == 7)
                    {
                        Carac8.Text = "g";
                    }
                    else if (auxiliar == 8)
                    {
                        Carac8.Text = "h";
                    }
                    else if (auxiliar == 9)
                    {
                        Carac8.Text = "i";
                    }
                    else if (auxiliar == 10)
                    {
                        Carac8.Text = "j";
                    }
                    else if (auxiliar == 11)
                    {
                        Carac8.Text = "k";
                    }
                    else if (auxiliar == 12)
                    {
                        Carac8.Text = "l";
                    }
                    else if (auxiliar == 13)
                    {
                        Carac8.Text = "m";
                    }
                    else if (auxiliar == 14)
                    {
                        Carac8.Text = "n";
                    }
                    else if (auxiliar == 15)
                    {
                        Carac8.Text = "o";
                    }
                    else if (auxiliar == 16)
                    {
                        Carac8.Text = "p";
                    }
                    else if (auxiliar == 17)
                    {
                        Carac8.Text = "q";
                    }
                    else if (auxiliar == 18)
                    {
                        Carac8.Text = "r";
                    }
                    else if (auxiliar == 19)
                    {
                        Carac8.Text = "s";
                    }
                    else if (auxiliar == 20)
                    {
                        Carac8.Text = "t";
                    }
                    else if (auxiliar == 21)
                    {
                        Carac8.Text = "u";
                    }
                    else if (auxiliar == 22)
                    {
                        Carac8.Text = "v";
                    }
                    else if (auxiliar == 23)
                    {
                        Carac8.Text = "w";
                    }
                    else if (auxiliar == 24)
                    {
                        Carac8.Text = "x";
                    }
                    else if (auxiliar == 25)
                    {
                        Carac8.Text = "y";
                    }
                    else if (auxiliar == 26)
                    {
                        Carac8.Text = "z";
                    }
                    else if (auxiliar == 27)
                    {
                        Carac8.Text = "0";
                    }
                    else if (auxiliar == 28)
                    {
                        Carac8.Text = "1";
                    }
                    else if (auxiliar == 29)
                    {
                        Carac8.Text = "2";
                    }
                    else if (auxiliar == 30)
                    {
                        Carac8.Text = "3";
                    }
                    else if (auxiliar == 31)
                    {
                        Carac8.Text = "4";
                    }
                    else if (auxiliar == 32)
                    {
                        Carac8.Text = "5";
                    }
                    else if (auxiliar == 33)
                    {
                        Carac8.Text = "6";
                    }
                    else if (auxiliar == 34)
                    {
                        Carac8.Text = "7";
                    }
                    else if (auxiliar == 35)
                    {
                        Carac8.Text = "8";
                    }
                    else if (auxiliar == 36)
                    {
                        Carac8.Text = "9";
                    }
                }
                if (carac >= 9)
                {
                    auxiliar = senha.Next(1, 36);

                    Carac1.Visible = true;
                    Carac2.Visible = true;
                    Carac3.Visible = true;
                    Carac4.Visible = true;
                    Carac5.Visible = true;
                    Carac6.Visible = true;
                    Carac7.Visible = true;
                    Carac8.Visible = true;
                    Carac9.Visible = true;
                    Carac10.Visible = false;
                    Carac11.Visible = false;
                    Carac12.Visible = false;
                    Carac13.Visible = false;
                    Carac14.Visible = false;
                    Carac15.Visible = false;

                    if (auxiliar == 1)
                    {
                        Carac9.Text = "a";
                    }
                    else if (auxiliar == 2)
                    {
                        Carac9.Text = "b";
                    }
                    else if (auxiliar == 3)
                    {
                        Carac9.Text = "c";
                    }
                    else if (auxiliar == 4)
                    {
                        Carac9.Text = "d";
                    }
                    else if (auxiliar == 5)
                    {
                        Carac9.Text = "e";
                    }
                    else if (auxiliar == 6)
                    {
                        Carac9.Text = "f";
                    }
                    else if (auxiliar == 7)
                    {
                        Carac9.Text = "g";
                    }
                    else if (auxiliar == 8)
                    {
                        Carac9.Text = "h";
                    }
                    else if (auxiliar == 9)
                    {
                        Carac9.Text = "i";
                    }
                    else if (auxiliar == 10)
                    {
                        Carac9.Text = "j";
                    }
                    else if (auxiliar == 11)
                    {
                        Carac9.Text = "k";
                    }
                    else if (auxiliar == 12)
                    {
                        Carac9.Text = "l";
                    }
                    else if (auxiliar == 13)
                    {
                        Carac9.Text = "m";
                    }
                    else if (auxiliar == 14)
                    {
                        Carac9.Text = "n";
                    }
                    else if (auxiliar == 15)
                    {
                        Carac9.Text = "o";
                    }
                    else if (auxiliar == 16)
                    {
                        Carac9.Text = "p";
                    }
                    else if (auxiliar == 17)
                    {
                        Carac9.Text = "q";
                    }
                    else if (auxiliar == 18)
                    {
                        Carac9.Text = "r";
                    }
                    else if (auxiliar == 19)
                    {
                        Carac9.Text = "s";
                    }
                    else if (auxiliar == 20)
                    {
                        Carac9.Text = "t";
                    }
                    else if (auxiliar == 21)
                    {
                        Carac9.Text = "u";
                    }
                    else if (auxiliar == 22)
                    {
                        Carac9.Text = "v";
                    }
                    else if (auxiliar == 23)
                    {
                        Carac9.Text = "w";
                    }
                    else if (auxiliar == 24)
                    {
                        Carac9.Text = "x";
                    }
                    else if (auxiliar == 25)
                    {
                        Carac9.Text = "y";
                    }
                    else if (auxiliar == 26)
                    {
                        Carac9.Text = "z";
                    }
                    else if (auxiliar == 27)
                    {
                        Carac9.Text = "0";
                    }
                    else if (auxiliar == 28)
                    {
                        Carac9.Text = "1";
                    }
                    else if (auxiliar == 29)
                    {
                        Carac9.Text = "2";
                    }
                    else if (auxiliar == 30)
                    {
                        Carac9.Text = "3";
                    }
                    else if (auxiliar == 31)
                    {
                        Carac9.Text = "4";
                    }
                    else if (auxiliar == 32)
                    {
                        Carac9.Text = "5";
                    }
                    else if (auxiliar == 33)
                    {
                        Carac9.Text = "6";
                    }
                    else if (auxiliar == 34)
                    {
                        Carac9.Text = "7";
                    }
                    else if (auxiliar == 35)
                    {
                        Carac9.Text = "8";
                    }
                    else if (auxiliar == 36)
                    {
                        Carac9.Text = "9";
                    }
                }
                if (carac >= 10)
                {
                    auxiliar = senha.Next(1, 36);

                    Carac1.Visible = true;
                    Carac2.Visible = true;
                    Carac3.Visible = true;
                    Carac4.Visible = true;
                    Carac5.Visible = true;
                    Carac6.Visible = true;
                    Carac7.Visible = true;
                    Carac8.Visible = true;
                    Carac9.Visible = true;
                    Carac10.Visible = true;
                    Carac11.Visible = false;
                    Carac12.Visible = false;
                    Carac13.Visible = false;
                    Carac14.Visible = false;
                    Carac15.Visible = false;

                    if (auxiliar == 1)
                    {
                        Carac10.Text = "a";
                    }
                    else if (auxiliar == 2)
                    {
                        Carac10.Text = "b";
                    }
                    else if (auxiliar == 3)
                    {
                        Carac10.Text = "c";
                    }
                    else if (auxiliar == 4)
                    {
                        Carac10.Text = "d";
                    }
                    else if (auxiliar == 5)
                    {
                        Carac10.Text = "e";
                    }
                    else if (auxiliar == 6)
                    {
                        Carac10.Text = "f";
                    }
                    else if (auxiliar == 7)
                    {
                        Carac10.Text = "g";
                    }
                    else if (auxiliar == 8)
                    {
                        Carac10.Text = "h";
                    }
                    else if (auxiliar == 9)
                    {
                        Carac10.Text = "i";
                    }
                    else if (auxiliar == 10)
                    {
                        Carac10.Text = "j";
                    }
                    else if (auxiliar == 11)
                    {
                        Carac10.Text = "k";
                    }
                    else if (auxiliar == 12)
                    {
                        Carac10.Text = "l";
                    }
                    else if (auxiliar == 13)
                    {
                        Carac10.Text = "m";
                    }
                    else if (auxiliar == 14)
                    {
                        Carac10.Text = "n";
                    }
                    else if (auxiliar == 15)
                    {
                        Carac10.Text = "o";
                    }
                    else if (auxiliar == 16)
                    {
                        Carac10.Text = "p";
                    }
                    else if (auxiliar == 17)
                    {
                        Carac10.Text = "q";
                    }
                    else if (auxiliar == 18)
                    {
                        Carac10.Text = "r";
                    }
                    else if (auxiliar == 19)
                    {
                        Carac10.Text = "s";
                    }
                    else if (auxiliar == 20)
                    {
                        Carac10.Text = "t";
                    }
                    else if (auxiliar == 21)
                    {
                        Carac10.Text = "u";
                    }
                    else if (auxiliar == 22)
                    {
                        Carac10.Text = "v";
                    }
                    else if (auxiliar == 23)
                    {
                        Carac10.Text = "w";
                    }
                    else if (auxiliar == 24)
                    {
                        Carac10.Text = "x";
                    }
                    else if (auxiliar == 25)
                    {
                        Carac10.Text = "y";
                    }
                    else if (auxiliar == 26)
                    {
                        Carac10.Text = "z";
                    }
                    else if (auxiliar == 27)
                    {
                        Carac10.Text = "0";
                    }
                    else if (auxiliar == 28)
                    {
                        Carac10.Text = "1";
                    }
                    else if (auxiliar == 29)
                    {
                        Carac10.Text = "2";
                    }
                    else if (auxiliar == 30)
                    {
                        Carac10.Text = "3";
                    }
                    else if (auxiliar == 31)
                    {
                        Carac10.Text = "4";
                    }
                    else if (auxiliar == 32)
                    {
                        Carac10.Text = "5";
                    }
                    else if (auxiliar == 33)
                    {
                        Carac10.Text = "6";
                    }
                    else if (auxiliar == 34)
                    {
                        Carac10.Text = "7";
                    }
                    else if (auxiliar == 35)
                    {
                        Carac10.Text = "8";
                    }
                    else if (auxiliar == 36)
                    {
                        Carac10.Text = "9";
                    }
                }
                if (carac >= 11)
                {
                    auxiliar = senha.Next(1, 36);

                    Carac1.Visible = true;
                    Carac2.Visible = true;
                    Carac3.Visible = true;
                    Carac4.Visible = true;
                    Carac5.Visible = true;
                    Carac6.Visible = true;
                    Carac7.Visible = true;
                    Carac8.Visible = true;
                    Carac9.Visible = true;
                    Carac10.Visible = true;
                    Carac11.Visible = true;
                    Carac12.Visible = false;
                    Carac13.Visible = false;
                    Carac14.Visible = false;
                    Carac15.Visible = false;

                    if (auxiliar == 1)
                    {
                        Carac11.Text = "a";
                    }
                    else if (auxiliar == 2)
                    {
                        Carac11.Text = "b";
                    }
                    else if (auxiliar == 3)
                    {
                        Carac11.Text = "c";
                    }
                    else if (auxiliar == 4)
                    {
                        Carac11.Text = "d";
                    }
                    else if (auxiliar == 5)
                    {
                        Carac11.Text = "e";
                    }
                    else if (auxiliar == 6)
                    {
                        Carac11.Text = "f";
                    }
                    else if (auxiliar == 7)
                    {
                        Carac11.Text = "g";
                    }
                    else if (auxiliar == 8)
                    {
                        Carac11.Text = "h";
                    }
                    else if (auxiliar == 9)
                    {
                        Carac11.Text = "i";
                    }
                    else if (auxiliar == 10)
                    {
                        Carac11.Text = "j";
                    }
                    else if (auxiliar == 11)
                    {
                        Carac11.Text = "k";
                    }
                    else if (auxiliar == 12)
                    {
                        Carac11.Text = "l";
                    }
                    else if (auxiliar == 13)
                    {
                        Carac11.Text = "m";
                    }
                    else if (auxiliar == 14)
                    {
                        Carac11.Text = "n";
                    }
                    else if (auxiliar == 15)
                    {
                        Carac11.Text = "o";
                    }
                    else if (auxiliar == 16)
                    {
                        Carac11.Text = "p";
                    }
                    else if (auxiliar == 17)
                    {
                        Carac11.Text = "q";
                    }
                    else if (auxiliar == 18)
                    {
                        Carac11.Text = "r";
                    }
                    else if (auxiliar == 19)
                    {
                        Carac11.Text = "s";
                    }
                    else if (auxiliar == 20)
                    {
                        Carac11.Text = "t";
                    }
                    else if (auxiliar == 21)
                    {
                        Carac11.Text = "u";
                    }
                    else if (auxiliar == 22)
                    {
                        Carac11.Text = "v";
                    }
                    else if (auxiliar == 23)
                    {
                        Carac11.Text = "w";
                    }
                    else if (auxiliar == 24)
                    {
                        Carac11.Text = "x";
                    }
                    else if (auxiliar == 25)
                    {
                        Carac11.Text = "y";
                    }
                    else if (auxiliar == 26)
                    {
                        Carac11.Text = "z";
                    }
                    else if (auxiliar == 27)
                    {
                        Carac11.Text = "0";
                    }
                    else if (auxiliar == 28)
                    {
                        Carac11.Text = "1";
                    }
                    else if (auxiliar == 29)
                    {
                        Carac11.Text = "2";
                    }
                    else if (auxiliar == 30)
                    {
                        Carac11.Text = "3";
                    }
                    else if (auxiliar == 31)
                    {
                        Carac11.Text = "4";
                    }
                    else if (auxiliar == 32)
                    {
                        Carac11.Text = "5";
                    }
                    else if (auxiliar == 33)
                    {
                        Carac11.Text = "6";
                    }
                    else if (auxiliar == 34)
                    {
                        Carac11.Text = "7";
                    }
                    else if (auxiliar == 35)
                    {
                        Carac11.Text = "8";
                    }
                    else if (auxiliar == 36)
                    {
                        Carac11.Text = "9";
                    }
                }
                if (carac >= 12)
                {
                    auxiliar = senha.Next(1, 36);

                    Carac1.Visible = true;
                    Carac2.Visible = true;
                    Carac3.Visible = true;
                    Carac4.Visible = true;
                    Carac5.Visible = true;
                    Carac6.Visible = true;
                    Carac7.Visible = true;
                    Carac8.Visible = true;
                    Carac9.Visible = true;
                    Carac10.Visible = true;
                    Carac11.Visible = true;
                    Carac12.Visible = true;
                    Carac13.Visible = false;
                    Carac14.Visible = false;
                    Carac15.Visible = false;

                    if (auxiliar == 1)
                    {
                        Carac12.Text = "a";
                    }
                    else if (auxiliar == 2)
                    {
                        Carac12.Text = "b";
                    }
                    else if (auxiliar == 3)
                    {
                        Carac12.Text = "c";
                    }
                    else if (auxiliar == 4)
                    {
                        Carac12.Text = "d";
                    }
                    else if (auxiliar == 5)
                    {
                        Carac12.Text = "e";
                    }
                    else if (auxiliar == 6)
                    {
                        Carac12.Text = "f";
                    }
                    else if (auxiliar == 7)
                    {
                        Carac12.Text = "g";
                    }
                    else if (auxiliar == 8)
                    {
                        Carac12.Text = "h";
                    }
                    else if (auxiliar == 9)
                    {
                        Carac12.Text = "i";
                    }
                    else if (auxiliar == 10)
                    {
                        Carac12.Text = "j";
                    }
                    else if (auxiliar == 11)
                    {
                        Carac12.Text = "k";
                    }
                    else if (auxiliar == 12)
                    {
                        Carac12.Text = "l";
                    }
                    else if (auxiliar == 13)
                    {
                        Carac12.Text = "m";
                    }
                    else if (auxiliar == 14)
                    {
                        Carac12.Text = "n";
                    }
                    else if (auxiliar == 15)
                    {
                        Carac12.Text = "o";
                    }
                    else if (auxiliar == 16)
                    {
                        Carac12.Text = "p";
                    }
                    else if (auxiliar == 17)
                    {
                        Carac12.Text = "q";
                    }
                    else if (auxiliar == 18)
                    {
                        Carac12.Text = "r";
                    }
                    else if (auxiliar == 19)
                    {
                        Carac12.Text = "s";
                    }
                    else if (auxiliar == 20)
                    {
                        Carac12.Text = "t";
                    }
                    else if (auxiliar == 21)
                    {
                        Carac12.Text = "u";
                    }
                    else if (auxiliar == 22)
                    {
                        Carac12.Text = "v";
                    }
                    else if (auxiliar == 23)
                    {
                        Carac12.Text = "w";
                    }
                    else if (auxiliar == 24)
                    {
                        Carac12.Text = "x";
                    }
                    else if (auxiliar == 25)
                    {
                        Carac12.Text = "y";
                    }
                    else if (auxiliar == 26)
                    {
                        Carac12.Text = "z";
                    }
                    else if (auxiliar == 27)
                    {
                        Carac12.Text = "0";
                    }
                    else if (auxiliar == 28)
                    {
                        Carac12.Text = "1";
                    }
                    else if (auxiliar == 29)
                    {
                        Carac12.Text = "2";
                    }
                    else if (auxiliar == 30)
                    {
                        Carac12.Text = "3";
                    }
                    else if (auxiliar == 31)
                    {
                        Carac12.Text = "4";
                    }
                    else if (auxiliar == 32)
                    {
                        Carac12.Text = "5";
                    }
                    else if (auxiliar == 33)
                    {
                        Carac12.Text = "6";
                    }
                    else if (auxiliar == 34)
                    {
                        Carac12.Text = "7";
                    }
                    else if (auxiliar == 35)
                    {
                        Carac12.Text = "8";
                    }
                    else if (auxiliar == 36)
                    {
                        Carac12.Text = "9";
                    }
                }
                if (carac >= 13)
                {
                    auxiliar = senha.Next(1, 36);

                    Carac1.Visible = true;
                    Carac2.Visible = true;
                    Carac3.Visible = true;
                    Carac4.Visible = true;
                    Carac5.Visible = true;
                    Carac6.Visible = true;
                    Carac7.Visible = true;
                    Carac8.Visible = true;
                    Carac9.Visible = true;
                    Carac10.Visible = true;
                    Carac11.Visible = true;
                    Carac12.Visible = true;
                    Carac13.Visible = true;
                    Carac14.Visible = false;
                    Carac15.Visible = false;

                    if (auxiliar == 1)
                    {
                        Carac13.Text = "a";
                    }
                    else if (auxiliar == 2)
                    {
                        Carac13.Text = "b";
                    }
                    else if (auxiliar == 3)
                    {
                        Carac13.Text = "c";
                    }
                    else if (auxiliar == 4)
                    {
                        Carac13.Text = "d";
                    }
                    else if (auxiliar == 5)
                    {
                        Carac13.Text = "e";
                    }
                    else if (auxiliar == 6)
                    {
                        Carac13.Text = "f";
                    }
                    else if (auxiliar == 7)
                    {
                        Carac13.Text = "g";
                    }
                    else if (auxiliar == 8)
                    {
                        Carac13.Text = "h";
                    }
                    else if (auxiliar == 9)
                    {
                        Carac13.Text = "i";
                    }
                    else if (auxiliar == 10)
                    {
                        Carac13.Text = "j";
                    }
                    else if (auxiliar == 11)
                    {
                        Carac13.Text = "k";
                    }
                    else if (auxiliar == 12)
                    {
                        Carac13.Text = "l";
                    }
                    else if (auxiliar == 13)
                    {
                        Carac13.Text = "m";
                    }
                    else if (auxiliar == 14)
                    {
                        Carac13.Text = "n";
                    }
                    else if (auxiliar == 15)
                    {
                        Carac13.Text = "o";
                    }
                    else if (auxiliar == 16)
                    {
                        Carac13.Text = "p";
                    }
                    else if (auxiliar == 17)
                    {
                        Carac13.Text = "q";
                    }
                    else if (auxiliar == 18)
                    {
                        Carac13.Text = "r";
                    }
                    else if (auxiliar == 19)
                    {
                        Carac13.Text = "s";
                    }
                    else if (auxiliar == 20)
                    {
                        Carac13.Text = "t";
                    }
                    else if (auxiliar == 21)
                    {
                        Carac13.Text = "u";
                    }
                    else if (auxiliar == 22)
                    {
                        Carac13.Text = "v";
                    }
                    else if (auxiliar == 23)
                    {
                        Carac13.Text = "w";
                    }
                    else if (auxiliar == 24)
                    {
                        Carac13.Text = "x";
                    }
                    else if (auxiliar == 25)
                    {
                        Carac13.Text = "y";
                    }
                    else if (auxiliar == 26)
                    {
                        Carac13.Text = "z";
                    }
                    else if (auxiliar == 27)
                    {
                        Carac13.Text = "0";
                    }
                    else if (auxiliar == 28)
                    {
                        Carac13.Text = "1";
                    }
                    else if (auxiliar == 29)
                    {
                        Carac13.Text = "2";
                    }
                    else if (auxiliar == 30)
                    {
                        Carac13.Text = "3";
                    }
                    else if (auxiliar == 31)
                    {
                        Carac13.Text = "4";
                    }
                    else if (auxiliar == 32)
                    {
                        Carac13.Text = "5";
                    }
                    else if (auxiliar == 33)
                    {
                        Carac13.Text = "6";
                    }
                    else if (auxiliar == 34)
                    {
                        Carac13.Text = "7";
                    }
                    else if (auxiliar == 35)
                    {
                        Carac13.Text = "8";
                    }
                    else if (auxiliar == 36)
                    {
                        Carac13.Text = "9";
                    }
                }
                if (carac >= 14)
                {
                    auxiliar = senha.Next(1, 36);

                    Carac1.Visible = true;
                    Carac2.Visible = true;
                    Carac3.Visible = true;
                    Carac4.Visible = true;
                    Carac5.Visible = true;
                    Carac6.Visible = true;
                    Carac7.Visible = true;
                    Carac8.Visible = true;
                    Carac9.Visible = true;
                    Carac10.Visible = true;
                    Carac11.Visible = true;
                    Carac12.Visible = true;
                    Carac13.Visible = true;
                    Carac14.Visible = true;
                    Carac15.Visible = false;

                    if (auxiliar == 1)
                    {
                        Carac14.Text = "a";
                    }
                    else if (auxiliar == 2)
                    {
                        Carac14.Text = "b";
                    }
                    else if (auxiliar == 3)
                    {
                        Carac14.Text = "c";
                    }
                    else if (auxiliar == 4)
                    {
                        Carac14.Text = "d";
                    }
                    else if (auxiliar == 5)
                    {
                        Carac14.Text = "e";
                    }
                    else if (auxiliar == 6)
                    {
                        Carac14.Text = "f";
                    }
                    else if (auxiliar == 7)
                    {
                        Carac14.Text = "g";
                    }
                    else if (auxiliar == 8)
                    {
                        Carac14.Text = "h";
                    }
                    else if (auxiliar == 9)
                    {
                        Carac14.Text = "i";
                    }
                    else if (auxiliar == 10)
                    {
                        Carac14.Text = "j";
                    }
                    else if (auxiliar == 11)
                    {
                        Carac14.Text = "k";
                    }
                    else if (auxiliar == 12)
                    {
                        Carac14.Text = "l";
                    }
                    else if (auxiliar == 13)
                    {
                        Carac14.Text = "m";
                    }
                    else if (auxiliar == 14)
                    {
                        Carac14.Text = "n";
                    }
                    else if (auxiliar == 15)
                    {
                        Carac14.Text = "o";
                    }
                    else if (auxiliar == 16)
                    {
                        Carac14.Text = "p";
                    }
                    else if (auxiliar == 17)
                    {
                        Carac14.Text = "q";
                    }
                    else if (auxiliar == 18)
                    {
                        Carac14.Text = "r";
                    }
                    else if (auxiliar == 19)
                    {
                        Carac14.Text = "s";
                    }
                    else if (auxiliar == 20)
                    {
                        Carac14.Text = "t";
                    }
                    else if (auxiliar == 21)
                    {
                        Carac14.Text = "u";
                    }
                    else if (auxiliar == 22)
                    {
                        Carac14.Text = "v";
                    }
                    else if (auxiliar == 23)
                    {
                        Carac14.Text = "w";
                    }
                    else if (auxiliar == 24)
                    {
                        Carac14.Text = "x";
                    }
                    else if (auxiliar == 25)
                    {
                        Carac14.Text = "y";
                    }
                    else if (auxiliar == 26)
                    {
                        Carac14.Text = "z";
                    }
                    else if (auxiliar == 27)
                    {
                        Carac14.Text = "0";
                    }
                    else if (auxiliar == 28)
                    {
                        Carac14.Text = "1";
                    }
                    else if (auxiliar == 29)
                    {
                        Carac14.Text = "2";
                    }
                    else if (auxiliar == 30)
                    {
                        Carac14.Text = "3";
                    }
                    else if (auxiliar == 31)
                    {
                        Carac14.Text = "4";
                    }
                    else if (auxiliar == 32)
                    {
                        Carac14.Text = "5";
                    }
                    else if (auxiliar == 33)
                    {
                        Carac14.Text = "6";
                    }
                    else if (auxiliar == 34)
                    {
                        Carac14.Text = "7";
                    }
                    else if (auxiliar == 35)
                    {
                        Carac14.Text = "8";
                    }
                    else if (auxiliar == 36)
                    {
                        Carac14.Text = "9";
                    }
                }
                if (carac >= 15)
                {
                    auxiliar = senha.Next(1, 36);

                    Carac1.Visible = true;
                    Carac2.Visible = true;
                    Carac3.Visible = true;
                    Carac4.Visible = true;
                    Carac5.Visible = true;
                    Carac6.Visible = true;
                    Carac7.Visible = true;
                    Carac8.Visible = true;
                    Carac9.Visible = true;
                    Carac10.Visible = true;
                    Carac11.Visible = true;
                    Carac12.Visible = true;
                    Carac13.Visible = true;
                    Carac14.Visible = true;
                    Carac15.Visible = true;

                    if (auxiliar == 1)
                    {
                        Carac15.Text = "a";
                    }
                    else if (auxiliar == 2)
                    {
                        Carac15.Text = "b";
                    }
                    else if (auxiliar == 3)
                    {
                        Carac15.Text = "c";
                    }
                    else if (auxiliar == 4)
                    {
                        Carac15.Text = "d";
                    }
                    else if (auxiliar == 5)
                    {
                        Carac15.Text = "e";
                    }
                    else if (auxiliar == 6)
                    {
                        Carac15.Text = "f";
                    }
                    else if (auxiliar == 7)
                    {
                        Carac15.Text = "g";
                    }
                    else if (auxiliar == 8)
                    {
                        Carac15.Text = "h";
                    }
                    else if (auxiliar == 9)
                    {
                        Carac15.Text = "i";
                    }
                    else if (auxiliar == 10)
                    {
                        Carac15.Text = "j";
                    }
                    else if (auxiliar == 11)
                    {
                        Carac15.Text = "k";
                    }
                    else if (auxiliar == 12)
                    {
                        Carac15.Text = "l";
                    }
                    else if (auxiliar == 13)
                    {
                        Carac15.Text = "m";
                    }
                    else if (auxiliar == 14)
                    {
                        Carac15.Text = "n";
                    }
                    else if (auxiliar == 15)
                    {
                        Carac15.Text = "o";
                    }
                    else if (auxiliar == 16)
                    {
                        Carac15.Text = "p";
                    }
                    else if (auxiliar == 17)
                    {
                        Carac15.Text = "q";
                    }
                    else if (auxiliar == 18)
                    {
                        Carac15.Text = "r";
                    }
                    else if (auxiliar == 19)
                    {
                        Carac15.Text = "s";
                    }
                    else if (auxiliar == 20)
                    {
                        Carac15.Text = "t";
                    }
                    else if (auxiliar == 21)
                    {
                        Carac15.Text = "u";
                    }
                    else if (auxiliar == 22)
                    {
                        Carac15.Text = "v";
                    }
                    else if (auxiliar == 23)
                    {
                        Carac15.Text = "w";
                    }
                    else if (auxiliar == 24)
                    {
                        Carac15.Text = "x";
                    }
                    else if (auxiliar == 25)
                    {
                        Carac15.Text = "y";
                    }
                    else if (auxiliar == 26)
                    {
                        Carac15.Text = "z";
                    }
                    else if (auxiliar == 27)
                    {
                        Carac15.Text = "0";
                    }
                    else if (auxiliar == 28)
                    {
                        Carac15.Text = "1";
                    }
                    else if (auxiliar == 29)
                    {
                        Carac15.Text = "2";
                    }
                    else if (auxiliar == 30)
                    {
                        Carac15.Text = "3";
                    }
                    else if (auxiliar == 31)
                    {
                        Carac15.Text = "4";
                    }
                    else if (auxiliar == 32)
                    {
                        Carac15.Text = "5";
                    }
                    else if (auxiliar == 33)
                    {
                        Carac15.Text = "6";
                    }
                    else if (auxiliar == 34)
                    {
                        Carac15.Text = "7";
                    }
                    else if (auxiliar == 35)
                    {
                        Carac15.Text = "8";
                    }
                    else if (auxiliar == 36)
                    {
                        Carac15.Text = "9";
                    }
                }
                //36
            }

            if(letra==0 && num==0)
            {
                senhacopy = "Não";
            }
            else
            {
                senhacopy = Carac1.Text + Carac2.Text + Carac3.Text + Carac4.Text + Carac5.Text + Carac6.Text + Carac7.Text + Carac8.Text + Carac9.Text + Carac10.Text + Carac11.Text + Carac12.Text + Carac13.Text + Carac14.Text + Carac15.Text;
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            if(senhacopy=="Não")
            {
                MessageBox.Show("A cópia não foi feita devido não ter gerado a senha\n(selecione letra ou número, ao menos um deles,\n quando for gerar a senha)", "Gerador de senhas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                Clipboard.SetText(senhacopy);

                MessageBox.Show("Copiado com sucesso!", "Gerador de senhas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            

        }
    }
}

