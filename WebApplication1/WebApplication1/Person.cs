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
    using System.ComponentModel.DataAnnotations;

    public partial class Person
    {
        public int ID { get; set; }
        [Required]
        [RegularExpression("^[0-9]{13}$", ErrorMessage ="Enter Valid CNIC")]
        public string CNIC { get; set; }
        [Required]
        [RegularExpression("[a-zA-Z]*$", ErrorMessage ="Enter Valid Name")]
        public string Name { get; set; }
        [Required]
        [RegularExpression("[a-zA-Z]*$", ErrorMessage = "Enter Valid Name")]
        public string FatherName { get; set; }
        public string Address { get; set; }

        [Required]
        [RegularExpression("^[0-9]{11}$", ErrorMessage = "Enter Valid Conact")]
        public string Contact { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual Student Student { get; set; }
    }
}
