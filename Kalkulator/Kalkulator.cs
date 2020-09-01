using System;
using System.Linq;
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
        private static int silnia(int i)
        {
            if (i < 1)
                return 1;
            else
                return i * silnia(i - 1);
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
                    tbWyswietlacz.Text = (wynik/100*Double.Parse(tbWyswietlacz.Text)).ToString();
                    break;
                case "x^y":
                    break;
                case "n!":
                    tbWyswietlacz.Text = (silnia(Convert.ToInt32(wynik))).ToString();
                    break;
                default: break;

            }
            wynik = Double.Parse(tbWyswietlacz.Text);
            lbWykonywanaOperacja.Text= "";
        }
    }
}
