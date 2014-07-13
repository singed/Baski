using System.Web.Mvc;

namespace Baski.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
            "Admin_account",
            "Account/LogOn/{returnUrl}",
            new { action = "LogOn", controller = "Account", id = UrlParameter.Optional }
        );
           
            context.MapRoute(
               "Admin_home",
               "Admin",
               new { action = "Index", controller = "DefaultAdmin", id = UrlParameter.Optional }
           );
          
          
            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}