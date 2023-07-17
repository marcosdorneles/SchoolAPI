using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EscolaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EscolaAPI.DataBase
{
    public class SchoolDbContext : DbContext
    {
        public virtual DbSet<Student> Students { get; set; }

        public virtual DbSet<Class> Classes { get; set; }

        public virtual DbSet<Boletim> Boletins { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<GradeSubject> GradeSubjects { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ClassStudent>()
                .HasKey(cs => new { cs.StudentId, cs.ClassId });

            builder.Entity<ClassStudent>()
                .HasOne(cs => cs.Student)
                .WithMany(s => s.Classes)
                .HasForeignKey(cs => cs.StudentId);

            builder.Entity<ClassStudent>()
                .HasOne(cs => cs.Class)
                .WithMany(c => c.Students)
                .HasForeignKey(cs => cs.ClassId);
            builder.Entity<Student>()
                .HasMany(b => b.Boletins)
                .WithOne(s => s.Student)
                .HasForeignKey(s => s.StudentId);
            builder.Entity<Boletim>()
                .HasMany(b => b.GradeSubjects)
                .WithOne(s => s.Boletim)
                .HasForeignKey(s => s.BoletimId);
            builder.Entity<GradeSubject>()
                .HasOne(gs => gs.Subject)
                .WithMany(s => s.GradeSubjects)
                .HasForeignKey(gs => gs.SubjectId);


        }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost, 1433;Database=SchoolDb;User Id=SA;Password=Py2238yy,,;TrustServerCertificate=true");
        }
    }
}