using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CalculadoraBar
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void cmdCalcular_Clicked(object sender, EventArgs e)
        {
            //Metodo del boton

            var total = (decimal.Parse(txtTotal.Text));
            var propina = (decimal.Parse(txtPropina.Text));
            var noPersonas = (int.Parse(txtNoPersonas.Text));

            var totalPropina = (total * propina) / 100;

            lblPropina.Detail = totalPropina.ToString("C");
            lblTotal.Detail = (totalPropina + total).ToString("C");
            lblPropinaPorPersona.Detail = (totalPropina / noPersonas).ToString("C");
            lblTotalPorPersona.Detail = ((total + totalPropina) / noPersonas).ToString("C");
            
            TotalTotal.Text = ((total + totalPropina) / noPersonas).ToString("C") + " Por Persona";
        }
    }
}
