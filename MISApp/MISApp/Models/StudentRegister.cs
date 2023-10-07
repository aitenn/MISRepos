using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISApp.Models
{
    public class StudentRegister
    {
        private int id;
        private Student? studentName;
        private bool isRegistered;

        public int Id { get; set; }
        public Student? StudentName { get; set; }
        public bool IsRegistered { get; set; }
    }
}
