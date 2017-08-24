using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ReferenceTask.Models;

namespace ReferenceTask.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //   return View("Home"); om te forceren naar home
            return View();
        }


        //public ActionResult List(Joke)
        public ActionResult List()

        {

            //api aanspreken


            //var model = new Joke();
            //model.Rating

            //   return View("Home"); om te forceren naar home
            return View();
        }










    }
}