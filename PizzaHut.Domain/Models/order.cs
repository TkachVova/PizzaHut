//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PizzaHut.Domain.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class order
    {
        public order()
        {
            this.cartItem = new HashSet<cartItem>();
        }
    
        public int id { get; set; }
        public bool processing { get; set; }
        public int customerId { get; set; }
        public decimal fullprice { get; set; }
        public string deliveryAddress { get; set; }
        public System.DateTime orderTime { get; set; }
    
        public virtual ICollection<cartItem> cartItem { get; set; }
        public virtual customer customer { get; set; }
    }
}
