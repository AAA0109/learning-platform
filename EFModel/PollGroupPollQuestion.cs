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
    
    public partial class PollGroupPollQuestion
    {
        public int PollGroupId { get; set; }
        public int PollQuestionId { get; set; }
        public bool Active { get; set; }
    
        public virtual PollGroup PollGroup { get; set; }
        public virtual PollQuestion PollQuestion { get; set; }
    }
}
