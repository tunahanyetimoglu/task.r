//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace yonetimApplication
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Project
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Project()
        {
            this.tbl_TaskforPersonel = new HashSet<tbl_TaskforPersonel>();
            this.tbl_TaskforProjectManager = new HashSet<tbl_TaskforProjectManager>();
            this.tbl_Personel = new HashSet<tbl_Personel>();
        }
    
        public int projectId { get; set; }
        public int projectProjectManagerId { get; set; }
        public string projectName { get; set; }
        public string projectDescription { get; set; }
        public string projectStatus { get; set; }
        public System.DateTime projectStartDate { get; set; }
        public System.DateTime projectDeadLine { get; set; }
        public System.DateTime projectLastUpdated { get; set; }
    
        public virtual tbl_ProjectManager tbl_ProjectManager { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_TaskforPersonel> tbl_TaskforPersonel { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_TaskforProjectManager> tbl_TaskforProjectManager { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Personel> tbl_Personel { get; set; }
    }
}
