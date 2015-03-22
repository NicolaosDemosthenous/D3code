using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeamProjects.Models;


namespace TeamProjects.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Account/

        public ActionResult Login() 
        {
            IList<User> oUser = null;
            using (team07Entities oteam07Entities = new team07Entities())
            {
                oUser = (from User in oteam07Entities.Users orderby User.deptCode select User).ToList(); //putting the table User into variable called oUser ---- query called linq 
            }
            return View(oUser);
        }

        [HttpPost]
        public ActionResult Login(UserDetails model)
        {
            if (ModelState.IsValid)
            {
                using (team07Entities oteam07Entities = new team07Entities())
                {
                    string username = model.deptCode;
                    string password = model.password;

                    bool userValid = oteam07Entities.Users.Any(user => user.deptCode == username && user.password == password);

                    if (userValid)
                    {
                        return RedirectToAction("MakeRequest","Request");
                    }
                    else
                    {
                        return RedirectToAction("Login","Account");
                    }

                }

            }
            return View();
        }
    }
}
