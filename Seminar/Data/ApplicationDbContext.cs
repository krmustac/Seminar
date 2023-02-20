using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Seminar.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Seminar.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Plant> Plants { get; set; }
        public DbSet<Decoration> Decorations { get; set; }  
        public DbSet<FlowerArrangement> FlowerArrangements { get; set; }
    }
}
