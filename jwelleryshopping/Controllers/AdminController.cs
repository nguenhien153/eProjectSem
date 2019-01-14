using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using jwelleryshopping.Models;

namespace jwelleryshopping.Controllers
{
    public class AdminController : Controller
    {
        dataDataContext db = new dataDataContext();
        // GET: Admin
        public ActionResult Index()
        {
            if (Session["admin"]!=null) {
                return View(db.AdminLoginMsts.Single(i=>i.userName.Equals(Session["admin"])));
            }
            return View("Login");
        }

        public ActionResult Login()
        {
            return View("Login", "_LayoutLogin");
        }
        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            var result = db.AdminLoginMsts.Count(i => i.userName.Equals(username) && i.Password.Equals(password));
            if (result!=0) {
                Session["admin"] = username;
                return RedirectToAction("Index");
            }
            Session["check"] = "fail";
            return View();
        }

        public ActionResult Brand()
        {
            if (Session["admin"] != null)
            {
                return View(db.BrandMsts.ToList());
            }
            return View("Login");
        }

        public ActionResult AddBrand()
        {
            if (Session["admin"] != null)
            {
                return View();
            }
            return View("Login");
        }
        [HttpPost]
        public ActionResult AddBrand(BrandMst newbrand)
        {
            if (Session["admin"] != null)
            {
                db.BrandMsts.InsertOnSubmit(newbrand);
                db.SubmitChanges();
                return View();
            }
            return View("Login");
        }

        public ActionResult EditBrand(int id)
        {
            if (Session["admin"] != null)
            {
                return View(db.BrandMsts.Where(i=>i.Brand_ID.Equals(id)));
            }
            return View("Login");
        }
        [HttpPost]
        public ActionResult EditBrand(BrandMst brand)
        {
            if (ModelState.IsValid)
            {
                var edbrand=db.BrandMsts.Single(i => i.Brand_ID.Equals(brand.Brand_ID));
                edbrand.Brand_Type = brand.Brand_Type;
                db.SubmitChanges();
                return View();
            }
            return View("Login");
        }

        public ActionResult DetailsBrand(int id)
        {
            if (Session["admin"] != null)
            {
                return View(db.BrandMsts.Where(i => i.Brand_ID.Equals(id)));
            }
            return View("Login");
        }

        public ActionResult ManageUser()
        {
            if (Session["admin"] != null)
            {
                return View(db.UserRegMsts.ToList());
            }
            return View("Login");
        }
    }
}