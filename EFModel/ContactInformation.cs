//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EFModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class ContactInformation
    {
        public int Id { get; set; }
        public int InstructorId { get; set; }
        public string ContactInfo { get; set; }
        public bool Preferred { get; set; }
        public bool Active { get; set; }
    
        public virtual Instructor Instructor { get; set; }
    }
}
