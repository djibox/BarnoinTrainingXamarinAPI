using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ClientMobile
{
    public partial class Simplicity : ContentPage
    {
		async void Handle_Clicked(object sender, System.EventArgs e)
        {
			await DisplayAlert("Measure Simplicity","Vote saved successfully !!!","OK");
			await Navigation.PushAsync(new MainPage());
        }

        public Simplicity()
        {
            InitializeComponent();
        }
    }
}
