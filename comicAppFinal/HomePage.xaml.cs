using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

using System.Collections.ObjectModel;
using Xamarin.Forms.Xaml;
using comicAppFinal;


namespace comicAppFinal
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    public class Slidex
    {
        public string Url { get; set; }
        public string Name { get; set; }

    }

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public ObservableCollection<Slidex> sliders { get; set; }
        public ObservableCollection<Slidex> sliders1 { get; set; }
        public HomePage()
        {
            InitializeComponent();
            sliders = new ObservableCollection<Slidex>
        {
			new Slidex{ Url = "girls.jpg",Name="Girly Jones"},
			new Slidex{ Url = "jessica_jones.jpg",Name="Jessica Jones"},
            new Slidex{ Url ="america.jpg",Name="America"},
            new Slidex{ Url ="xmen.jpg",Name="x-Men"},
            new Slidex{ Url ="fables.jpg",Name="Fables"}
        };

            BindingContext = this;
        }

        void Download_Clicked(object sender,EventArgs e)
        {
            Navigation.PushAsync(new DownloadsPage());
        }

        void Profile_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ProfilePage());
        }

        void Character_Clicked(object sender,EventArgs e)
        {
            Navigation.PushAsync(new CharacterPage());
        }
    }

}
