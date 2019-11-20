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
    }
}
