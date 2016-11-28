using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace App4
{
    class ClockViewModel : INotifyPropertyChanged
    {
        DateTime dateTime;

        public DateTime DateTime {
            set
            {
                if (dateTime != value)
                {
                    dateTime = value;

                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(DateTime)));
                }
            }
            get {
                return dateTime;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public ClockViewModel()
        {
            this.DateTime = DateTime.Now;

            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                this.DateTime = DateTime.Now;
                return true;
            });
        }
    }
}
