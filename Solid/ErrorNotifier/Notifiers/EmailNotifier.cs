using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;

namespace ErrorNotifier
{
    public class EmailNotifier : Notifier
    {
        public EmailNotifier(string from, string title, IBodyBuilder arnold) : base(from, title, arnold)
        {
        }

        protected override void Notify(string to, string from, string title, string body)
        {
            MailMessage message = new MailMessage();
            message.To.Add(to);
            message.Subject = title;
            message.IsBodyHtml = false;

            message.Body = body;
            new SmtpClient().Send(message);
        }
    }
}