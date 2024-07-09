using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Hashashins_CRM_Web.Models.Entity;

namespace Hashashins_CRM_Web.Controllers
{
    [Authorize]
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        HashashinsDbEntities db = new HashashinsDbEntities();
        
        public ActionResult AktifCagrilar()
        {
            var mail = (string)Session["Mail_Adresi"];
            var id = db.FirmalarTablosu.Where(x => x.Mail_Adresi == mail).Select(y => y.Firma_ID).FirstOrDefault();
            var aktifcagrilar = db.CagrilarTablosu.Where(x=>x.Durum==true && x.Cagri_Firmasi==id).ToList();
            return View(aktifcagrilar);
        }
        public ActionResult PasifCagrilar()
        {
            var mail = (string)Session["Mail_Adresi"];
            var id = db.FirmalarTablosu.Where(x => x.Mail_Adresi == mail).Select(y => y.Firma_ID).FirstOrDefault();
            var pasifcagrilar = db.CagrilarTablosu.Where(x => x.Durum == false && x.Cagri_Firmasi==id).ToList();
            return View(pasifcagrilar);
        }
        [HttpGet]
        public ActionResult YeniCagri()
        {

            return View();
        }
        [HttpPost]
        public ActionResult YeniCagri(CagrilarTablosu p)
        {
            var mail = (string)Session["Mail_Adresi"];
            var id = db.FirmalarTablosu.Where(x => x.Mail_Adresi == mail).Select(y => y.Firma_ID).FirstOrDefault();
            p.Durum = true;
            p.Tarih = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.Cagri_Firmasi = id;
            db.CagrilarTablosu.Add(p);
            db.SaveChanges();
            return RedirectToAction("AktifCagrilar");
        }
        public ActionResult CagriDetay(int id)
        {
            var cagridetay = db.CagriDetaylariTablosu.Where(x => x.Cagri_ID == id).ToList();
            return View(cagridetay);

        }
        public ActionResult CagriGetir(int id)
        {
            var cagrigetir = db.CagrilarTablosu.Find(id);
            return View("CagriGetir", cagrigetir);
        }
        public ActionResult CagriDuzenle(CagrilarTablosu p)
        {
            var cagriduzenle = db.CagrilarTablosu.Find(p.Cagri_ID);
            cagriduzenle.Konu = p.Konu;
            cagriduzenle.Aciklama = p.Aciklama;
            db.SaveChanges();
            return RedirectToAction("AktifCagrilar");
        }
        public ActionResult CikisYap()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Index", "Login");

        }
    }
}