namespace School.Data.Models.CourseModel
{
    public class CourseAddModel
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public int Credits { get; set; }
        public int DepartmentID { get; set; }

        public DateTime? CreationDate { get; set; }

        public string? CreationUser { get;}
    }
}
