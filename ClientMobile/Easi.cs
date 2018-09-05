using System;

using Xamarin.Forms;

namespace ClientMobile
{
    public class Easi : ContentPage
    {
        public Easi()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

