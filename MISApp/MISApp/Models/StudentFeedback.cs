using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISApp.Models
{
    public class StudentFeedback
    {
        public int Id { get; set; }
        public Student? Student { get; set;}
        public int StudentId { get; set; }
        public string? Feedback { get; set; }
        public FeedbackRegister? FeedbackRegister { get; set; }
        public int FeedbackRegisterId { get; set; }
    }
}
