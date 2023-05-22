using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StudentPortal.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using StudentPortal.Models;

namespace StudentPortal
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            services.AddScoped<UserManager<User>>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();


            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
                routes.MapRoute(
                    name: "Register",
                    template: "Accounts/Register",
                    defaults: new { controller = "Accounts", action = "Register" }
                );
                routes.MapRoute(
                    name: "Login",
                    template: "Accounts/Login",
                    defaults: new { controller = "Accounts", action = "Login" }
                );
                routes.MapRoute(
                   name: "Logout",
                   template: "Accounts/Logout",
                   defaults: new { controller = "Accounts", action = "Logout" }
               );
                routes.MapRoute(
                    name: "LandingPageStudent",
                    template: "Student/LandingPageStudent",
                    defaults: new { controller = "Student", action = "LandingPageStudent" }
                );
                routes.MapRoute(
                    name: "RegisterCourses",
                    template: "Student/RegisterCourses",
                    defaults: new { controller = "Student", action = "RegisterCourses" }
                );
                routes.MapRoute(
                    name: "DownloadReportSheet",
                    template: "Student/DownloadReportSheet",
                    defaults: new { controller = "Student", action = "DownloadReportSheet" }
                );
                routes.MapRoute(
                    name: "LandingPageLecturer",
                    template: "Lecturer/LandingPageLecturer",
                    defaults: new { controller = "Lecturer", action = "LandingPageLecturer" }
                );
                routes.MapRoute(
                    name: "RegisterCourses",
                    template: "Lecturer/RegisterCourses",
                    defaults: new { controller = "Lecturer", action = "RegisterCourses" }
                );
                routes.MapRoute(
                    name: "GradeCourses",
                    template: "Lecturer/GradeCourses",
                    defaults: new { controller = "Lecturer", action = "GradeCourses" }
                );
                routes.MapRoute(
                    name: "GradeIndividualCourse",
                    template: "Lecturer/GradeIndividualCourse",
                    defaults: new { controller = "Lecturer", action = "GradeIndividualCourse" }
                );
            });
        }
    }
}
