using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App4
{
    public partial class TestPage : ContentPage
    {
        public TestPage()
        {
            InitializeComponent();
            Content = new MyEntry {
                Text= "Hej med dig"
            };
        }
    }
}
