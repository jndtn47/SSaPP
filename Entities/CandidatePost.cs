namespace Entities
{
    public class CandidatePost
    {
        public Guid Id { get; set; }
        public Candidate Candidate { get; set; }
        public Post Post { get; set; }
        public int Experience { get; set; }
        public FieldActivity FieldActivity { get; set; }
    }
}
