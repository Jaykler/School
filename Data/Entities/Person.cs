namespace School.Data.Entities
{
    public class Person
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime HireDate { get; set; }

        public DateTime EnrollmentDate {  get; set; }
        public string? Discriminator { get; set; }

    }
}
