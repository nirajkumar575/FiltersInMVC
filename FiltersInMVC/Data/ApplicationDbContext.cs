using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FiltersInMVC.Models;

namespace FiltersInMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<FiltersInMVC.Models.User> User { get; set; } = default!;
        public DbSet<Contact> Contacts { get; set; }
    }
}
