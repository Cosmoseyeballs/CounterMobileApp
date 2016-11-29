using Plugin.TextToSpeech;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App4
{
    public partial class CounterPage : ContentPage
    {
        public CounterPage()
        {
            
            BindingContext = new CounterViewModel();
            InitializeComponent();



            SettingsBtn.Clicked += (a, b) => {
                Navigation.PushAsync(new SettingsPage(new SettingsPageViewModel()));
            };

            MessagingCenter.Subscribe<CounterViewModel, string[]>(this, "DisplayAlert", async (sender, values) =>
            {
                CrossTextToSpeech.Current.Speak("Text to speak");
                await DisplayAlert(values[0], values[1], "Ok");
            });

        }
    }
}
