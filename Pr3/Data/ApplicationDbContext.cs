﻿using Pr3.Models;
using Microsoft.EntityFrameworkCore;

namespace Pr3.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Villa> Villa { get; set; }
    }
}