using DBTargetQuiz.Data;
using DBTargetQuiz.Models;
using DBTargetQuiz.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DBTargetQuiz.Repository
{
    public class QuestionRepository : IQuestionRepository
    {
        private readonly ApplicationDbContext _context;

        public QuestionRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Question>> GetAllAsync()
        {
            return await _context.Set<Question>().ToListAsync();
        }

        public async Task<Question?> GetByIdAsync(int id)
        {
            return await _context.Set<Question>().FindAsync(id);
        }

        public async Task AddAsync(Question entity)
        {
            await _context.Set<Question>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Question entity)
        {
            _context.Set<Question>().Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _context.Set<Question>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<Question>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Question>> GetAllWithAnswersAsync()
        {
            return await _context.question
                .Include(q => q.Answers)
                .ToListAsync();
        }
    }
}
