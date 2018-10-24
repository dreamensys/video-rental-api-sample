using RentalVideo.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RentalVideo.ActionFilters
{
    public class CustomAuthorizeAttribute : AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            if (SessionHelper.CurrentUser == null)
            {
                filterContext.Result = new RedirectResult("/Account/Login");
            }
            
        }
        
    }
}