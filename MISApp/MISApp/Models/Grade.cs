using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISApp.Models
{
    public class Grade
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Year { get; set; }
        public Teacher? Teacher { get; set; }
        public int TeacherId { get; set; }
        public ICollection<Student>? Students { get; set; }
    }
}
