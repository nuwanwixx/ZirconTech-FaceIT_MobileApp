using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ZirconTechFaceIT.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUpPage2 : ContentPage
    {
        public SignUpPage2()
        {
            InitializeComponent();
        }

        async private void Button_CreateAcount(object sender, EventArgs e)
        {

            var email = EmailEntry.Text;

            if (EmailEntry.Text != null)
            {

                if (email.Contains("@") & email.Contains(".com"))
                {
                    apiCall(1);
                    await Navigation.PushAsync(new TabPage());
                }


                else
                {
                    ErrorLabel.Text = "Email is not valid";
                    return;

                }
            }
            else
            {
                ErrorLabel.Text = "Please Enter Email";
            }

            private void apiCall(int v)
        {
            //set HttpPost method to send Register data to the DB
            HttpClient _cleint = new HttpClient();

            throw new NotImplementedException();
        }
    }
}

