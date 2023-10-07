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
        public Student? StudentName { get; set; }
        public bool IsRegistered { get; set; }
    }
}
