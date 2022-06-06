using AppService.DTOs;
using MVC_project.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Security;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using static System.Net.WebRequestMethods;

namespace MVC_project.Controllers
{
    public class HomeController : Controller
    {
        [AllowAnonymous]
        public ActionResult Index()
        {
          
            return View();
        }

        [AllowAnonymous]
        public ActionResult Login()
        {

            return View();
        }

          [HttpPost]
          [AllowAnonymous]
           [ValidateAntiForgeryToken]
          public ActionResult Login(LoginVM loginVM)
           {
             try
            {
             
                using (AuthenticationService.AuthenticationClient service = new AuthenticationService.AuthenticationClient())
                {

                    LoginDTO loginDTO = new LoginDTO
                    {
                        Username = loginVM.Username,
                        Password = loginVM.Password
                    };
                    if(service.Authenticate(loginDTO).Equals("User is valid"))
                    {
                        FormsAuthentication.SetAuthCookie(loginVM.Username,loginVM.RememberMe);
                        return RedirectToAction("Index");
                    }else
                    {
                      
                        loginVM=new LoginVM();
                        return View();
                    }
                      
                }
               

            }catch{
                return View();
             
           }
           
        }
  
        [Authorize]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index");
        }

    }
}