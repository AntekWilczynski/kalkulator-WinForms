using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Kalkulator : Form
    {

        string liczbaPierwsza, liczbaDruga;
        char dzialanie = ' ' ;

        public Kalkulator()
        {
            InitializeComponent();
        }


        private void btnWyczysc_Click(object sender, EventArgs e)
        {
            dzialanie = ' ';
            tbWyswietlacz.Text=" ";
        }

        private void btnPrzecinek_Click(object sender, EventArgs e)
        {
            dzialanie = ',';
            tbWyswietlacz.Text = "";
        }
        private void btnWynik_Click(object sender, EventArgs e)
        {
            switch (dzialanie)
            {
                case ('+'):
                    tbWyswietlacz.Text = (int.Parse(liczbaPierwsza) + int.Parse(liczbaDruga)).ToString();
                    break;
                case ('-'):
                    tbWyswietlacz.Text = (int.Parse(liczbaPierwsza) - int.Parse(liczbaDruga)).ToString();
                    break;
                case ('*'):
                    tbWyswietlacz.Text = (int.Parse(liczbaPierwsza) * int.Parse(liczbaDruga)).ToString();
                    break;
                case ('/'):
                    tbWyswietlacz.Text = (int.Parse(liczbaPierwsza) / int.Parse(liczbaDruga)).ToString();
                    break;
                case ('!'):
                    int wynikSilni = 1;
                    for (int i = 1; i <= int.Parse(liczbaPierwsza); i++)
                        wynikSilni *= i;
                    tbWyswietlacz.Text = (wynikSilni).ToString();
                    break;
                case ('%'):
                    tbWyswietlacz.Text = (int.Parse(liczbaPierwsza) * int.Parse(liczbaDruga)/100).ToString();
                    break;
            }
                    liczbaPierwsza = "";
                    liczbaDruga = "";
                    dzialanie = ' ';
        }

        private void btnDziel_Click(object sender, EventArgs e)
        {
            dzialanie = '/';
            tbWyswietlacz.Text = "";
        }
        private void btnMnoz_Click(object sender, EventArgs e)
        {
            dzialanie = '*';
            tbWyswietlacz.Text = "";
        }
        private void btnSilnia_Click(object sender, EventArgs e)
        {
            dzialanie = '!';
            tbWyswietlacz.Text = "";
        }
        private void btnProcent_Click(object sender, EventArgs e)
        {
            dzialanie = '%';
            tbWyswietlacz.Text = "";
        }
        private void btnMinus_Click(object sender, EventArgs e)
        {
            dzialanie = '-';
            tbWyswietlacz.Text = "";
        }
        private void btnPlus_Click(object sender, EventArgs e)
        {
            dzialanie = '+';
            tbWyswietlacz.Text = "";
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            Dzialanie(0);
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            Dzialanie(1);
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            Dzialanie(2);
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            Dzialanie(3);
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            Dzialanie(4);
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            Dzialanie(5);
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            Dzialanie(6);
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            Dzialanie(7);
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            Dzialanie(8);
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            Dzialanie(9);
        }

        private void Dzialanie(int liczba)
        {
            if (dzialanie == ' ')
            {
                liczbaPierwsza += liczba;
                tbWyswietlacz.Text = liczbaPierwsza;
            }
            else
            {
                liczbaDruga += liczba;
                tbWyswietlacz.Text = liczbaDruga;
            }
        }

     
    }
}
