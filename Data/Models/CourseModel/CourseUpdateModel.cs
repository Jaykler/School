namespace School.Data.Models.CourseModel
{
    public class CourseUpdateModel
    {
        public string? Title { get; set; }
        public int Credits { get; set; }
        public int DepartmentID { get; set; }
        public DateTime ModifyDate { get; set; } = DateTime.Now;
        public int UserMod { get; set; }
    }
}
