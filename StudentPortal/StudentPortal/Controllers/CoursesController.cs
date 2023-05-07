using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudentPortal.Models;

namespace StudentPortal.Controllers
{
    public class CoursesController : Controller
    {
        // GET: Courses
        public ActionResult Index()
        {
            return View();
        }

        public void RegisterCourses(Courses model)
        {
            var CourseDetails = new List<string> { model.CourseCode, model.CourseUnits };
            model.CourseList.Add(model.CourseName, CourseDetails);
        }
    }
}