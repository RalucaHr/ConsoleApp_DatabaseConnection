//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PrivateSchoolProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class Assignment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Assignment()
        {
            this.Students = new HashSet<Student>();
        }
    
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public System.DateTime sub_date { get; set; }
        public Nullable<double> oralMark { get; set; }
        public Nullable<double> totalMark { get; set; }
        public int courseid { get; set; }
    
        public virtual Course Courses { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student> Students { get; set; }
    }
}