//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblCustomer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblCustomer()
        {
            this.tblCustomerMemberships = new HashSet<tblCustomerMembership>();
        }
    
        public int C_ID { get; set; }
        public string CustomerNo { get; set; }
        public string C_Name { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public string ContactNo { get; set; }
        public byte[] Photo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCustomerMembership> tblCustomerMemberships { get; set; }
    }
}