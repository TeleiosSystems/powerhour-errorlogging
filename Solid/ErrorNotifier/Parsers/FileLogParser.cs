using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorNotifier
{
    public class FileLogParser : ILogParser
    {
        public IEnumerable<ErrorLog> Parse(string location)
        {
            List<ErrorLog> logs = new List<ErrorLog>();
            var lines = File.ReadAllLines(location);

            foreach (var line in lines)
            {
                string[] cols = line.Split(',');
                logs.Add(new ErrorLog
                {
                    Title = cols[0],
                    Description = cols[1],
                    Timestamp = DateTime.Parse(cols[2])
                });
            }

            return logs;
        }
    }
}
