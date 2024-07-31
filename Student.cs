namespace ExampleFluentAPI
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        //Foreign key for Standard
        public int StandardId { get; set; }
        public Standard Standard { get; set; }
    }
}
