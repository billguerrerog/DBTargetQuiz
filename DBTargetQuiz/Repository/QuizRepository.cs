using DBTargetQuiz.Data;
using DBTargetQuiz.Models;
using DBTargetQuiz.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DBTargetQuiz.Repository
{
    public class QuizRepository : IQuizRepository
    {
        private readonly ApplicationDbContext _context;

        public QuizRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Quiz>> GetAllAsync()
        {
            return await _context.Set<Quiz>().ToListAsync();
        }

        public async Task<Quiz?> GetByIdAsync(int id)
        {
            return await _context.Set<Quiz>()
                .AsNoTracking()
                .FirstOrDefaultAsync(q => q.QuizId == id);
        }

        public async Task AddAsync(Quiz entity)
        {
            await _context.Set<Quiz>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Quiz entity)
        {
            _context.Set<Quiz>().Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _context.Set<Quiz>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<Quiz>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }

        public async Task CalculateMatchingCandidates(int quizId)
        {
            await _context.Database.ExecuteSqlRawAsync("EXEC upCalculateMatchingCandidates @p0", quizId);
        }
    }
}
