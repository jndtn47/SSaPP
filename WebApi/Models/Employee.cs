namespace WebApi.Models
{
    public class Employee
    {
        public Guid Id { get; set; }
        public Organization Organization { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Role Role { get; set; }
    }
}
