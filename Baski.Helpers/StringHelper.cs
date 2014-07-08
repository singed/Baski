using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Baski.Helpers
{
    public static class StringHelper
    {
        public static MvcHtmlString ShortenText(this MvcHtmlString text)
        {
           /* string temp = text.ToString();
            if (text.ToString().Length > 50)
            {
                return text.Substring(0, 50) + "...";
            }*/
            return  text;
        }
    }
}
