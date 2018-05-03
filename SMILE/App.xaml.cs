using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App2
{
	public partial class App : Application
	{
        public App()
        {
            StackLayout layout = new StackLayout
            {
                VerticalOptions = LayoutOptions.CenterAndExpand,
            };

            MainPage = new ContentPage {
                Content = layout,
                BackgroundColor = Color.Orange,
            };

            Label label = new Label
            {
                HorizontalTextAlignment = TextAlignment.Center,
                TextColor = Color.DarkGoldenrod,
                Text = "SMILE",
                BackgroundColor = Color.White,
                FontSize = 50
            };

            Label switchLabel = new Label
            {
                Text = "Big Text",
                HorizontalTextAlignment = TextAlignment.Start,
                FontSize = 15
            };

            Button button = new Button {
                Text = "Blue Background"
            };

            button.Clicked += OnButtonClicked;

            button.Pressed += (a, c) =>
            {
                button.BackgroundColor = Color.Black;
                button.TextColor = Color.White;
            };

            button.Released += (z, d) => {
                button.BackgroundColor = Color.White;
                button.TextColor = Color.Black;
            };

                void OnButtonClicked(Object sender, EventArgs e)
                {

                    if (label.BackgroundColor == Color.White)
                    {
                        label.BackgroundColor = Color.Blue;
                    }
                    else
                    {
                        label.BackgroundColor = Color.White;
                    }
                };

            Switch bigSmall = new Switch
            {
                HorizontalOptions = LayoutOptions.Start,
            };

            bigSmall.Toggled += bigSmallToggled;

            void bigSmallToggled(Object sender, EventArgs e)
            {
                if (bigSmall.IsToggled == true)
                {
                    label.FontSize = 100;
                }
                else
                {
                    label.FontSize = 50;
                }
            };

            layout.Children.Add(label);
            layout.Children.Add(button);
            layout.Children.Add(switchLabel);
            layout.Children.Add(bigSmall);


        }

        protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
