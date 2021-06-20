using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using MyCSFV.Areas.Identity.Data;
using MyCSFV.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCSFV.Controllers
{
    [Authorize(Roles = "SuperAdmin")]
    public class AdminController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
    
        public IActionResult CreateUser(FormCollection form, IServiceProvider serviceProvider) 
        {
            var UserManager = serviceProvider.GetRequiredService<UserManager<MyCSFVUser>>();
            string username = form["txtEmail"];
            string email = form["txtEmail"];
            string passw = form["txtPassword"];

            var newUser = new MyCSFVUser();
            newUser.UserName = username;
            newUser.Email = email;
            newUser.EmailConfirmed = true;

            var admin = UserManager.CreateAsync(newUser, passw);
            return View();
        }

    }
}
