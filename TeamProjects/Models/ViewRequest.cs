using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeamProjects.Models
{
    public class ViewRequest
    {
        public int requestID { get; set; }
        public string status { get; set; }
        public string day { get; set; }
        public int periodStart { get; set; }
        public int periodEnd { get; set; }
        public int semester { get; set; }
        public int year { get; set; }
        public int round { get; set; }

    }
}