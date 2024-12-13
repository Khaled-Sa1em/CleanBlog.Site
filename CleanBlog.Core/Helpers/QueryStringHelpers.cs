using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace CleanBlog.Core.Helpers
{
    public static class QueryStringHelpers
    {
        public static int GetIntFromQueryString(HttpRequestBase reqest, string key, int fallbackValue = 0)
        {
            var stringValue = reqest.QueryString[key];
            if (!string.IsNullOrWhiteSpace(stringValue) && int.TryParse(stringValue, out var numaricValue))
            {
                return numaricValue;
            }
            return fallbackValue;
        }
    }
}
