using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Music()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Music(string name,float num)
        {
            var r = "";
            if (num.HasValue)
            {
                r = "cc";
            }
            ViewBag.Name = name;
            ViewBag.Num = r;
            return View();
        }
    }
}