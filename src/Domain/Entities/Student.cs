namespace Domain.Entities
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public int MAT_Number { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public int YearEnrolled { get; set; }
        public DateTime DateOfGraduation { get; set; }
        public string GuardianName { get; set; }
        public string GuardianContact { get; set; }
        public double GPA { get; set; }

    }
}