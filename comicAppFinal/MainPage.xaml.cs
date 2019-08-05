using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace comicAppFinal
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer


    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MasterDetailPage
    {
        
        public MainPage()
        {
            InitializeComponent();
            //masterPage.Menu.ItemSelected += OnItemSelected;

            masterPage.Menu.ItemSelected += OnItemSelected;
            masterPage.Login.Clicked += Login_Clicked;
            masterPage.CreateAccount.Clicked += CreateAccount_Clicked;

            if (Device.RuntimePlatform == Device.UWP)
            {
                MasterBehavior = MasterBehavior.Popover;
            }

        }

      
        void Login_Clicked(object sender,EventArgs e)
        {
            
            Detail = new NavigationPage(new LoginPage());
            IsPresented = false;
        }

        void CreateAccount_Clicked(object sender, EventArgs e)
        {

            Detail = new NavigationPage(new RegisterPage());
            IsPresented = false;
        }
        void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			var item = e.SelectedItem as MasterPageItem;
			if (item != null)
			{
				Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
				//masterPage.Menu.SelectedItem = null;
				IsPresented = false;
			}
		}
	}
}

