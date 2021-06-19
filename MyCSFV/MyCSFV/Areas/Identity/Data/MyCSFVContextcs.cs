using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyCSFV.Areas.Identity.Data;

namespace MyCSFV.Data
{
    public class MyCSFVContext : IdentityDbContext<MyCSFVUser>
    {
        public MyCSFVContext(DbContextOptions<MyCSFVContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

        }
    }
}
