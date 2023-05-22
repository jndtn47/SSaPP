namespace Entities
{
    public class LanguageJob
    {
        public Guid Id { get; set; }
        public JobOpening JobOpening { get; set; }
        public Language Language { get; set; }
        public decimal LanguageC { get; set; }
    }
}
