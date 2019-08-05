using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace comicAppFinal
{
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        async void Register_Clicked(object sender,EventArgs e)
        {

            await Navigation.PushAsync(new HomePage());
        }
    }
}
