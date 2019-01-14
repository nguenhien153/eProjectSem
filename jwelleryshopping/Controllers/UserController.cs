using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using jwelleryshopping.Models;
namespace jwelleryshopping.Controllers
{
    public class UserController : Controller
    {
        dataDataContext db = new dataDataContext();
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            Session["user"] = null;
            return View();
        }
        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            var result = db.UserRegMsts.Count(i => i.userID.Equals(username) && i.password.Equals(password));
            if (result != 0) {
                Session["user"] = username;
                Session["user1"] = password;
                return RedirectToAction("Index");
            }
            Session["check"] = "fail";
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(UserRegMst User)
        {
            if (ModelState.IsValid) {
                db.UserRegMsts.InsertOnSubmit(User);
                db.SubmitChanges();
            }
            ModelState.AddModelError("", "Invalid");
            return View();
        }

        public ActionResult UpdateUser()
        {
            var r= db.UserRegMsts.Where(i => i.userID.Equals(Session["user"]) && i.password.Equals(Session["user1"]));
            return View(r);
        }
        [HttpPost]
        public ActionResult UpdateUser(UserRegMst User)
        {
            if (ModelState.IsValid)
            {
                var edUser= db.UserRegMsts.Single(i=>i.userID.Equals(User.userID) && i.password.Equals(User.password));
                edUser.address = User.address;
                edUser.city = User.city;
                edUser.mobNo = User.mobNo;
                edUser.state = User.state;
                edUser.emailID = User.emailID;
                db.SubmitChanges();
            }
            ModelState.AddModelError("", "Invalid");
            return View();
        }

        public ActionResult ChangePass()
        {
            var r = db.UserRegMsts.Where(i => i.userID.Equals(Session["user"]) && i.password.Equals(Session["user1"]));
            return View(r);
        }
        [HttpPost]
        public ActionResult ChangePass(UserRegMst User)
        {
            if (ModelState.IsValid)
            {
                var edUser = db.UserRegMsts.Single(i => i.userID.Equals(User.userID) && i.password.Equals(User.password));
                edUser.password = User.password;
                db.SubmitChanges();
            }
            ModelState.AddModelError("", "Invalid");
            return View();
        }

        public ActionResult Details()
        {
            var r = db.UserRegMsts.Single(i => i.userID.Equals(Session["user"]) && i.password.Equals(Session["user1"]));
            return View(r);
        }
    }
}