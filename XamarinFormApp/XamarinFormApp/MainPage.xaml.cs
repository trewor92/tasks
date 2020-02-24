using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using HelloLibrary;

namespace XamarinFormApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void goButton_Clicked(object sender, EventArgs e)
        {
            WriteHello(nameEntry.Text);
            CleanNameEntry();
        }

        private void WriteHello(string name)
        {
            //welcomeLabel.Text = "Hello, " + (String.IsNullOrEmpty(nameEntry.Text) ? "not authorized user" : nameEntry.Text) + "!";
            welcomeLabel.Text = Hello.TimeHello(name);
        }

        private void CleanNameEntry()
        {
            nameEntry.Text = String.Empty;
        }
    }
}
