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
    
    public partial class Emp
    {
        public Emp()
        {
            this.AttDatas = new HashSet<AttData>();
            this.LvApplications = new HashSet<LvApplication>();
            this.LvConsumeds = new HashSet<LvConsumed>();
            this.LvShorts = new HashSet<LvShort>();
        }
    
        public int EmpID { get; set; }
        public string EmpNo { get; set; }
        public string EmpName { get; set; }
        public Nullable<int> DesigID { get; set; }
        public Nullable<short> JobID { get; set; }
        public Nullable<byte> Gender { get; set; }
        public Nullable<byte> ShiftID { get; set; }
        public Nullable<short> LocID { get; set; }
        public Nullable<byte> TypeID { get; set; }
        public Nullable<short> GradeID { get; set; }
        public Nullable<short> SecID { get; set; }
        public string CardNo { get; set; }
        public Nullable<int> FpID { get; set; }
        public string PinCode { get; set; }
        public string NicNo { get; set; }
        public string FatherName { get; set; }
        public string BloodGroup { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public string MarStatus { get; set; }
        public Nullable<System.DateTime> JoinDate { get; set; }
        public Nullable<System.DateTime> ValidDate { get; set; }
        public Nullable<System.DateTime> IssueDate { get; set; }
        public Nullable<System.DateTime> ResignDate { get; set; }
        public string HomeAdd { get; set; }
        public bool ProcessAtt { get; set; }
        public Nullable<bool> Status { get; set; }
        public string PhoneNo { get; set; }
        public string Remarks { get; set; }
        public string Email { get; set; }
        public string CellNo { get; set; }
        public Nullable<short> CrewID { get; set; }
        public Nullable<bool> FlagFP { get; set; }
        public Nullable<bool> FlagFace { get; set; }
        public Nullable<bool> FlagCard { get; set; }
        public Nullable<int> EmpImageID { get; set; }
        public Nullable<bool> HasOT { get; set; }
        public Nullable<bool> HasAccess { get; set; }
    
        public virtual ICollection<AttData> AttDatas { get; set; }
        public virtual Crew Crew { get; set; }
        public virtual Designation Designation { get; set; }
        public virtual EmpType EmpType { get; set; }
        public virtual Grade Grade { get; set; }
        public virtual JobTitle JobTitle { get; set; }
        public virtual Location Location { get; set; }
        public virtual Section Section { get; set; }
        public virtual Shift Shift { get; set; }
        public virtual ICollection<LvApplication> LvApplications { get; set; }
        public virtual ICollection<LvConsumed> LvConsumeds { get; set; }
        public virtual ICollection<LvShort> LvShorts { get; set; }
    }
}
