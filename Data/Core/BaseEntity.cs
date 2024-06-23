namespace Shop.Data.Core
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public int CreationUser { get; set; }
        public DateTime ModifyDate { get; set;}
        public int UserMod { get; set;}   
        public int UserDelete { get; set;}
        public DateTime DeleteDate { get; set;}

        public bool Deleted { get; set; }

    }
    
}
    