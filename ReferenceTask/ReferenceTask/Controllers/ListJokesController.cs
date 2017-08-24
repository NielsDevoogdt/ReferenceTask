using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReferenceTask.Controllers
{
    public class ListJokesController : Controller
    {
        // GET: ListJokes
        public ActionResult ShowResult()
        {
            return View();
        }
    }
}