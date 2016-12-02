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
    public class SliderPageViewModel : INotifyPropertyChanged
    {
        private int minValue;

        public int MinValue
        {
            get { return minValue; }
            set {
                if (value != minValue)
                {
                    minValue = value; OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;


        protected virtual void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
