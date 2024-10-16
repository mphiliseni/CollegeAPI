﻿using CollegeAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CollegeAPI.Data
{
    public class StudentDbContext: DbContext
    {
        public DbSet<Student> Students { get; set; }
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {
        }
    }
}
