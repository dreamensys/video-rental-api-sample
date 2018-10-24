using RentalVideo.Models;
using System;
using System.Globalization;
using System.Threading;
using System.Web.Mvc;

namespace RentalVideo.ActionFilters
{
    public class CustomGlobalizationAttribute : ActionFilterAttribute
    {
        private string _defaultLanguage;

        public CustomGlobalizationAttribute()
        {
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var user = filterContext.HttpContext.Session["USERSESSION"] as UserModelView;
            if (user != null)
            {
                _defaultLanguage = user.Language;
            }
            if (string.IsNullOrEmpty(_defaultLanguage))
            {
                _defaultLanguage = "es";
            }

            try
            {
                Thread.CurrentThread.CurrentCulture = Thread.CurrentThread.CurrentUICulture = new CultureInfo(_defaultLanguage);
            }
            catch (ThreadInterruptedException ex)
            {
                // Write on log.
                throw;
            }
        }
    }
}