using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ZirconTechFaceIT.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchPage : ContentPage
    {
        public SearchPage()
        {
            InitializeComponent();
        }

        private async void FaceSearch_Btn(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FaceSearchPage());
        }

        private async void LocationSearch_Btn(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LocationSearchPage());
        }

        private async void NameSearch_Btn(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NameSearchPage());
        }
    }
}