using Microsoft.EntityFrameworkCore;
using MultiStepFormApp.Models;
using System.Collections.Generic;

namespace MultiStepFormApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<FormEntry> FormEntries { get; set; }
    }
}
