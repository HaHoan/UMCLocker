//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UMCLocker
{
    using System;
    using System.Collections.Generic;
    
    public partial class Staff
    {
        public int id { get; set; }
        public string full_name { get; set; }
        public string gender { get; set; }
        public Nullable<System.DateTime> enter_date { get; set; }
        public Nullable<int> department { get; set; }
        public Nullable<int> position { get; set; }
        public Nullable<int> locker_id { get; set; }
        public Nullable<int> shoes_id { get; set; }
        public string staff_code { get; set; }
        public string state { get; set; }
        public Nullable<System.DateTime> end_date { get; set; }
        public string note { get; set; }
        public string reason_change_key { get; set; }
        public string customer { get; set; }
        public Nullable<System.DateTime> modify_date { get; set; }
        public Nullable<System.DateTime> date_change_key { get; set; }
    
        public virtual Dept Dept { get; set; }
        public virtual Locker Locker { get; set; }
        public virtual Pos Pos { get; set; }
        public virtual Sho Sho { get; set; }
    }
}
