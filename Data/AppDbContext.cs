using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WorkshopAspNetCoreMvc.Models;

namespace WorkshopAspNetCoreMvc.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext (DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<WorkshopAspNetCoreMvc.Models.Department> Department { get; set; } = default!;
    }
}
