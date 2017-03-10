using System.Collections.Generic;

namespace ErrorNotifier
{
    public interface IBodyBuilder
    {
        string Workout(IEnumerable<ErrorLog> logs);
    }
}