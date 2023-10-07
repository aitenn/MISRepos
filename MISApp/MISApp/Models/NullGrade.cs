namespace MISApp.Models
{
    public class NullGrade : Grade
    {
        public NullGrade()
        {
            this.Id = -1;
            this.Name = "Unknown";
            this.Year = -1;
            this.Teacher = null;
            this.TeacherId = -1;
            this.Students = null;
        }
    }
}
