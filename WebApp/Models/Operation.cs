using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Operation : BaseEntity
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int StudentID { get; set; }
        public int BookID { get; set; }
        // Relational Property
        public Student Student { get; set; }
        public Book Book { get; set; }
    }
}
