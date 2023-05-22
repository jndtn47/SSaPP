namespace WebApi.Models
{
    public class AuthCandidate
    {
        public Guid Id { get; set; }
        public Candidate Candidate { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
