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
    public partial class Iseseisvuspaev : ContentPage
    {
        public Iseseisvuspaev()
        {
            InitializeComponent();
        }

        private void btn_Clicked(object sender, EventArgs e)
        {

            lab4.IsVisible = false;
            lab3.IsVisible = true;
        }
    }
}