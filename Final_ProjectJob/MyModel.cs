using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Final_ProjectJob
{
    public partial class MyModel : DbContext
    {
        public MyModel()
            : base("name=MyModel")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Contact> Contact { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Jobs> Jobs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRoles>()
                .HasMany(e => e.AspNetUsers)
                .WithMany(e => e.AspNetRoles)
                .Map(m => m.ToTable("AspNetUserRoles").MapLeftKey("RoleId").MapRightKey("UserId"));

            modelBuilder.Entity<AspNetUsers>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<AspNetUsers>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<AspNetUsers>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<AspNetUsers>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<AspNetUsers>()
                .Property(e => e.TenthGrade)
                .IsUnicode(false);

            modelBuilder.Entity<AspNetUsers>()
                .Property(e => e.TwelfthGrade)
                .IsUnicode(false);

            modelBuilder.Entity<AspNetUsers>()
                .Property(e => e.GraduationGrade)
                .IsUnicode(false);

            modelBuilder.Entity<AspNetUsers>()
                .Property(e => e.PostGraduationGrade)
                .IsUnicode(false);

            modelBuilder.Entity<AspNetUsers>()
                .Property(e => e.Phd)
                .IsUnicode(false);

            modelBuilder.Entity<AspNetUsers>()
                .Property(e => e.WorksOn)
                .IsUnicode(false);

            modelBuilder.Entity<AspNetUsers>()
                .Property(e => e.Experience)
                .IsUnicode(false);

            modelBuilder.Entity<AspNetUsers>()
                .Property(e => e.Resume)
                .IsUnicode(false);

            modelBuilder.Entity<AspNetUsers>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<AspNetUsers>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<AspNetUsers>()
                .HasMany(e => e.AspNetUserClaims)
                .WithRequired(e => e.AspNetUsers)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<AspNetUsers>()
                .HasMany(e => e.AspNetUserLogins)
                .WithRequired(e => e.AspNetUsers)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Contact>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Contact>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Contact>()
                .Property(e => e.Subject)
                .IsUnicode(false);

            modelBuilder.Entity<Contact>()
                .Property(e => e.Message)
                .IsUnicode(false);

            modelBuilder.Entity<Country>()
                .Property(e => e.CountryName)
                .IsUnicode(false);

            modelBuilder.Entity<Jobs>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<Jobs>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Jobs>()
                .Property(e => e.Qualification)
                .IsUnicode(false);

            modelBuilder.Entity<Jobs>()
                .Property(e => e.Experience)
                .IsUnicode(false);

            modelBuilder.Entity<Jobs>()
                .Property(e => e.Specialization)
                .IsUnicode(false);

            modelBuilder.Entity<Jobs>()
                .Property(e => e.Salary)
                .IsUnicode(false);

            modelBuilder.Entity<Jobs>()
                .Property(e => e.JobType)
                .IsUnicode(false);

            modelBuilder.Entity<Jobs>()
                .Property(e => e.CompanyName)
                .IsUnicode(false);

            modelBuilder.Entity<Jobs>()
                .Property(e => e.CompanyImage)
                .IsUnicode(false);

            modelBuilder.Entity<Jobs>()
                .Property(e => e.Website)
                .IsUnicode(false);

            modelBuilder.Entity<Jobs>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Jobs>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Jobs>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<Jobs>()
                .Property(e => e.State)
                .IsUnicode(false);
        }
    }
}
