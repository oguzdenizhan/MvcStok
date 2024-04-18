using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcStok.Models.Entity;
namespace MvcStok.Controllers
{
    public class MusterilerController : Controller
    {
        // GET: Musteriler
        MvcDbStockEntities db = new MvcDbStockEntities();
        public ActionResult Index()
        {
            var degerler = db.TBLMUSTERILER.ToList();
            return View(degerler);
        }
    }
}