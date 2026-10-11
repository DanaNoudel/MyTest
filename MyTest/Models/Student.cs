namespace MyTest.Models {
    public class Student {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int GradeLevel { get; set; }

        public int? ClassroomId { get; set; }
        public Classroom Classroom { get; set; }


        public List<Course> Courses { get; set; } = new List<Course>();
    }
}
