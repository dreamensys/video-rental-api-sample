using RentalVideo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentalVideo.Helpers
{
    public static class SessionHelper
    {
        public const string USER_SESSION_KEY = "USERSESSION";
        public const string USER_SESSION_COOKIE_KEY = "USERLANGUAGECOOKIE";

        public static UserLoginVIewModel CurrentUser
        {
            get
            {
                return HttpContext.Current.Session[USER_SESSION_KEY] as UserLoginVIewModel;
            }
            set
            {
                HttpContext.Current.Session[USER_SESSION_KEY] = value;
            }
        }

        public static void CreateCookie(string cookieValue, HttpResponseBase response)
        {
            HttpCookie cookie = new HttpCookie(USER_SESSION_COOKIE_KEY);
            cookie.HttpOnly = true;
            cookie.Value = cookieValue;
            cookie.Expires = DateTime.Now.AddMonths(1);
            response.Cookies.Add(cookie);
        }

        public static void DeleteUserSession()
        {
            HttpContext.Current.Session[USER_SESSION_KEY] = null;
        }

    }
}