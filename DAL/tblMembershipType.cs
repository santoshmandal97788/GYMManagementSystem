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
    
    public partial class tblMembershipType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblMembershipType()
        {
            this.tblCustomerMemberships = new HashSet<tblCustomerMembership>();
        }
    
        public int MT_ID { get; set; }
        public string MembershipType { get; set; }
        public decimal ChargesPerMonth { get; set; }
        public decimal ServiceTAX { get; set; }
        public decimal VAT { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCustomerMembership> tblCustomerMemberships { get; set; }
    }
}
