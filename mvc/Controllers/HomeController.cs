using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvc.Models;
namespace mvc.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult index()
        {
            return View();
        }

        public ActionResult login()
        {
            return View();
        }
        public ActionResult rohit()
        {
          //  var data = getemplyoeedetails();
            return View();
        }
        /*
        private model1 getemplyoeedetails()
        {
            return new model1()
            {
                id = 1,
                name = "rohit",
                address = "qureshi mohola",
            }; 
               
        }
        */
        
        
        
    }
}