﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Kasupaev : ContentPage
    {
        public Kasupaev()
        {
            InitializeComponent();
        }

        private void btn_Clicked(object sender, EventArgs e)
        {

            lab6.IsVisible = false;
            lab5.IsVisible = true;
        }
    }
}