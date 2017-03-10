using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorNotifier
{
    public class ConsoleNotifier : Notifier
    {
        public ConsoleNotifier(string from, string title, IBodyBuilder arnold) : base(from, title, arnold)
        {
        }

        protected override void Notify(string to, string from, string title, string body)
        {
            Console.WriteLine(string.Format("{0} {1} {2}{3}{4}{3}", to, from, title, Environment.NewLine, body));
        }
    }
}
