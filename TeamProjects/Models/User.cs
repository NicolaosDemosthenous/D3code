//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TeamProjects.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public User()
        {
            this.Modules = new HashSet<Module>();
            this.Preferences = new HashSet<Preference>();
        }
    
        public int userID { get; set; }
        public string password { get; set; }
        public string deptName { get; set; }
        public string deptCode { get; set; }
    
        public virtual ICollection<Module> Modules { get; set; }
        public virtual ICollection<Preference> Preferences { get; set; }
    }
}
