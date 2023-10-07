using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISApp.Models
{
    public class Register
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public Class? ClassName { get; set; }
        public List<StudentAttendance>? StudentAttendances { get; set; }
    }
}
