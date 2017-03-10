using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorNotifier
{
    public class BodyBuilder : IBodyBuilder
    {
        public string Workout(IEnumerable<ErrorLog> logs)
        {
            StringBuilder builder = new StringBuilder();

            foreach (var item in logs)
            {
                builder.AppendFormat("{0}\t{1}{2}{3}{2}", item.Title, item.Timestamp.ToString(), Environment.NewLine, item.Timestamp);
            }

            return builder.ToString();
        }
    }
}
