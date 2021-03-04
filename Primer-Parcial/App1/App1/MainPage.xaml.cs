using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Primer_Parcial
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {

            string num = (numero.Text);
            num = num.Remove(num.Length - 1);
            int x, y;

            y = int.Parse(num);
            x = y - 4;


            DisplayAlert("El Número que pensaste es:", x.ToString(), "Fin...");

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            (sender as Button).Text = "Piensa en un numero y anotalo donde tu quieras";
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            (sender as Button).Text = "Ahora multiplica el numero que pensaste por 2";
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            (sender as Button).Text = "Sumale 8 al resultado aneterior";
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            (sender as Button).Text = "Al resultado que llevas acumulado multiplicalo por 5";
        }

        private void Button_Clicked_5(object sender, EventArgs e)
        {
            (sender as Button).Text = "Ingresa el resultado que acumulaste en los pasos aterirores";
        }
    }

}


