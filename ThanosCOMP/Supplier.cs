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
    
    public partial class Supplier
    {
        public Supplier()
        {
            this.Products = new HashSet<Product>();
        }
    
        public int SupplierID { get; set; }
        public string SupplierName { get; set; }
        public string SupplierAddress { get; set; }
        public string SupplierTelephone { get; set; }
        public decimal SupplierRating { get; set; }
        public string SupplierEmail { get; set; }
        public string SupplierHomePage { get; set; }
    
        public virtual ICollection<Product> Products { get; set; }
    }
}