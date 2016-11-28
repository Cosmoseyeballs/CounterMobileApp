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

            btnSpeek.Clicked += (a, b) => {
                CrossTextToSpeech.Current.Speak("Jeg har en hat");

            };

            MessagingCenter.Subscribe<CounterViewModel, string[]>(this, "DisplayAlert", async (sender, values) =>
            {
                await DisplayAlert(values[0], values[1], "Ok");
                CrossTextToSpeech.Current.Speak("Text to speak");
            });

        }
    }
}
