using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace App4
{
    class CounterViewModel : INotifyPropertyChanged
    {
        // Field
        public event PropertyChangedEventHandler PropertyChanged;
        private int counter;
        private bool click = false;

        // Constructor
        public CounterViewModel()
        {
            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                if (Counter == 0)
                {
                    if (click)
                    {
                        DisplayAlert("Test", "Test 2");
                        click = false;
                    }

                    return true;
                }

                this.Counter = Counter - 1;
                return true;
            });

            this.SetNewCounter = new Command<string>(SetCounter);
        }

        // Property
        public int Counter
        {
            get { return counter; }
            set
            {
                if (Counter != value)
                {
                    counter = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Counter)));
                }
            }
        }


        // Methods
        public ICommand SetNewCounter { private set; get; }

        void SetCounter(string key)
        {
            this.Counter = Convert.ToInt32(key);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Counter)));
            click = true;
        }





        public void DisplayAlert(string title, string message)
        {
            string[] values = { title, message };
            MessagingCenter.Send(this, "DisplayAlert", values);
        }


    }
}
