//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ThanosCOMP
{
    using System;
    using System.Collections.Generic;
    
    public partial class Account
    {
        public Account()
        {
            this.Users = new HashSet<User>();
        }
    
        public int AccountID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ExpireDate { get; set; }
    
        public virtual ICollection<User> Users { get; set; }
    }
}
