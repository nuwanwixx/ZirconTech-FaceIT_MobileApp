using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ZirconTechFaceIT.Views;

namespace ZirconTechFaceIT
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            image1.Source = ImageSource.FromResource("ZirconTechFaceIT.Images.background.jpg");
        }

        

        async void Button_SignUp(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignUpPage());
        }

        async void Button_SignIn(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignInPage());
        }
    }
}


