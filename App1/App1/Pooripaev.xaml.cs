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
    public partial class Pooripaev : ContentPage
    {
        public Pooripaev()
        {
            InitializeComponent();
        }

        private void btn_Clicked(object sender, EventArgs e)
        {

            lab12.IsVisible = false;
            lab11.IsVisible = true;
        }
    }
}