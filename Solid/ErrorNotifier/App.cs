using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorNotifier
{
    public class App
    {
        ILogParser parser;
        Notifier notifier;
        IEnumerable<string> recipients;
        string logLocation;
        public App(string logLocation, ILogParser parser, Notifier notifier, IEnumerable<string> recipients)
        {
            this.parser = parser;
            this.notifier = notifier;
            this.recipients = recipients;
            this.logLocation = logLocation;
        }

        public void Run()
        {
            var logs = parser.Parse(logLocation);
            notifier.Send(logs, recipients);
        }
    }
}
