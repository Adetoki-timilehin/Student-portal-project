using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudentPortal.Data;
using StudentPortal.Models;
using StudentPortal.Data.Migrations;
using Microsoft.AspNetCore.Identity;
using System.Text.RegularExpressions;
using StudentPortal.Models;

namespace StudentPortal.Controllers
{
    public class AccountsController : Controller
    {
        private readonly UserManager<User> _userManager;

        public AccountsController(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Register(User model)
        {
            var newUser = new User
            {
                UserName = model.UserEmail, // Set the UserName property instead of UserEmail // Set the Email property directly
                Email = model.UserEmail,
                FirstName = model.FirstName,
                LastName = model.LastName,
                IsStudent = model.IsStudent,
                MatricNo = model.MatricNo,
                Password = model.Password,
                ConfirmPassword = model.ConfirmPassword

            };

            // Use UserManager to create the user and add them to the database
            var result = await _userManager.CreateAsync(newUser);

            if (result.Succeeded)
            {
                StudentPortal.Models.User.CurrentlyLoggedIn = newUser;
                if (model.IsStudent)
                {
                    return RedirectToAction("LandingPageStudent", "Student");
                }
                else
                {
                    return RedirectToAction("LandingPageLecturer", "Lecturer");
                }
            }
            else
            {
                // User creation failed, handle the error
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(model); // Show the registration form again with error messages
            }
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(string userEmail, string password)
        {
            // Find the user by email
            var user = await _userManager.FindByEmailAsync(userEmail);

            // Check if the user exists and the password is correct
            if (user != null)
            {
                var pw = user.Password;
                var signInResult = pw == password;

                if (signInResult)
                {
                    StudentPortal.Models.User.CurrentlyLoggedIn = user;
                    if (user.IsStudent)
                    {
                        return RedirectToAction("LandingPageStudent", "Student", user);
                    }
                    else
                    {
                        return RedirectToAction("LandingPageLecturer", "Lecturer", user);
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Invalid email or password.");
                    return View();
                }
            }
            else
            {
                // Invalid credentials, display an error message
                ModelState.AddModelError("", "Invalid email or password.");
                return View();
            }
        }

        public ActionResult Logout()
        {
            StudentPortal.Models.User.CurrentlyLoggedIn = null;
            return View("~/Views/Home/Index.cshtml");
        }
    }

}
