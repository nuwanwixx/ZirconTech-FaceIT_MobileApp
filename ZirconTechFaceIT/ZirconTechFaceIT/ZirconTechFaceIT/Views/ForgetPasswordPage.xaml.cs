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
    public partial class ForgetPasswordPage : ContentPage
    {
        public ForgetPasswordPage()
        {
            InitializeComponent();
        }

        private async void Btn_Submit(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RenewPasswordPage());

        }
    }
}