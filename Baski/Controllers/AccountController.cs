using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web.Mvc;
using Baski.Authentication.Models;
using Baski.Controllers;


namespace AppWithFormsAuthentication.Controllers
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
