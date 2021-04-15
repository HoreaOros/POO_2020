using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public class Strings
    {
        public static string BuildString(List<object> items)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in items)
            {
                sb.Append(item.ToString());
                sb.AppendLine();
            }

            return sb.ToString();
        }
    }
}
