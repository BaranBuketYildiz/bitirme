using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HealthyLife.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Profil()
        {
            return View();
        }

        public ActionResult Anasayfa()
        {
            return View();
        }

        public ActionResult KayıtOl()
        {
            return View();
        }

        public ActionResult YemekServisi()
        {
            return View();
        }

        public ActionResult Giris()
        {
            return View();
        }

        public ActionResult Tarifler()
        {
            return View();
        }
    }
}