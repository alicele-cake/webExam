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
        public ActionResult Music(string name,int num)
        {
            string r = "";
            
    
                if (num==1)
                {
                    r = "do";
                }
                if (num == 2)
                {
                    r = "re";
                }
                if (num == 3)
                {
                    r = "mi";
                }
                if (num == 4)
                {
                    r = "fa";
                }
                if (num == 5)
                {
                    r = "so";
                }
                if (num == 6)
                {
                    r = "la";
                }
                if (num == 7)
                {
                    r = "xi";
                }

            if(num < 0 || num > 8)
            {
                r = "錯誤";
            }
            ViewBag.Name = name;
            ViewBag.Num = r;

            return View();
        }
    }
}