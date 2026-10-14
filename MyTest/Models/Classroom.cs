namespace MyTest.Models {
    public class Classroom {
        public int Id { get; set; }
        public string Name { get; set; }


        public int? SchoolId { get; set; }
        public School? School { get; set; }


        public List<Student> Students { get; set; } = new List<Student>();
    }
}
