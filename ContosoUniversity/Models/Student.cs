using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        //
        [Display(Name = "Last Name")]
        [StringLength(120, MinimumLength = 3)]
        [Required]
        public string LastName { get; set; }
        //

        [Display(Name = "First Name")]
        [StringLength(120, MinimumLength = 3)]
        [Required]
        public string FirstMidName { get; set; }
        //
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }
        //
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}