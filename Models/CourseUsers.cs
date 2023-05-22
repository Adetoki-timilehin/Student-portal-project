using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentPortal.Models
{
    public class CourseUsers
    {
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public string Grade { get; set; }
    }
}
