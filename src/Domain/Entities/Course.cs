namespace Domain.Entities
{
    public class Course
    {
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public string CourseCode { get; set; }
        public string CourseDescription { get; set; }          
        public string Department { get; set; }
        public string Instructor { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<string> Prerequisites { get; set; }
        public int MaxCapacity { get; set; }
        public List<Student> EnrolledStudents { get; set; }
    }
}