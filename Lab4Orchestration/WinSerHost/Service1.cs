using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace WinSerHost
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        private ServiceHost host;

        protected override void OnStart(string[] args)
        {
            if (host != null)
            {
                host.Close();
            }
            host = new ServiceHost(typeof(BankAService.BankAService));
            host.Open();
        }

        protected override void OnStop()
        {
            if (host != null)
            {
                host.Close();
            }
            host = null;
        }
    }
}
