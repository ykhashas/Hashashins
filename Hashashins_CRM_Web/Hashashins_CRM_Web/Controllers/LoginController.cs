using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Hashashins_CRM_Web.Models.Entity;
using System.Web.Mvc;
using System.Web.Security;

namespace Hashashins_CRM_Web.Controllers
{
    public class LoginController : Controller
    {
        HashashinsDbEntities db = new HashashinsDbEntities();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(FirmalarTablosu p)
        {
            var bilgiler = db.FirmalarTablosu.FirstOrDefault(x => x.Mail_Adresi == p.Mail_Adresi && x.Sifre == p.Sifre);
            if (bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.Mail_Adresi, false);
                Session["Mail_Adresi"] = bilgiler.Mail_Adresi.ToString();
                return RedirectToAction("AktifCagrilar", "Default");

            }
            else
            {
                return RedirectToAction("Index");
            }
            
        }
    }
}