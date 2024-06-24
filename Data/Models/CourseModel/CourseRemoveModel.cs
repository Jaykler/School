namespace School.Data.Models.CourseModel
{
    public class CourseRemoveModel
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public int Credits { get; set; }
        public int DepartmentID { get; set; }
        public int UserDelete { get; set; }
        public DateTime DeleteDate { get; set; } = DateTime.Now;
        public bool Deleted { get; set; }
    }
}
