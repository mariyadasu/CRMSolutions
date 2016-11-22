using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRM.Project.Models.User;
using CRM.Service.Authentication;

namespace CRM.Project.Controllers.User
{

    public class LoginController : Controller
    {
        private readonly IAuthenticationService _iAuthenticationService;

        public LoginController(IAuthenticationService iAuthenticationService)
        {
            _iAuthenticationService = iAuthenticationService;
        }

        // GET: Login
        public ActionResult Login()
        {
            LoginViewModel model = new LoginViewModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel userInfo)
        {
            bool userExist = _iAuthenticationService.CheckUserByUserNameAndPwd(userInfo.UserName, userInfo.Password);

            if(userExist)
                return RedirectToAction("Index", "DashBoard", new { area = "" });

            userInfo.UserName = userInfo.Password = string.Empty;
            ViewBag.InvalidUser = true;
            return View(userInfo);
        }
    }
}