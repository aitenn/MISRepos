using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISApp.Models
{
    public class AttendanceRegister
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
       // public Grade? Grade { get; set; }
        public ICollection<StudentAttendance>? StudentAttendances { get; set; }
    }
}
