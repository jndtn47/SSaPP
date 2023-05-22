namespace Entities
{
    public class AdditionalSkill
    {
        public Guid Id { get; set; }
        public JobOpening JobOpening { get; set; }
        public Skill Skill { get; set; }
        public decimal SkillC { get; set; }
    }
}
