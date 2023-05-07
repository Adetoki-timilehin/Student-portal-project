using Microsoft.Web.Mvc.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Security;
using System.Web;

namespace StudentPortal.Models
{
    public class User
    {
        private string email;
        public bool IsStudent;

        [Required]
        [EmailAddress]
        public string Email {
            get { return email; }
            set {
                if (!IsValidEmail(value))
                {
                    throw new ArgumentException("Invaild Email");
                }
                else
                {
                    email = value;
                }
            } }


        public int MatricNo { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public SecureString Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public bool IsValidEmail(string email)
        {
            try
            {
                var mailAddress = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}