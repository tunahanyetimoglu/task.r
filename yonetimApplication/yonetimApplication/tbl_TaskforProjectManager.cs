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
    
    public partial class tbl_TaskforProjectManager
    {
        public int taskId { get; set; }
        public int taskProjectId { get; set; }
        public int taskProjectManagerId { get; set; }
        public string taskName { get; set; }
        public string taskDescription { get; set; }
        public string taskStatus { get; set; }
        public System.DateTime taskDeadLine { get; set; }
        public System.DateTime taskLastUpdated { get; set; }
    
        public virtual tbl_Project tbl_Project { get; set; }
        public virtual tbl_ProjectManager tbl_ProjectManager { get; set; }
    }
}