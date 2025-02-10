using DBTargetQuiz.Data;
using DBTargetQuiz.Models;
using DBTargetQuiz.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DBTargetQuiz.Repository
{
    public class QuizAnswerRepository : IQuizAnswerRepository
    {
        private readonly ApplicationDbContext _context;

        public QuizAnswerRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<QuizAnswer>> GetAllAsync()
        {
            return await _context.Set<QuizAnswer>().ToListAsync();
        }

        public async Task<QuizAnswer?> GetByIdAsync(int id)
        {
            return await _context.Set<QuizAnswer>().FindAsync(id);
        }

        public async Task AddAsync(QuizAnswer entity)
        {
            await _context.Set<QuizAnswer>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(QuizAnswer entity)
        {
            _context.Set<QuizAnswer>().Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _context.Set<QuizAnswer>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<QuizAnswer>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
        public async Task AddRangeAsync(IEnumerable<QuizAnswer> entities)
        {
            await _context.quiz_answer.AddRangeAsync(entities);
            await _context.SaveChangesAsync();
        }
    }
}
