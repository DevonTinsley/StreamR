using StreamR.Backend;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace StreamR
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MovieListPage : ContentPage
    {
        private ObservableCollection<Movie> MoviesOnPage { get; set; }

        public MovieListPage(List<string> category, List<string> platforms)
        {
            InitializeComponent();
            var generator = new MovieGenerator();
            var movies = generator.GenerateMovies(category,platforms);

            var MoviesOnPage = new ObservableCollection<Movie>();


            foreach (Movie movie in movies.OrderBy(x=>x.Title))
            {
                MoviesOnPage.Add(movie);
            }

            movieList.ItemsSource =  MoviesOnPage;

        }
        public MovieListPage()
        {
            InitializeComponent();
        }
        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MovieDetailsPage());

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