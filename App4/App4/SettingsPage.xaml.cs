using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App4
{
    public partial class SettingsPage : ContentPage
    {
        private SettingsPageViewModel _settingsPageViewModel;

        public SettingsPage(SettingsPageViewModel settingsPageViewModel)
        {
            InitializeComponent();
            this._settingsPageViewModel = settingsPageViewModel;

            BindingContext = _settingsPageViewModel;


        }
    }
}
