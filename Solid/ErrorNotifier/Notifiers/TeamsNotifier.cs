using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ErrorNotifier
{
    public class TeamsNotifier : Notifier
    {
        public TeamsNotifier(string from, string title, IBodyBuilder arnold) : base(from, title, arnold)
        {
        }
        protected override void Notify(string to, string from, string title, string body)
        {
            throw new NotImplementedException();
        }
    }
}