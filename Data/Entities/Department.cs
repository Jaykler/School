using Shop.Data.Core;

namespace School.Data.Entities
{
    public class Department: BaseEntity
    {
        public string Name { get; set; }
        public decimal Budget { get; set; }

        public DateTime StartDate { get; set; } = DateTime.Now;
        public int Administrador { get; set; }

    }
}
