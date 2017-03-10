using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liquid
{
    class Program
    {
        private List<Message> messages;

        static void Main(string[] args)
        {
            Program p = new Program();
            p.SendEmails(p.ReadLogs("test"));
        }

        public List<Message> ReadLogs(string path)
        {
            var data = File.ReadAllLines(path);

            List<Message> messages = new List<Message>();

            foreach (string s in data)
            {
                var part = s.Split(new char[] { ',' });
                Message message = new Message { Title = part[0], Body = part[1], TimeStamp = part[2] };
                messages.Add(message);
            }

            return messages;
        }

        public List<Message> ReadLogsAsXML(string path)
        {
            var data = File.ReadAllLines(path);

            List<Message> messages = new List<Message>();

            //LinqtoXML

            return messages;
        }

        public void SendEmails(List<Message> messages)
        {
            foreach (Message m in messages)
            {
                //send
            }
        }
    }
}
