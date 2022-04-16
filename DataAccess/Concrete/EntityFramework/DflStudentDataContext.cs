using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //Context : Db tabloları ile proje classlarını ilişkilendirmek
    public class DflStudentDataContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=DflStudentsData;Trusted_Connection=true");
        }

        public DbSet<Student> Students{ get; set; }
        public DbSet<School> Schools{ get; set; }
    }
}
