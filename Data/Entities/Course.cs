using Shop.Data.Core;

namespace Shop.Data.Entities
{
    public class Course: BaseEntity
    {
        public string? Title { get; set; }
        public int Credits { get; set; }
        public int DepartmentID  { get; set; }

        
    }
}
