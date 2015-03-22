using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TeamProjects.Controllers
{
    public class RequestController : Controller
    {
        //
        // GET: /Request/

        public ActionResult MakeRequest()
        {
            return View();
        }

        public ActionResult ViewRequest()
        {
            return View();
        }

    }
}
