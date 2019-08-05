using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace comicAppFinal
{
    public partial class CharacterPage : ContentPage
    {
        public CharacterPage()
        {
            InitializeComponent();
        }

        void Download_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DownloadsPage());
        }

        void Profile_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ProfilePage());
        }

        void Character_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CharacterPage());
        }
    }
}
