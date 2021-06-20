using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using experian.Areas.Identity.Data;
using experian.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace experian.Controllers
{
    [Authorize(Roles = "SuperAdmin")]
    public class AdminController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
    
        public IActionResult CreateUser(IFormCollection form, IServiceProvider services = ) 
        {

            var UserManager = services.GetRequiredService<UserManager<appUser>>();
            string username = form["txtEmail"];
            string email = form["txtEmail"];
            string passw = form["txtPassword"];

            var newUser = new appUser();
            newUser.UserName = username;
            newUser.Email = email;
            newUser.EmailConfirmed = true;

            var admin = UserManager.CreateAsync(newUser, passw);
            return View();
        }

    }
}
