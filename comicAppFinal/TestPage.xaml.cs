using System;
using System.Collections.Generic;

using Xamarin.Forms;

using System.Collections.ObjectModel;
using Xamarin.Forms.Xaml;

namespace comicAppFinal
{
    public class Slida
    {
        public string Url { get; set; }
        public string Name { get; set; }

    }

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TestPage : ContentPage
    {
        public ObservableCollection<Slidex> sliders { get; set; }
        public ObservableCollection<Slidex> sliders1 { get; set; }
        public TestPage()
        {
            InitializeComponent();
            sliders = new ObservableCollection<Slidex>
        {
            new Slidex{ Url = "jessica_jones.jpg",Name="Jessica Jones"},
            new Slidex{ Url ="america.jpg",Name="America"},
            new Slidex{ Url ="boxer_woman.jpg",Name="Boxer Woman"},
            new Slidex{ Url ="fables.jpg",Name="Fables"}
        };

            BindingContext = this;
        }
    }
}
