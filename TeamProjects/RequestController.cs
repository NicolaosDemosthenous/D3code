using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeamProjects.Models;

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
    
            IList<Request> oRequestID = null;
            using (team07Entities oteam07ViewRequest = new team07Entities())
            {
                oRequestID = (from Request in oteam07ViewRequest.Requests orderby Request.requestID select Request).ToList(); //putting the table User into variable called oUser ---- query called linq 
            }
            return View(oRequestID);
      
        }

    }
}
