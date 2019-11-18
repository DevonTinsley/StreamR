using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace StreamR
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            GenrePicker.ItemsSource = new List<string> { "Action", "Adventure", "Comedy" };

            bool tvIsToggled = TVSwitch.IsToggled;
            bool movieIsToggled = MovieSwitch.IsToggled;

            
            
            
            while (tvIsToggled == true)
            {
                if (movieIsToggled == true)
                    tvIsToggled = false;
            }

            while (movieIsToggled == true)
            {
                if (tvIsToggled == true)
                    movieIsToggled = false;
            }
        }

        private void TVSwitch_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if(TVSwitch.IsToggled == true)
            {
                if (MovieSwitch.IsToggled)
                {
                    MovieSwitch.IsToggled = false;
                    TVSwitch.IsToggled = true;
                }
            }
        }

        private void MovieSwitch_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (MovieSwitch.IsToggled == true)
            {
                if (TVSwitch.IsToggled)
                {
                    TVSwitch.IsToggled = false;
                }
            }
        }

        private void Search_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SearchPage());
        }

        private void Monitor_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }

        private void Profile_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ProfilePage());
        }
    }
}
