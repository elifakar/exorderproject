//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace exorderproject_api.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TREGION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TREGION()
        {
            this.TREGIONS = new HashSet<TREGIONS>();
        }
    
        public int REGION_ID { get; set; }
        public string REGION_NAME { get; set; }
        public string REGION_DESCRIPTION { get; set; }
        public Nullable<int> REGION_C_ID { get; set; }
        public Nullable<int> REGION_CREATED_USER_ID { get; set; }
        public Nullable<int> REGION_EDITED_USER_ID { get; set; }
        public Nullable<System.DateTime> REGION_CREATED_DATE { get; set; }
        public Nullable<System.DateTime> REGION_EDITED_DATE { get; set; }
        public Nullable<int> REGION_STATUS { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TREGIONS> TREGIONS { get; set; }
    }
}
