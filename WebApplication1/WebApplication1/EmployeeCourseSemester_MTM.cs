//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1
{
    using System;
    using System.Collections.Generic;
    
    public partial class EmployeeCourseSemester_MTM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EmployeeCourseSemester_MTM()
        {
            this.Timeslots = new HashSet<Timeslot>();
        }
    
        public int ID { get; set; }
        public int EmployeeID { get; set; }
        public int CourseSemesterID { get; set; }
    
        public virtual CourseSemester_MTM CourseSemester_MTM { get; set; }
        public virtual Employee Employee { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Timeslot> Timeslots { get; set; }
    }
}