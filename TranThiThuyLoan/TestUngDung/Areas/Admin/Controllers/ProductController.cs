using ModelEF.Dao;
using ModelEF.Model;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestUngDung.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        // GET: Admin/Product

        public ActionResult Index(int page = 1, int pagesize = 5)
        {
            var pro = new ProductDao();
            var model = pro.ListAllPro();
            return View(model.ToPagedList(page, pagesize));
        }
        [HttpPost]
        public ActionResult Index(string searchString, int page = 1, int pagesize = 5)
            {
                var pro = new ProductDao();
                var model = pro.ListWhereAllPro(searchString, page, pagesize);
                ViewBag.SearchString = searchString;
                return View(model);
            }
            public ActionResult Detail(int id)
            {
                var pro = new ProductDao().FindPro(id);
                return View(pro);
            }
        
        [HttpGet]
        public ActionResult Create()
        {
            SetViewBag();
            return View();
        }
        public void SetViewBag(int? selectedId=null)
        {
            var dao = new CategoryDao();
            ViewBag.IDCate = new SelectList(dao.ListAllCa(),"ID","Name",selectedId);
        }
        [HttpPost]
        public ActionResult Create(Product model)
        {
            if (ModelState.IsValid)
            {
                var dao = new ProductDao();
                //SetViewBag();
                long result = dao.Insert(model);

                if (result > 0)
                {
                    return RedirectToAction("Index", "Product");
                }
                else
                {
                    ModelState.AddModelError("", "Tạo sản phẩm không thành công");
                }
            }
            SetViewBag();
            return View("Index");
        }
       
    }
}
