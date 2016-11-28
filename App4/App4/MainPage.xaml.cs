using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace App4
{
    public partial class MainPage : ContentPage
    {

        public class User {
            public string Name { get; set; }
            public int Phone { get; set; }

        }

        private readonly ObservableCollection<User> users = new ObservableCollection<User>()
        {
            new User {Name = "Jack Ass", Phone = 9389834},
            new User {Name = "Jack Ass", Phone = 9389834},
            new User {Name = "Jack Ass", Phone = 9389834},
            new User {Name = "Jack Ass", Phone = 9389834},

        };

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
