using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISApp.Models
{
    public class StudentsGradesByDate
    {
        private int id;
        private Student? studentName;
        private DateTime? date;
        private int grade;

        public int Id { get; set; }
        public Student? StudentName { get; set; }
        public DateTime? Date { get; set; }
        public int Grade { get; set; }
    }
}
