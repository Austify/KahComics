using System;
using System.Collections.Generic;
using Xamarin.Forms.Xaml;
using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace comicAppFinal
{
    public partial class MasterPage : ContentPage
    {
        public ListView Menu { get => listView; }

        public Button Login { get => login; }
        public Button CreateAccount { get => createAccount; }
       
        public MasterPage()
        {
            InitializeComponent();
            
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new HomePage());
        }
    }
}
