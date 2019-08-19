using System;
using Xamarin.Forms;

namespace MDM
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            webView.Source = "https://206r2b1c.github.io/android.html"; 
        }

        private void OnToolbarItemClicked(object sender, EventArgs e)
        {

        }
    }
}
