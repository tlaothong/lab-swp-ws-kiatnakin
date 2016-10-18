﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workshop1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CallButton_Click(object sender, EventArgs e)
        {
            var svc = new SimpleSvc.SimpleWebService();
            //svc.PreAuthenticate = true;
            var result = svc.Greeting(NameTextBox.Text);
            MessageBox.Show(result);
        }

        private void CallSvcButton_Click(object sender, EventArgs e)
        {
            var svc = new SimpleWcf.SimpleWcfClient();
            var result = svc.Greeting(NameTextBox.Text);
            MessageBox.Show(result);
        }

        private void NumToTextButton_Click(object sender, EventArgs e)
        {
            var svc = new FirstSvc.FirstService();
            var number = Convert.ToInt32(NameTextBox.Text);
            var result = svc.NumToEng(number);
            MessageBox.Show(result);
        }

        private void Add100Button_Click(object sender, EventArgs e)
        {
            var svc = new FirstSvc.FirstService();
            // Call Add100 here
            var number = Convert.ToInt32(NameTextBox.Text);
            var result = svc.Add100(number);
            MessageBox.Show(result);
        }

        private void NumWcfButton_Click(object sender, EventArgs e)
        {
            var svc = new FirstWcfSvc.FirstWcfServiceClient();
            var number = Convert.ToInt32(NameTextBox.Text);
            var result = svc.NumToEng(number);
            MessageBox.Show(result);
        }

        private void Add200Button_Click(object sender, EventArgs e)
        {
            var svc = new FirstWcfWeb.FirstWcfService();
            var number = Convert.ToInt32(NameTextBox.Text);
            var result = svc.Add200(number, false);
            MessageBox.Show(result);
        }
    }
}
