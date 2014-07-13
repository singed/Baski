using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Routing;

namespace Baski.Helpers
{
    public static class CustomUrlHelper
    {
        public static string ArticleUrl(this UrlHelper helper, int id)
        {
            return helper.RouteUrl("Article", new {id = id});
        }
    }
}
