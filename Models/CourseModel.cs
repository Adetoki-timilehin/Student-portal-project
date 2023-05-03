using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentPortal.Models
{
    public class CourseModel
    {
        public int Id { get; set; }
        public int CourseUnits { get; set; }
        public string CourseTitle { get; set; }
        public ICollection<CourseStudent> CourseStudents { get; set; }

        public CourseModel()
        {
                
        }
    }
}
