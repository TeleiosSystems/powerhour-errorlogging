using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorNotifier
{
    public interface ILogParser
    {
        IEnumerable<ErrorLog> Parse(string location);
    }
}
