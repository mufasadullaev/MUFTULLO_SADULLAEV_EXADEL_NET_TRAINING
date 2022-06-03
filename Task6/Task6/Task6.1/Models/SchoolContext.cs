using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Task6._1.Models
{
    public class SchoolContext : DbContext
    {

        public DbSet<Student> Students { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClassSubject>()
                .HasKey(t => new { t.ClassId, t.SubjectId });

            modelBuilder.Entity<ClassSubject>()
                .HasOne(pt => pt.Class)
                .WithMany(p => p.ClassSubjects)
                .HasForeignKey(pt => pt.ClassId);

            modelBuilder.Entity<ClassSubject>()
                .HasOne(pt => pt.Subject)
                .WithMany(t => t.ClassSubjects)
                .HasForeignKey(pt => pt.SubjectId);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DBSchool;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}
