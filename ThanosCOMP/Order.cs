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
    
    public partial class Order
    {
        public int OrderID { get; set; }
        public int PaymentID { get; set; }
        public int ShoppingCartID { get; set; }
        public Nullable<double> TotalSum { get; set; }
        public Nullable<double> ShippingTaxTotal { get; set; }
        public System.DateTime OrderDate { get; set; }
    
        public virtual Payment Payment { get; set; }
        public virtual ShoppingCart ShoppingCart { get; set; }
    }
}