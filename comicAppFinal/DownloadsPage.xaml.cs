using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Xamarin.Forms;

namespace comicAppFinal
{
    public partial class DownloadsPage : ContentPage
    {
        public ObservableCollection<DownloadPageItem> Downloads { get; set; }
        public DownloadsPage()
        {
            InitializeComponent();

            Downloads = new ObservableCollection<DownloadPageItem>
            {
                new DownloadPageItem
                {
                    ComicTitle="Doctor who",
                    ComicCheck = true,
                    ComicImage = "doctorWho.png",
                    ComicSize = 1
                },
                new DownloadPageItem
                {
                    ComicTitle ="Black Mirror",
                    ComicCheck=false,
                    ComicImage="blackMirror.png",
                    ComicSize=5
                },
                new DownloadPageItem
                {
                    ComicTitle="Thor",
                    ComicCheck=true,
                    ComicImage="thor.jpg",
                    ComicSize=4
                }
            };

            BindingContext = this;
        }
    }
}
