using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Student> builder)
        {
          
           builder.Property(x => x.FirstName).IsRequired();  
           builder.Property(x => x.LastName).IsRequired();

           builder.HasOne<StudentDetail>(s => s.StudentDetail)
                .WithOne(sd => sd.Student)
                .HasForeignKey<StudentDetail>(sd => sd.StudentID);
         
        }
    }
}
