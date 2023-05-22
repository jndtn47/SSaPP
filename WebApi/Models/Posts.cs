namespace WebApi.Models
{
    public class Posts
    {
        public Guid Id { get; set; }
        public JobOpening JobOpening { get; set; }
        public Post Post { get; set; }
        public float PostC { get; set; }
        public FieldActivity FieldActivity { get; set; }
        public float FieldActivityC { get; set; }
    }
}
