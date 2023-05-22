namespace WebApi.Models
{
    public class Resume
    {
        public Guid Id { get; set; }
        public JobOpening JobOpening { get; set; }
        public Candidate Candidate { get; set; }
        public decimal EducationCost { get; set; }
    }
}
