using System;

using Xamarin.Forms;

namespace CarrotZ.Views
{
    public class TopLevel : ContentPage
    {
        public TopLevel()
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

