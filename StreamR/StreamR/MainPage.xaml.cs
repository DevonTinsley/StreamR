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
        List<string> plat;
        List<string> genre;
        public MainPage()
        {
            InitializeComponent();

            GenrePicker.ItemsSource = new List<string> { "Action", "Adventure", "Comedy", "Drama" };

        }
        public MainPage(List<string> platforms)
        {
            InitializeComponent();
            plat = platforms;
            GenrePicker.ItemsSource = new List<string> { "Action", "Adventure", "Comedy", "Drama" };

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

        private void Search_For_Movie(object sender, EventArgs e)
        {
            if (GenrePicker.SelectedItem == null || plat == null)
            {
                return;
            }
            else {
                genre = new List<string>();
                genre.Add(GenrePicker.SelectedItem.ToString());
                Navigation.PushAsync(new MovieListPage(genre , plat));

            }
            

          

        }
    }
}
