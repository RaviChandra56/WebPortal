//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassLibrary1
{
    using System;
    using System.Collections.Generic;
    
    public partial class SYSUser
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SYSUser()
        {
            this.SYSUserProfiles = new HashSet<SYSUserProfile>();
            this.SYSUserProfiles1 = new HashSet<SYSUserProfile>();
            this.SYSUserProfiles2 = new HashSet<SYSUserProfile>();
            this.SYSUserRoles = new HashSet<SYSUserRole>();
        }
    
        public int SYSUserID { get; set; }
        public string LoginName { get; set; }
        public string PasswordEncryptedText { get; set; }
        public int CreatedUserID { get; set; }
        public Nullable<System.DateTime> CreatedDateTime { get; set; }
        public int ModifiedUserID { get; set; }
        public Nullable<System.DateTime> ModifiedDateTime { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SYSUserProfile> SYSUserProfiles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SYSUserProfile> SYSUserProfiles1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SYSUserProfile> SYSUserProfiles2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SYSUserRole> SYSUserRoles { get; set; }
    }
}
