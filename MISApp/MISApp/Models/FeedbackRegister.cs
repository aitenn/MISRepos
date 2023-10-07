using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISApp.Models
{
    public class FeedbackRegister
    {
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public Class? Class { get; set; }
        public List<StudentFeedback>? StudentFeedbacks { get; set; }
    }
}
