using ModelEF.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestUngDung.Controllers
{
    public class HomeCustomController : Controller
    {
        // GET: HomeCustom
        public ActionResult Index()
        {
            var procus = new ProcustomDao();
            ViewBag.ProKhai = procus.ListProKhai();
            ViewBag.ProBo = procus.ListProBo();
            ViewBag.ProChuc = procus.ListProChuc();
            ViewBag.ProLe = procus.ListProLe();
            return View();
        }
    }
}