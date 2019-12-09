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
        public MovieListPage(string name)
        {
            InitializeComponent();
            var movieRepo = new MovieRepository();
            var movie = movieRepo.GetMovie(name);
            var MoviesOnPage = new ObservableCollection<Movie>();
            MoviesOnPage.Add(movie);
            movieList.ItemsSource = MoviesOnPage;


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

        private void movieList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
          
            Movie selectedMovie = e.SelectedItem as Movie;
            
            Navigation.PushAsync(new MovieDetailsPage(selectedMovie));

        }
    }
}