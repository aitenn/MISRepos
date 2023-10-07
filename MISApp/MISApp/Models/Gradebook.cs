using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISApp.Models
{
    public class Gradebook
    {
        private int id;
        private Subject? subject;
        private List<StudentsGradesByDate>? studentsGradesByDate;

        public int Id { get; set; }
        public Subject? Subject { get; set; }
        public List<StudentsGradesByDate>? StudentsGradesByDates { get; set; }
    }
}
