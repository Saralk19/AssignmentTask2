//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EducationForAll.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Review
    {
        public int ReviewId { get; set; }
        public string ReviewComment { get; set; }
        public int ReviewStar { get; set; }
        public System.DateTime ReviewDate { get; set; }
        public int StudentStudentId { get; set; }
        public int CourseId { get; set; }
    
        public virtual Cours Cours { get; set; }
        public virtual Student Student { get; set; }
    }
}
