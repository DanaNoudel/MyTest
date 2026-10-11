namespace MyTest.Models {
    public class School {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }

        
        public List<Classroom> Classrooms { get; set; } = new List<Classroom>();
    }
}
