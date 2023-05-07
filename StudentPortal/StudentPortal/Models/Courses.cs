using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentPortal.Models
{
    public class Courses
    {
        public Dictionary<string, List<string>> CourseList = new Dictionary<string, List<string>>();
        public string CourseName { get; set; }
        public string CourseUnits { get; set; }
        public string CourseCode { get; set; }
    }
}