using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISApp.Models
{
    public class Class
    {
        private int id;
        private string name;
        private int year;
        private Teacher teacher;
        private List<Student> students;

        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public Teacher Teacher { get; set; }
        public List<Student> Students { get; set; }
    }
}
