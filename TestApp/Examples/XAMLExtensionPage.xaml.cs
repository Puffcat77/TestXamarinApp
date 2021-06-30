using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestApp.Examples
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class XAMLExtensionPage : ContentPage
    {
        public string TutorialLink { get; private set; }

        public static double fontSize = 24;

        public const string attrCommand = "x:Static local:[Class name].[property/variable]";

        public const string localNamespace = "xmlns:local=\"clr-namespace:[Project name][.Sub directories]\"";

        public static string[] builtInExtensions;

        public XAMLExtensionPage(string tutorialLink)
        {
            InitializeComponent();

            TutorialLink = tutorialLink;
            builtInExtensions = new string[] 
            {
                "x:Static", "x:Type",
                "x:Array", "x:Null",
                "x:Reference", "StaticResourse",
                "DynamicResourse", "Binding", "ConstaintExpression"
            };
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