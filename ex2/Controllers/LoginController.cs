using ex2.Models;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ex2.Controllers
{
    public class LoginController : Controller
    {

        creditEntities credit = new creditEntities();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(UserAccount log)
        {
            var user = credit.UserAccounts.Where(x => x.Username == log.Username && x.Password == log.Password).Count();
            if( user > 0)
            {
                return RedirectToAction("Dashboard");
            }
            else
            {
                return View();
            }
        }

        public ActionResult Dashboard()
        {
            return View();
        }
    }
}