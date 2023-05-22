using Microsoft.AspNetCore.Mvc;
using StudentPortal.Data;
using StudentPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentPortal.Controllers
{
    public class LecturerController : Controller
    {

        private readonly ApplicationDbContext _context;

        public LecturerController(ApplicationDbContext context)
        {
            _context = context;
        }
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult LandingPageLecturer()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LandingPageLecturer(Course course)
        {
            return View("LandingPageLecturer");
        }

        [HttpGet]
        public ActionResult RegisterCourses()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> RegisterCourses(Course course)
        {
            try
            {
                var user = StudentPortal.Models.User.CurrentlyLoggedIn;
                var newCourse = new Course
                {
                    CourseCode = course.CourseCode, // Set the UserName property instead of UserEmail
                    CourseName = course.CourseName, // Set the Email property directly
                    CourseUnits = course.CourseUnits,
                };

                _context.Courses.Add(newCourse); // Add the new course to the context
                var result = await _context.SaveChangesAsync(); // Save changes to the database

                if (result <= 0)
                {
                    ModelState.AddModelError("", "An error occurred while registering the course.");
                    return View();
                }
                var courseUser = new CourseUsers
                {
                    UserId = user.Id, // Set the user id of the course user to the new user's id
                    CourseId = newCourse.Id // Set the course id to the id of the newly created course
                };

                _context.CourseUsers.Add(courseUser); // Add the new course user to the context
                var result2 = await _context.SaveChangesAsync();
                if (result2 <= 0)
                {
                    ModelState.AddModelError("", "An error occurred while registering the course.");
                    return View();
                }
                ModelState.Clear();
                return View("~/Views/Lecturer/RegisterCourses.cshtml");
            }
            catch (Exception ex)
            {
                // User creation failed, handle the error
                ModelState.AddModelError("", "An error occurred while registering the course: " + ex.Message);
                return View();
            }
        }

        [HttpGet]
        public ActionResult GradeCourses()
        {
            var currentUser = Models.User.CurrentlyLoggedIn;

            // Retrieve the courses associated with the current user
            var userCourses = _context.CourseUsers
                .Where(cu => cu.UserId == currentUser.Id)
                .Select(cu => cu.Course)
                .ToList();
            return View(userCourses);
        }

        [HttpPost]
        public ActionResult GradeCourses(int selectedCourseId)
        {
            return RedirectToAction("GradeIndividualCourse", "Lecturer", new { selectedCourseId });
        }

        [HttpGet]
        public ActionResult GradeIndividualCourse(int selectedCourseId)
        {
            var courseUsers = _context.CourseUsers
                .Where(cu => cu.CourseId == selectedCourseId && cu.User.IsStudent)
                .ToList();

            var userList = new List<User>();

            foreach (var courseUser in courseUsers)
            {
                var user = _context.Users.FirstOrDefault(u => u.Id == courseUser.UserId);
                userList.Add((User)user);
            }

            return View(Tuple.Create(courseUsers, userList));
        }

        [HttpPost]
        public ActionResult GradeIndividualCourse(List<CourseUsers> Grades)
        {
            foreach (var grade in Grades)
            {
                var courseUser = _context.CourseUsers.FirstOrDefault(cu =>
                    cu.CourseId == grade.CourseId && cu.UserId == grade.UserId);

                if (courseUser != null)
                {
                    courseUser.Grade = grade.Grade;
                }
            }

            _context.SaveChanges();

            return View("~/Views/Lecturer/GradingSuccessful.cshtml");
        }
    }
}
