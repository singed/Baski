using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Baski.Authentication
{
    public class CustomAuthorize : AuthorizeAttribute
    {
        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            if (filterContext.HttpContext.User.Identity.IsAuthenticated)
            {
                base.HandleUnauthorizedRequest(filterContext);
            }
            else
            {
               /* filterContext.Result = new RedirectToRouteResult(new
                RouteValueDictionary(new { controller = "Account", action = "LogOn",  }));
*/
               /* filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary
                {
                    {"controller" , "Account"}, 
                    {"action" , "LogOn"},
                    { "returnUrl", filterContext.HttpContext.Request.RawUrl}
                });*/
                string loginUrl = "/Account/LogOn?returnUrl=" + filterContext.HttpContext.Request.RawUrl;
                filterContext.Result = new RedirectResult(loginUrl);
            }
        }
    }
}