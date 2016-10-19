using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClientNet4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private void Add200Callback(IAsyncResult ar)
        //{
        //    var result = svclient.EndAdd200(ar);
        //    MessageBox.Show(result);
        //}

        //FirstWcfSvc.FirstWcfServiceClient svclient = new FirstWcfSvc.FirstWcfServiceClient();

        private void Add200Button_Click(object sender, EventArgs e)
        {
            var svc = new FirstWcfSvc.FirstWcfServiceClient();
            var number = Convert.ToInt32(NumberTextBox.Text);

            //var ar = svclient.BeginAdd200(number, Add200Callback, null);

            svc.Add200Completed += Svc_Add200Completed1;
            svc.Add200Async(number);
            //var result = svc.Add200(number);
        }

        private void Svc_Add200Completed1(object sender, FirstWcfSvc.Add200CompletedEventArgs e)
        {
            var result = e.Result;
            MessageBox.Show(result);
        }

        private void Svc_Add200Completed(object sender, FirstWcfSvc.Add200CompletedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
