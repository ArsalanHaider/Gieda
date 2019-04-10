//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GDA
{
    using System;
    using System.Collections.Generic;
    
    public partial class allottee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public allottee()
        {
            this.allotee_plots = new HashSet<allotee_plots>();
            this.allottee_documents = new HashSet<allottee_documents>();
            this.allottee_payments = new HashSet<allottee_payments>();
            this.installment_payments = new HashSet<installment_payments>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public string father_name { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string province { get; set; }
        public string domicile { get; set; }
        public string pds_number { get; set; }
        public long nic { get; set; }
        public string af_number { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
        public Nullable<System.DateTime> updated_at { get; set; }
        public string picture { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<allotee_plots> allotee_plots { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<allottee_documents> allottee_documents { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<allottee_payments> allottee_payments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<installment_payments> installment_payments { get; set; }
    }
}
