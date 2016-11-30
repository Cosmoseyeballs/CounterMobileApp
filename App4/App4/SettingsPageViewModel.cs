using App4;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App4
{
    public class SettingsPageViewModel : INotifyPropertyChanged
    {
        private int sayEverySek;
        private string what2say;

        public SettingsPageViewModel()
        {
            if (Application.Current.Properties.ContainsKey(nameof(SayEverySek)))
            {
                var say =  Application.Current.Properties[nameof(SayEverySek)];
                this.sayEverySek = Convert.ToInt32(say); 
            }
            if (Application.Current.Properties.ContainsKey(nameof(What2say)))
            {
                var say = Application.Current.Properties[nameof(What2say)];
                this.What2say = say.ToString();
            }
        }



        public int SayEverySek
        {
            get
            {
                return sayEverySek;
            }

            set
            {
                sayEverySek = value;
                Application.Current.Properties[nameof(SayEverySek)] = value; 
                OnPropertyChanged();
            }
        }

        public string What2say
        {
            get
            {
                return what2say;
            }

            set
            {
                what2say = value;
                Application.Current.Properties[nameof(What2say)] = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }


    }
}
