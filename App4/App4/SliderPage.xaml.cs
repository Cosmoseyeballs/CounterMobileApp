using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App4
{
    public partial class SliderPage : ContentPage
    {

        public SliderPage()
        {
            InitializeComponent();

            var sliderVM = new SliderPageViewModel();

            BindingContext = sliderVM;


            slider2Test.SetBinding<SliderPageViewModel>(Label.TextProperty, vm => vm.MinValue, BindingMode.TwoWay);
            slider1Test.SetBinding<SliderPageViewModel>(Label.TextProperty, vm => vm.MinValue, BindingMode.TwoWay);

            slider1.SetBinding<SliderPageViewModel>(Slider.ValueProperty, vm => vm.MinValue, BindingMode.TwoWay, new sliderConverter());
            slider2.SetBinding<SliderPageViewModel>(Slider.ValueProperty, vm => vm.MinValue, BindingMode.TwoWay);


        }
    }
}
