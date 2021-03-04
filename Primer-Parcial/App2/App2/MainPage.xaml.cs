using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {

            int resul = int.Parse(numero.Text);

            int a, b;
            a = resul - 365; 
            string aStrign = a.ToString();
            aStrign = aStrign.Remove(aStrign.Length - 2);

            b = resul - 365;
            string bString = b.ToString();
            bString = bString.Remove(bString.Length - 4, 2);

            DisplayAlert("El Mes de tu cumpleaños es:", bString.ToString(), "Toca para ver tu mes");
            DisplayAlert("El dia de tu cumpleaños es:", aStrign.ToString(), "Fin...");
            



        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            (sender as Button).Text = "Anota el día en que naciste donde tu quieras";
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            (sender as Button).Text = "Ahora el día multiplicalo por veinte (20)";
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            (sender as Button).Text = "Al resultado sumale setenta y tres (73)";
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            (sender as Button).Text = "Ahora multiplicalo por 5";
        }

        private void Button_Clicked_5(object sender, EventArgs e)
        {
            (sender as Button).Text = "Posteriormente sumale la fecha del mes en que naciste a tu resultado.";
        }

        private void Button_Clicked_6(object sender, EventArgs e)
        {
            (sender as Button).Text = "Ingresa el resultado que llevas acumulado en total";
        }
    }
}
