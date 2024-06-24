namespace School.Data.Entities
{
    public class StudentGrade
    {
        public int Id { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set;}
        public decimal Grade {  get; set; }

    }
}
