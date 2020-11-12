using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Uusaasta : ContentPage
    {
        public Uusaasta()
        {
            InitializeComponent();
        }

        private void btn_Clicked(object sender, EventArgs e)
        {

            lab777.IsVisible = false;
            lab778.IsVisible = true;
        }
    }
}