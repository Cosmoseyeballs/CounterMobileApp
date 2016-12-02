using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App4
{
   public  class sliderConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

            if (System.Convert.ToDouble(value) != 0.0)
                return System.Convert.ToDouble(value) * 100;

            return false;

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {

            if (System.Convert.ToDouble(value) != 0.0)
                return System.Convert.ToDouble(value) / 100;


            return false;

        }
    }
}
