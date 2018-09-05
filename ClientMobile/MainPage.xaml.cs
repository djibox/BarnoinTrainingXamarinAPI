using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ClientMobile
{
    public partial class MainPage : ContentPage
    {

        void Handle_Clicked_8(object sender, System.EventArgs e)
        {
            //throw new NotImplementedException();
        }

        void Handle_Clicked_7(object sender, System.EventArgs e)
        {
            //throw new NotImplementedException();
        }

        void Handle_Clicked_6(object sender, System.EventArgs e)
        {
            //throw new NotImplementedException();
        }

        public async void Handle_Clicked_2(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Simplicity());
        }

        public async void Handle_Clicked_3(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Simplicity());
        }

        public async void Handle_Clicked_4(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Simplicity());
        }

        public async void Handle_Clicked_5(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Simplicity());
        }

        void Handle_Clicked_1(object sender, System.EventArgs e)
        {
            //throw new NotImplementedException();
        }

        public async void  Handle_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CreatePage());
        }

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
