using System;
using System.Web.Mvc;
using Baski.Authentication.Models;

namespace Baski.Controllers
{
    public class AccountController : BaseController
    {
        public ActionResult LogOn(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
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
                return LogOn(returnUrl);
            }

            return LogOn(returnUrl);
        }
      
    }
    
}
