﻿using System;
using Xamarin.Forms;

namespace BlueSheep
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = new MainViewModel();
            var item = new LogItems();
        }

        void GoToLogPage(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new RawLog());
        }

        void GoToChartPage(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new DataRep());
        }

        void Log_To_Server(object sender, System.EventArgs e)
        {
            var listViewItem = (MenuItem)sender;
            string log = (string)listViewItem.CommandParameter;
            //TO DO: Clear the data in the log once it is passed to the server to reduce overlapping

            Navigation.PushAsync(new RawLog(log));

        }
    }
}
