using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;

namespace WebApi
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Organization> Organizations { get; set; } = null!;
        public DbSet<Employee> Employees { get; set; } = null!;
        public DbSet<AuthEmployee> AuthEmployees { get; set; } = null!;
        public DbSet<AuthCandidate> AuthCandidates { get; set; } = null!;
        public DbSet<Role> Roles { get; set; } = null!;
        public DbSet<JobOpening> JobOpenings { get; set; } = null!;
        public DbSet<Education> Educations { get; set; } = null!;
        public DbSet<EducationJob> EducationJobs { get; set; } = null!;
        public DbSet<Language> Languages { get; set; } = null!;
        public DbSet<LanguageJob> LanguageJobs { get; set; } = null!;
        public DbSet<Skill> Skills { get; set; } = null!;
        public DbSet<AdditionalSkill> AdditionalSkills { get; set; } = null!;
        public DbSet<Posts> PostJobs { get; set; } = null!;
        public DbSet<Post> Posts { get; set; } = null!;
        public DbSet<Resume> Resumes { get; set; } = null!;
        public DbSet<CandidatePost> CandidatePost { get; set; } = null!;
        public DbSet<FieldActivity> FieldActivities { get; set; } = null!;
        public DbSet<Candidate> Candidates { get; set; } = null!;

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=main.db");
        }
    }
}
