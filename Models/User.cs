using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Security;
using System.Text.RegularExpressions;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace StudentPortal.Models
{
    public class User : IdentityUser
    {
        public User()
        {
            Courses = new List<CourseUsers>();
        }

        public ICollection<CourseUsers> Courses { get; set; }
        public int UserId { get; set; }

        private string email;

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public bool IsStudent { get; set; }

        public static User CurrentlyLoggedIn { get; set; }

        [Required]
        [EmailAddress]
        public string UserEmail
        {
            get 
            {
                return email; 
            }
            set
            {
                    email = value;
            }
        }


        public int MatricNo { get; set; }


        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}