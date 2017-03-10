using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorNotifier
{
    public class ErrorLog
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Stack { get; set; }
        public DateTime Timestamp { get; set; }
        public Dictionary<string, string> AdditionalData { get; set; }
    }
}
