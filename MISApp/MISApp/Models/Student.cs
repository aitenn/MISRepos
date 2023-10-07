using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISApp.Models
{
   public class Student
    {
        private int id;
        private string? name;
        private string? surname;

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
    }
}
