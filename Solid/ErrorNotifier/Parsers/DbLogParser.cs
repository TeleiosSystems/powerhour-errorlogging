using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorNotifier
{
    public class DbLogParser : ILogParser
    {
        public IEnumerable<ErrorLog> Parse(string location)
        {
            throw new NotImplementedException();
        }
    }
}
