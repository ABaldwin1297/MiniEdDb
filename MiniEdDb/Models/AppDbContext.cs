using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MiniEdDb.Models {
    public class AppDbContext : DbContext {

        // Table collection items go here
        public virtual DbSet<Major> Majors { get; set; } = null!;
        public virtual DbSet<Student> Students { get; set; } = null!;
        public virtual DbSet<Instructor> Instructors { get; set; } = null!;
        public virtual DbSet<Class> Classes { get; set; } = null!;
        public virtual DbSet<ClassGrade> ClassGrades { get; set; } = null!;
        public AppDbContext() { }    // default constructor won't be in our final project b/c it's a Web app and the default constructor only applies to console apps
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder builder) {
            var connStr = @"server=localhost\sqlexpress;"
                        + "database=MiniEdDb;"
                        + "trustServerCertificate=true;"
                        + "trusted_connection=true;";
            builder.UseSqlServer(connStr);
        }
    }
}

