using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SimpleExamplePage: ContentPage
    {
        public string TutorialLink { get; private set; }
        public SimpleExamplePage(string tutorialLink)
        {
            InitializeComponent();
            TutorialLink = tutorialLink;
        }
        private void WhooshBtn_Clicked(object sender, EventArgs e)
        {
            ((Button)sender).Text = ((Button)sender).Text != "Whooshed!" ? "Whooshed!" : "Whooshe!";
        }

        private void LinkTapped(object sender, EventArgs e) 
        {
            Launcher.OpenAsync(new Uri(TutorialLink));
        }

        private void CloseBtn_Clicked(object sender, EventArgs e) 
        {
            Navigation.PopAsync();
        }
    }
}