using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ClientMobile
{
    public partial class ListPage : ContentPage
    {
        void Handle_ItemTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            var todo = e.Item as TodoItem;
            DisplayAlert("Choosen Item", $"{todo.Id} - {todo.Name}","OK");
        }

        public ListPage()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            Service rp = new Service();
            lstv.ItemsSource = await rp.GetTodos();
        }
    }
}
