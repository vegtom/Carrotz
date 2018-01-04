using System;
using System.Collections.Generic;
using CarrotZ.Models;
using Xamarin.Forms;

namespace CarrotZ.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        async void SignInProcedure(object sender, EventArgs e)
        {
            User user = new User(Entry_Username.Text, Entry_Password.Text);
            if (user.CheckInformation())
            {
                await DisplayAlert("Login", "Login Success", "OK");
                await Navigation.PushAsync(new TopLevel());
            }
            else
            {
                await DisplayAlert("Login", "Login not correct", "OK");
            }
        }
    }
}
