using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace DemoTopshelfService
{
    class Program
    {
        static void Main(string[] args)
        {
            HostFactory.Run(hc =>
            {
                hc.Service<MyTopshelfService>(shc =>
                {
                    shc.ConstructUsing(() => new MyTopshelfService());
                    shc.WhenStarted(s => s.Start());
                    shc.WhenStopped(s => s.Stop());
                });
                hc.RunAsLocalSystem();
                hc.SetServiceName("MyTopshelfService");
                hc.SetDisplayName("MyTopshelf Service");
                hc.SetDescription("Description");
            });
        }
    }

    public class MyTopshelfService
    {
        public void Start()
        {
            Console.WriteLine("Service is starting...");
        }

        public void Stop()
        {
            Console.WriteLine("Service is stopping ...");
        }
    }
}
