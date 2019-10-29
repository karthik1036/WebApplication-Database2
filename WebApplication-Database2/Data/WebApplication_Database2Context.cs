using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApplication_Database2.Models
{
    public class WebApplication_Database2Context : DbContext
    {
        public WebApplication_Database2Context (DbContextOptions<WebApplication_Database2Context> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<WebApplication_Database2.Models.Employee> Employee { get; set; }
    }
}
