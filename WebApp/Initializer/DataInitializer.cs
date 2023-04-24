using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Initializer
{
    public static class DataInitializer  
    {
        public static void Seed(ModelBuilder modelBuilder) 
        {
          string password1 =  BCrypt.Net.BCrypt.HashPassword("123");
          string password2 = BCrypt.Net.BCrypt.HashPassword("1234");

            modelBuilder.Entity<AppUser>().HasData(
                new AppUser() { ID = 1, UserName = "administrator", Password = password1, Role = Enums.Role.admin }, 
                new AppUser() { ID = 2, UserName = "Aslı", Password = password2, Role = Enums.Role.user } 
                );

            modelBuilder.Entity<Student>().HasData(
                new Student() { ID = 1, FirstName = "Avacato", LastName = "Great", Gender = Enums.Gender.Erkek},
                new Student() { ID = 2, FirstName = "Mooncake", LastName = "Green", Gender = Enums.Gender.Erkek },
                new Student() { ID = 3, FirstName = "Gary", LastName = "GoodSpeed", Gender = Enums.Gender.Erkek },
                new Student() { ID = 4, FirstName = "Tribore", LastName = "Menendez", Gender = Enums.Gender.Kadın }
                );

            modelBuilder.Entity<StudentDetail>().HasData(
                new StudentDetail() { ID=1, StudentID=1, SchoolNumber="70", BirthDay = new DateTime(1987, 02,26)},
                new StudentDetail() { ID = 2, StudentID = 2, SchoolNumber = "85", BirthDay = new DateTime(1989, 03, 21) },
                new StudentDetail() { ID = 3, StudentID = 3, SchoolNumber = "196", BirthDay = new DateTime(1986, 02, 26) },
                new StudentDetail() { ID = 4, StudentID = 4, SchoolNumber = "317", BirthDay = new DateTime(1986, 03, 21) }
                );

        }
    }
}
