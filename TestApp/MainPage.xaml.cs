using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using TestApp.Examples;

namespace TestApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void SimpleExBtn_Clicked(object sender, EventArgs e)
        {
            var simplePage = new SimpleExamplePage("https://metanit.com/sharp/xamarin/2.9.php");
            Navigation.PushAsync(simplePage, false);
        }

        private void XAMLExtensionExBtn_Clicked(object sender, EventArgs e)
        {
            var xAMLExtesionPage = new XAMLExtensionPage("https://metanit.com/sharp/xamarin/2.11.php");
            Navigation.PushAsync(xAMLExtesionPage, false);
        }
    }
}
