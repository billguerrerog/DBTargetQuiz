using Microsoft.EntityFrameworkCore;
using DBTargetQuiz.Models;

namespace DBTargetQuiz.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CandidateAnswer>()
                .HasKey(ca => new { ca.CandidateId, ca.QuestionId });

            modelBuilder.Entity<QuizAnswer>()
                .HasKey(qa => new { qa.QuizId, qa.QuestionId });

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Answer> answer { get; set; }
        public DbSet<Candidate> candidate { get; set; }
        public DbSet<CandidateAnswer> candidate_answer { get; set; }
        public DbSet<Question> question { get; set; }
        public DbSet<Quiz> quiz { get; set; }
        public DbSet<QuizAnswer> quiz_answer { get; set; }
    }
}
