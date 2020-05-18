using KaraerAuto.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebApplication4.Models;

namespace WebApplication4.Areas.Admin.Controllers
{
    public class SecurityController : Controller
    {
        OtoContext klx = new OtoContext();
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Kullanici kullanici)
        {
            var k = klx.Kullanicilar.FirstOrDefault(x => x.KullaniciAd == kullanici.KullaniciAd && x.Sifre == kullanici.Sifre);
            if (k != null)
            {
                FormsAuthentication.SetAuthCookie(k.KullaniciAd, false);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View("Login", "Security");

            }

        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();

            return View("Login");
        }
    }
}