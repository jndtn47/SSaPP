namespace Entities
{
    public class EducationJob
    {
        public Guid Id { get; set; }
        public JobOpening JobOpening { get; set; }
        public Education Education { get; set; }
        public decimal EducationC { get; set; }
    }
}
