//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FluffNStuff.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class usertable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public usertable()
        {
            this.ordertables = new HashSet<ordertable>();
            this.sub_category = new HashSet<sub_category>();
        }
    
        public int u_id { get; set; }
        public string u_name { get; set; }
        public string u_password { get; set; }
        public string u_image { get; set; }
        public string u_contact { get; set; }
        public string u_email { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ordertable> ordertables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sub_category> sub_category { get; set; }
    }
}