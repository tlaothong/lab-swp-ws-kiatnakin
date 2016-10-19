using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
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

        private async void NumWcfButton_Click(object sender, EventArgs e)
        {
            var svc = new FirstWcfSvc.FirstWcfServiceClient();
            var number = Convert.ToInt32(NameTextBox.Text);
            var result = await svc.NumToEngAsync(number);
            MessageBox.Show(result);
        }

        private void Add200Button_Click(object sender, EventArgs e)
        {
            var svc = new FirstWcfWeb.FirstWcfService();
            var number = Convert.ToInt32(NameTextBox.Text);
            svc.Add200Completed += Svc_Add200Completed;
            svc.Add200Async(number, true);
        }

        private void Svc_Add200Completed(object sender, FirstWcfWeb.Add200CompletedEventArgs e)
        {
            var result = e.Result;
            MessageBox.Show(result);
        }

        private void FaultButton_Click(object sender, EventArgs e)
        {
            try
            {
                var svc = new FirstWcfSvc.FirstWcfServiceClient();
                var c = svc.Div(20, 0);
                MessageBox.Show(string.Format("c: {0}", c));
            }
            catch (FaultException<FirstWcfSvc.DivFault> ex)
            {
                MessageBox.Show(ex.Code.Name);
                MessageBox.Show(string.Format("A: {0}, B: {1}",
                    ex.Detail.A, ex.Detail.B));
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
