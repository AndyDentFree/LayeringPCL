﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PurePCLViewModel;

using Xamarin.Forms;

namespace ThreeLayerXF {
    public class App : Application
    {

        private readonly PurePCLVieModel _model;

        public App()
        {
            _model = new PurePCLViewModel();
            var button = new Button() {Text = "Test PCL",
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
            };
            button.Clicked += (s, e) => button.Text = "Clicked: " + clicked++;

            // The root page of your application
            MainPage = new ContentPage
            {
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                        new Label {
                            XAlign = TextAlignment.Center,
                            Text = "Welcome to ThreeLayer PCL in Forms!"
                        },
                        button,
                        new Label {
                            XAlign = TextAlignment.Center,
                            Text = " "
                        }

                    }
                }
            };
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
