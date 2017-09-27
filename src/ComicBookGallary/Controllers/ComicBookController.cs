using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallary.Controllers
{
    public class ComicBookController:Controller
    {
        public string Index()
        {
            return "This is Index from the Controller";
        }
        public ActionResult  Detail()
        {
            if(DateTime.Today.DayOfWeek == DayOfWeek.Wednesday)
            {
                return Redirect("/ComicBook/Index");
            }

            return Content ("Welcome to MVC - This is a controller message.");
           
           
        }


    }
}