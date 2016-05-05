//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WMS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public User()
        {
            this.AttProcessorSchedulers = new HashSet<AttProcessorScheduler>();
        }
    
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public string Name { get; set; }
        public Nullable<bool> Status { get; set; }
        public string UserType { get; set; }
        public Nullable<bool> CanEdit { get; set; }
        public Nullable<bool> CanDelete { get; set; }
        public Nullable<bool> CanView { get; set; }
        public Nullable<bool> CanAdd { get; set; }
        public Nullable<bool> MHR { get; set; }
        public Nullable<bool> MDevice { get; set; }
        public Nullable<bool> MLeave { get; set; }
        public Nullable<bool> MDesktop { get; set; }
        public Nullable<bool> MEditAtt { get; set; }
        public Nullable<bool> MUser { get; set; }
        public Nullable<bool> MOption { get; set; }
        public Nullable<bool> MRDailyAtt { get; set; }
        public Nullable<bool> MRLeave { get; set; }
        public Nullable<bool> MRMonthly { get; set; }
        public Nullable<bool> MRAudit { get; set; }
        public Nullable<bool> MRManualEditAtt { get; set; }
        public Nullable<bool> MREmployee { get; set; }
        public Nullable<bool> MRDetail { get; set; }
        public Nullable<bool> MRoster { get; set; }
        public Nullable<bool> MProcess { get; set; }
        public Nullable<bool> Deleted { get; set; }
    
        public virtual ICollection<AttProcessorScheduler> AttProcessorSchedulers { get; set; }
    }
}
