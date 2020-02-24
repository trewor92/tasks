using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HelloLibrary;

namespace WinFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            WriteHello(nameTextBox.Text);
            CleanNameTextBox();
        }

        private void WriteHello(string name)
        {
            //welcomeLabel.Text = "Hello, " + (String.IsNullOrEmpty(name) ? "not authorized user" : nameTextBox.Text) + "!";
            welcomeLabel.Text = Hello.TimeHello(name);
        }

        private void CleanNameTextBox()
        { 
            nameTextBox.Text = String.Empty;
        }
    }
}
