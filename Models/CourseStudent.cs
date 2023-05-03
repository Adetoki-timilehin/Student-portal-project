using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentPortal.Models
{
    public class CourseStudent
    {
        public int CourseId { get; set; }
        public CourseModel Course { get; set; }

        public int StudentId { get; set; }
        public StudentsModel Student { get; set; }
    }
}
