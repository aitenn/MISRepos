using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISApp.Models
{
    public class Register
    {
        private int id;
        private DateTime date;
        private Class? className;
        private List<StudentRegister>? studentRegisters;

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public Class? ClassName { get; set; }
        public List<StudentRegister>? StudentRegisters { get; set; }
    }
}
