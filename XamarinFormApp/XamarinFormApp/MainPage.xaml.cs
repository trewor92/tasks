using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

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
            welcomeLabel.Text = "Hello, " + (String.IsNullOrEmpty(nameEntry.Text) ? "not authorized user" : nameEntry.Text) + "!";
            nameEntry.Text = String.Empty;
        }
    }
}
