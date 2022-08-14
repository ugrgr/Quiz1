using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore
{
    internal class ManyToMany
    {
        public class Student
        {
            public int Id { get; set; }

            public string ?Name { get; set; }

            public IList<TeacherStudent> ?TeacherStudent { get; set; } //collection navigation property
        }

        public class Teacher
        {
            public int Id { get; set; }

            public string ?Name { get; set; }

            public IList<TeacherStudent> ?TeacherStudent { get; set; } //collection navigation property
        }
        public class TeacherStudent
        {
            public Student ?Student { get; set; }
            public Teacher ?Teacher { get; set; }
        }
        public class CompanyContext : DbContext
        {
            public DbSet<Teacher> ?Teacher { get; set; }
            public DbSet<Student> ?Student { get; set; }
            public DbSet<TeacherStudent> ?TeacherStudent { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                if (!optionsBuilder.IsConfigured)
                {
                    optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-JIFTFVO\UGURGUR;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                }
            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<TeacherStudent>().HasKey(t => new { t.Student, t.Teacher });

                modelBuilder.Entity<TeacherStudent>()
                            .HasOne(t => t.Student)
                            .WithMany(t => t.TeacherStudent)
                            .HasForeignKey(t => t.Student);


                modelBuilder.Entity<TeacherStudent>()
                            .HasOne(t => t.Teacher)
                            .WithMany(t => t.TeacherStudent)
                            .HasForeignKey(t => t.Teacher);
            }
        }
    }
}
