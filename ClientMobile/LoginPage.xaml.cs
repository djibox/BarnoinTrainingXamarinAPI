using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ClientMobile
{
    public partial class LoginPage : ContentPage
    {
        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            if((txtlogin.Text=="test") && (txtpasswd.Text=="test"))
            {
                await Navigation.PushAsync(new MainPage());
            }
        }

        public LoginPage()
        {
            InitializeComponent();
        }
    }
}
