using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudentPortal.Models;

namespace StudentPortal.Controllers
{
    public class AccountsController : Controller
    {
        // GET: Accounts
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Register(User model)
        {
            if (ModelState.IsValid)
            {

                if (model.IsStudent)
                {
                    // Perform student registration logic
                    // Show student registration success page
                    return View("LandingPageStudent");
                }
                else
                {
                    // Perform non-student registration logic
                    // Show non-student registration success page
                    return View("LandingPageLecturer");
                }
            }

            return View(model);
        }
    }
}