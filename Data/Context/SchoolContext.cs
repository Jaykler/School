using Microsoft.EntityFrameworkCore;
using School.Data.Entities;
using Shop.Data.Entities;

namespace School.Data.Context
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options): base(options) { }

        #region Db-Set

        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseInstructor> CoursesInstructors { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<OnlineCourse> OnlineCourses { get; set; }
        public DbSet<OfficeAssignment> OfficeAssignments { get; set; }
        public DbSet<OnsiteCourse> OnsiteCourses { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<StudentGrade> StudentGrades { get;set; }
        public DbSet<Student>Students {  get; set; } 

        #endregion
    }
}
