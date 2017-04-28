using System;
using Xamarin.Forms;

namespace CiCdApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void MyGoodButton_OnClicked(object sender, EventArgs e)
        {
            MyTextEntry.Text = "TADA!";
        }
    }
}