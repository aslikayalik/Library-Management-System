using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class StudentDetail:BaseEntity
    {
        public string SchoolNumber { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDay { get; set; }
        public int StudentID { get; set; }
        // Relational Property
        public virtual Student Student { get; set; }


    }
}
