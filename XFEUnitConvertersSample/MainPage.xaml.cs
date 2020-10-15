using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace XFEUnitConvertersSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            var kilometers = Convert.ToDouble(UnitEntry.Text);
            var result = UnitConverters.KilometersToMiles(kilometers);

            ResultLabel.Text = result.ToString();
        }
    }
}
