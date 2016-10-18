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

        private void Add200Button_Click(object sender, EventArgs e)
        {
            var svc = new FirstWcfSvc.FirstWcfServiceClient();
            var number = Convert.ToInt32(NumberTextBox.Text);
            var result = svc.Add200(number);
            MessageBox.Show(result);
        }
    }
}
