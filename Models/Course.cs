using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentPortal.Models
{
    public class Course
    {
        public Course()
        {
            Users = new List<CourseUsers>();
        }

        public ICollection<CourseUsers> Users { get; set; }
        public string CourseName { get; set; }
        public int Id { get; set; }
        public int CourseUnits { get; set; }
        public string CourseCode { get; set; }
        public int Lecturer { get; set; }
        public bool IsSelected { get; set; }
    }
}