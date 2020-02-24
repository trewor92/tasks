﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            welcomeLabel.Text = "Hello, " + (String.IsNullOrEmpty(nameTextBox.Text) ? "not authorized user" : nameTextBox.Text) + "!";
            nameTextBox.Text = String.Empty;
        }
    }
}