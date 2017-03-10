using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ErrorNotifier
{
    public abstract class Notifier
    {
        protected string from;
        protected string title;
        protected IBodyBuilder arnold;
        public Notifier(string from, string title, IBodyBuilder arnold)
        {
            this.from = from;
            this.title = title;
            this.arnold = arnold;
        }
        protected abstract void Notify(string to, string from, string title, string body);

        public void Send(IEnumerable<ErrorLog> logs, IEnumerable<string> recipients)
        {
            string body = arnold.Workout(logs);

            foreach (var recipient in recipients)
            {
                Notify(recipient, from, title, body);
            }
        }
        
    }
}