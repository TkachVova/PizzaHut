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
    
    public partial class pizzas
    {
        public pizzas()
        {
            this.cartItem = new HashSet<cartItem>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public string ingridients { get; set; }
        public decimal price { get; set; }
    
        public virtual ICollection<cartItem> cartItem { get; set; }
    }
}
