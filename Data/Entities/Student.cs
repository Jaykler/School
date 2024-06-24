using Shop.Data.Core;

namespace School.Data.Entities
{
    public class Student : BaseEntity
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public DateTime EnrollmentDate { get; set; }
    }
}
