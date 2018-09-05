using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ClientMobile
{
    public partial class CreatePage : ContentPage
    {
        public async void Handle_Clicked(object sender, System.EventArgs e)
        {
            TodoItem todo = new TodoItem
            {
                Id = int.Parse(txtId.Text),
                Name = txtName.Text,
                IsComplete = true
            };

            Service service = new Service();
            try
            {
                await service.PostTodos(todo);
                await DisplayAlert("Registration", "Activity recorded successfully", "OK");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"{ex.Message}", "Cancel");
            }
        }

        public CreatePage()
        {
            InitializeComponent();
        }
    }
}
