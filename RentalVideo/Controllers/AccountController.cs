using RentalVideo.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using RentalVideo.ActionFilters;
using RentalVideo.Repository;
using RentalVideo.Helpers;

namespace RentalVideo.Controllers
{

    
    [CustomGlobalization()]
    public class AccountController : Controller
    {
        // GET: Account
        private UserRepository usersRepository = UserRepository.GetInstance();
        public ActionResult Index()
        {
            return View();
        }

        // Get Login
        public ActionResult Login()
        {
            if (SessionHelper.CurrentUser != null)
            {
                return RedirectToAction("Index", "Movie");
            }
            return View();
        }

        public ActionResult SignOut()
        {
            SessionHelper.DeleteUserSession();
            return RedirectToAction("Login");
        }

        [HttpPost]
        public ActionResult Login(UserLoginVIewModel model)
        {
            if (ModelState.IsValid)
            {
                UserLoginVIewModel user = usersRepository.AuthenticateUser(model.Email, model.Password);
                if (user != null)
                {
                    Session.Add(SessionHelper.USER_SESSION_KEY, user);
                    return RedirectToAction("Index", "Movie");
                }
            }
            return View();
        }

        // Get Account/Register
        public ActionResult Register()
        {
            return View();
        }

        // Post Account/Register
        [HttpPost]
        public ActionResult Register(UserModelView user)
        {   
            if (ModelState.IsValid)
            {
                // Crear usuario en la BD.                
                var lang = Request.Cookies[SessionHelper.USER_SESSION_COOKIE_KEY];
                if (lang != null)
                {
                    user.Language = lang.ToString();
                }
                else {
                    SessionHelper.CreateCookie(user.Language, Response);
                }
                Session.Add(SessionHelper.USER_SESSION_KEY, user);
                return RedirectToAction("Index","Movie");
            }
            return View();
        }
        
    }
}