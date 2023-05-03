using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentPortal.Models
{
    public class StudentsModel
    {
        [Required]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LasttName { get; set; }

        [Required]
        [Display(Name = "Matric No")]
        public int MatricNo { get; set; }

        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public  string Password { get; set; }

        public double GPA { get; set; }

        public ICollection<CourseStudent> CourseStudents { get; set; }

        public StudentsModel()
        {
                
        }
    }
}
