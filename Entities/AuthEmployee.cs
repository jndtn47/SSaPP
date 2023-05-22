namespace Entities
{
    public class AuthEmployee
    {
        public Guid Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public Employee Employee { get; set; }
    }
}
