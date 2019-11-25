using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace StreamR
{
    public partial class ProfilePage : ContentPage
    {
        List<string> platforms;
        public ProfilePage()
        {
            platforms = new List<string>();

            InitializeComponent();
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

        private void HuluSwitch_Toggled(object sender, ToggledEventArgs e)
        {
            if (HuluSwitch.IsToggled == true) {
                platforms.Add("Hulu");               
            }
            if (HuluSwitch.IsToggled == false) {
                platforms.Remove("Hulu");
            }
        }

        private void NetflixSwitch_Toggled(object sender, ToggledEventArgs e)
        {
            if (NetflixSwitch.IsToggled == true) {
                platforms.Add("Netflix");
            }
            if (NetflixSwitch.IsToggled == false) {
                platforms.Remove("Netflix");
            }
        }

        private void AmazonPrimeSwitch_Toggled(object sender, ToggledEventArgs e)
        {
            if (AmazonPrimeSwitch.IsToggled == true) { 
                platforms.Add("AmazonPrime");
            }
            if (AmazonPrimeSwitch.IsToggled == false) {
                platforms.Remove("AmazonPrime");
            }
        }

        private void HBOSwitch_Toggled(object sender, ToggledEventArgs e)
        {
            if (HBOSwitch.IsToggled == true) {
                platforms.Add("HBO");
            }
            if (HBOSwitch.IsToggled == false) {
                platforms.Remove("HBO");
            }
        }

        private void ShowtimeSwitch_Toggled(object sender, ToggledEventArgs e)
        {
            if (ShowtimeSwitch.IsToggled == true) {
                platforms.Add("Showtime");
            }
            if (ShowtimeSwitch.IsToggled == false) {
                platforms.Remove("Showtime");
            }
        }

        private void StarsSwitch_Toggled(object sender, ToggledEventArgs e)
        {
            if (StarsSwitch.IsToggled == true) {
                platforms.Add("Stars");
            }
            if (StarsSwitch.IsToggled == false) {
                platforms.Remove("Stars");
            }
        }

        private void SlingSwitch_Toggled(object sender, ToggledEventArgs e)
        {
            if (SlingSwitch.IsToggled == true) {
                platforms.Add("Sling");
            }
            if (SlingSwitch.IsToggled == false) {
                platforms.Remove("Sling");
            }
        }

        private void DisneySwitch_Toggled(object sender, ToggledEventArgs e)
        {
            if (DisneySwitch.IsToggled == true) {
                platforms.Add("Disney");
            }
            if (DisneySwitch.IsToggled == false) {
                platforms.Remove("Disney");
            }
        }
    }
}
