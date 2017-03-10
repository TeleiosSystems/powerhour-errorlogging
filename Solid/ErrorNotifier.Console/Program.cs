using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorNotifier
{
    class Program
    {
        static void Main(string[] args)
        {
            // Setup Dependencies 
            IUnityContainer container = new UnityContainer();
            container.RegisterType<ILogParser, FileLogParser>();
            container.RegisterType<IBodyBuilder, BodyBuilder>();
            container.RegisterType<Notifier, EmailNotifier>();
            ILogParser parser = container.Resolve<ILogParser>();
            Notifier notifier = container.Resolve<Notifier>(
                new ParameterOverride("from", "work@work.com"), 
                new ParameterOverride("title", "Errors in your console"));

            string location = "errors.txt";
            var logs = parser.Parse(location);

            List<string> recipients = GetRecipients();
            notifier.Send(logs, recipients);

            Console.WriteLine("Sent!");
            Console.ReadLine();
        }

        private static List<string> GetRecipients()
        {
            return new List<string>
            {
                "anand.singh@teleios-systems.com",
                "anandcsingh@gmail.com"
            };
        }
    }
}
