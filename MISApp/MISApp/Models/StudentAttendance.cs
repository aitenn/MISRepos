using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISApp.Models
{
    public class StudentAttendance
    {
        public int Id { get; set; }
        public Student? Student { get; set; }
        public int StudentId { get; set; }
        public bool IsRegistered { get; set; }
        public AttendanceRegister?  AttendanceRegister { get; set; }
        public int AttendanceRegisterId { get; set; }
    }
}
