using StreamR.Backend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StreamR
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MovieDetailsPage : ContentPage
    {
        Movie movieOnPage;

        public MovieDetailsPage()
        {
            InitializeComponent();
        }

        public MovieDetailsPage(Movie selectedItem)
        {
            
            InitializeComponent();
            this.movieOnPage = selectedItem;
            this.title.Text = selectedItem.Title;
            this.picture.Source = selectedItem.ImageURL;
            var platformscsv = string.Join(", ", selectedItem.StreamingPlatforms.ToArray());
            this.platforms.Text = "Platforms: " + platformscsv;
            this.description.Text = selectedItem.Synopsis;
            this.runtime.Text = "Runtime: " + selectedItem.LengthInMinutes.ToString();




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