using Shop.Data.Core;

namespace School.Data.Entities
{
    public class Instructors : BaseEntity
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime HireDate { get; set; }

    }
}
