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
    public partial class Joululaupaev : ContentPage
    {
        public Joululaupaev()
        {
            InitializeComponent();
        }

        private void btn_Clicked(object sender, EventArgs e)
        {

            lab30.IsVisible = false;
            lab31.IsVisible = true;
        }
    }
}