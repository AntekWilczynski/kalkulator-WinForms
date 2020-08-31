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
        Double wynik = 0;
        string rodzajDzialania = "";
        bool czyUruchomionoDzialanie = false;
        public Kalkulator()
        {
            InitializeComponent();
        }


        private void num_click(object sender, EventArgs e)
        {
            if ((tbWyswietlacz.Text == "0")||czyUruchomionoDzialanie)
                tbWyswietlacz.Clear();
            Button przycisk = (Button)sender;
            if (przycisk.Text == ",")
            {
                if (!tbWyswietlacz.Text.Contains(","))

                    tbWyswietlacz.Text = tbWyswietlacz.Text + przycisk.Text;
            }
            else
                tbWyswietlacz.Text = tbWyswietlacz.Text + przycisk.Text;
            czyUruchomionoDzialanie = false;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button przycisk = (Button)sender;
            if (wynik != 0)
            {
                btnOblicz.PerformClick();

                rodzajDzialania = przycisk.Text;
                czyUruchomionoDzialanie = true;
                lbWykonywanaOperacja.Text = wynik + " " + rodzajDzialania;
            }
            else
            {
                rodzajDzialania = przycisk.Text;
                wynik = Double.Parse(tbWyswietlacz.Text);
                czyUruchomionoDzialanie = true;
                lbWykonywanaOperacja.Text = wynik + " " + rodzajDzialania;
            }
        }

        private void wyczysc_Click(object sender, EventArgs e)
        {

                tbWyswietlacz.Text = "0";
            
        }

        private void wyzeruj_Click(object sender, EventArgs e)
        {
            tbWyswietlacz.Text = "0";
            wynik = 0;
        }

        private void btnOblicz_Click(object sender, EventArgs e)
        {
            switch (rodzajDzialania)
            {
                case "+":
                    tbWyswietlacz.Text = (wynik + Double.Parse(tbWyswietlacz.Text)).ToString();
                    break;
                case "-":
                    tbWyswietlacz.Text = (wynik - Double.Parse(tbWyswietlacz.Text)).ToString();
                    break;
                case "×":
                    tbWyswietlacz.Text = (wynik * Double.Parse(tbWyswietlacz.Text)).ToString();
                    break;
                case "÷":
                    tbWyswietlacz.Text = (wynik / Double.Parse(tbWyswietlacz.Text)).ToString();
                    break;
                case "%":
                    tbWyswietlacz.Text = (wynik + Double.Parse(tbWyswietlacz.Text)).ToString();
                    break;
                case "x^y":
                    tbWyswietlacz.Text = (wynik + Double.Parse(tbWyswietlacz.Text)).ToString();
                    break;
                case "n!":
                    tbWyswietlacz.Text = (wynik + Double.Parse(tbWyswietlacz.Text)).ToString();
                    break;
                default: break;

            }
        }
    }
}
