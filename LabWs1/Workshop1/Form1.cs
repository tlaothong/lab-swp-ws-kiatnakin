using System;
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
    }
}
