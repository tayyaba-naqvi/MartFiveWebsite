//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MartFive.API.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderList
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrderList()
        {
            this.Orders = new HashSet<Order>();
        }
    
        public int OL_Id { get; set; }
        public Nullable<int> OL_Price { get; set; }
        public Nullable<bool> OL_Status { get; set; }
        public string OL_Date { get; set; }
        public int Address_Id { get; set; }
        public Nullable<int> User_Id { get; set; }
    
        public virtual Address Address { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
        public virtual User User { get; set; }
    }
}
