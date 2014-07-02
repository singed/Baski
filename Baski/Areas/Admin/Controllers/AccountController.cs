using System;
using System.Web.Mvc;
using Baski.Authentication.Models;
using Baski.Controllers;

namespace Baski.Areas.Admin.Controllers
{
    public class AccountController : BaseController
    {
        public ActionResult LogOn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LogOn(LogOnModel model, string returnUrl)
        {
            try
            {
                if (AccountService.MembershipService.LogOnUser(model))
                {
                    AccountService.FormsAuthenticationService.SignIn(model.Email, true);
                    return Redirect(returnUrl);
                }
            }
            catch (Exception)
            {
                return LogOn();
            }

            return LogOn();
        }
      
    }
    
}
