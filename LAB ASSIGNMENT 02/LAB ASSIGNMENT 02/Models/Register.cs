using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using LAB_ASSIGNMENT_02.Controllers;

namespace LAB_ASSIGNMENT_02.Models
{
    public class Register
    {
        [Required]
        [StringLength(50, MinimumLength=3, ErrorMessage ="Name should be between 3 to 50 characters only.")]
        [RegularExpression(@"[a-zA-z0-9]+[@][aiub][\.][edu]")]
        public string Name { get; set; }
        public string ID { get; set; } 
        public string Password { get; set; }
        public string Gender { get; set; }
        public string Confirm { get; set; }
        public string DOB { get; set; }
    }
}