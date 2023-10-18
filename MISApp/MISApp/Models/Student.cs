using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISApp.Models
{
   public class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        //public Grade? Grade { get; set; } 
        public int GradeId { get; set; }
    }
}
