//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplicationFPTGroup14.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Info
    {
        public string Name { get; set; }
        public Nullable<bool> Sex { get; set; }
        public Nullable<System.DateTime> Birthday { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string AccountID { get; set; }
        public Nullable<int> CityID { get; set; }
        public Nullable<int> TownshipID { get; set; }
    
        public virtual Account Account { get; set; }
        public virtual City City { get; set; }
        public virtual Township Township { get; set; }
    }
}
