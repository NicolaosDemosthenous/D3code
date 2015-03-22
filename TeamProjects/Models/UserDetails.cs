using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TeamProjects.Models
{
    public class UserDetails
    {
        public int userID { get; set; }
        public string deptName { get; set; }
        public string deptCode { get; set; }
        public string password { get; set; }
    }
}
