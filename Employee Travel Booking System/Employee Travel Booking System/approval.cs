//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Employee_Travel_Booking_System
{
    using System;
    using System.Collections.Generic;
    
    public partial class approval
    {
        public int approvalid { get; set; }
        public Nullable<int> requestid { get; set; }
        public Nullable<int> managerid { get; set; }
        public string approvalstatus { get; set; }
    
        public virtual manager manager { get; set; }
        public virtual travelrequest travelrequest { get; set; }
    }
}