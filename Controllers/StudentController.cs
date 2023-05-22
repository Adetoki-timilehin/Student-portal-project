using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using StudentPortal.Data;
using StudentPortal.Models;
using System.Net.Mail;
using System.Net;
using PdfSharp.Pdf;
using PdfSharp.Drawing;


namespace StudentPortal.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StudentController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: LandingPageStudent
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult LandingPageStudent()
        {
            return View();
        }



        [HttpGet]
        public ActionResult RegisterCourses()
        {
            var courses = _context.Courses.ToList();
            return View(courses);
        }

        [HttpPost]
        public async Task<ActionResult> RegisterCourses(List<int> selectedCourses)
        {
            var user = StudentPortal.Models.User.CurrentlyLoggedIn;

            foreach (var courseId in selectedCourses)
            {
                var course = _context.Courses.FirstOrDefault(c => c.Id == courseId);

                if (course != null)
                {
                    var courseUser = new CourseUsers
                    {
                        UserId = user.Id,
                        CourseId = course.Id,
                    };

                    _context.CourseUsers.Add(courseUser);
                    var result = await _context.SaveChangesAsync();

                    if (result <= 0)
                    {
                        ModelState.AddModelError("", "An error occurred while registering the course.");
                        return View();
                    }
                }
            }

            return View("~/Views/Student/RegistrationSuccess.cshtml");
        }

        [HttpGet]
        public ActionResult DownloadReportSheet()
        {
            var fileResult = DownloadReports();
            return fileResult;
        }

        public FileResult DownloadReports()
        {
            var currentUser = Models.User.CurrentlyLoggedIn;

            // Retrieve the courses associated with the current user
            var userCourses = _context.CourseUsers
                .Where(cu => cu.UserId == currentUser.Id)
                .Select(cu => cu.Course)
                .ToList();

            var courseUsers = _context.CourseUsers
              .Where(cu => cu.UserId == currentUser.Id)
              .ToList();

            // Calculate the GPA
            decimal gpa = CalculateGPA(userCourses);

            // Generate the report sheet PDF
            byte[] reportSheetData = GenerateReportSheetPDF($"{currentUser.FirstName} {currentUser.LastName} ", currentUser.MatricNo, courseUsers, gpa);

            // Return the report sheet PDF as a file download
            return File(reportSheetData, "application/pdf", "ReportSheet.pdf");
        }

        // Method to generate the report sheet PDF
        private byte[] GenerateReportSheetPDF(string studentName, int matricNumber, IEnumerable<dynamic> courses, decimal gpa)
        {
            // Create a new PDF document
            PdfDocument document = new PdfDocument();
            PdfPage page = document.AddPage();

            XGraphics gfx = XGraphics.FromPdfPage(page);

            // Set font and other styles
            XFont font = new XFont("Arial", 12, XFontStyle.Regular);
            XStringFormat format = XStringFormats.TopLeft;

            // Set the content for the PDF
            gfx.DrawString("                                                                         REPORT SHEET", font, XBrushes.Black, new XRect(10, 10, page.Width, page.Height), format);
            gfx.DrawString($"Student: {studentName}", font, XBrushes.Black, new XRect(10, 30, page.Width, page.Height), format);
            gfx.DrawString($"Matric Number: {matricNumber}", font, XBrushes.Black, new XRect(10, 50, page.Width, page.Height), format);
            gfx.DrawString($"Course Count: {courses.Count()}", font, XBrushes.Black, new XRect(10, 70, page.Width, page.Height), format);

            int yPos = 90;
            foreach (var course in courses)
            {
                gfx.DrawString($"{course.Course.CourseName}: {course.Grade}", font, XBrushes.Black, new XRect(10, yPos, page.Width, page.Height), format);
                yPos += 20;
            }

            gfx.DrawString($"GPA: {gpa}", font, XBrushes.Black, new XRect(10, yPos, page.Width, page.Height), format);

            // Save the PDF document to a memory stream
            using (MemoryStream memoryStream = new MemoryStream())
            {
                document.Save(memoryStream);
                return memoryStream.ToArray();
            }
        }

        private decimal CalculateGPA(IEnumerable<Course> courses)
        {
            decimal totalCreditUnits = 0;
            decimal totalPoints = 0;
            var currentUser = Models.User.CurrentlyLoggedIn;
            foreach (var course in courses)
            {
                var creditUnits = course.CourseUnits;

                var courseUser = _context.CourseUsers.FirstOrDefault(cu =>
                    cu.CourseId == course.Id && cu.UserId == currentUser.Id);


                if (creditUnits != null)
                {
                    totalCreditUnits += creditUnits;

                    switch (courseUser.Grade.ToUpper())
                    {
                        case "A":
                            totalPoints += creditUnits * 5;
                            break;
                        case "B":
                            totalPoints += creditUnits * 4;
                            break;
                        case "C":
                            totalPoints += creditUnits * 3;
                            break;
                        case "D":
                            totalPoints += creditUnits * 2;
                            break;
                        case "E":
                            totalPoints += creditUnits * 1;
                            break;
                        case "F":
                            totalPoints += creditUnits * 0;
                            break;
                    }
                }
            }

            return totalPoints / totalCreditUnits;
        }

    }
}

