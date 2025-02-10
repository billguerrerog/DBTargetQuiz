using DBTargetQuiz.Data;
using DBTargetQuiz.Models;
using DBTargetQuiz.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DBTargetQuiz.Repository
{
    public class AnswerRepository : IAnswerRepository
    {
        private readonly ApplicationDbContext _context;

        public AnswerRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Answer>> GetAllAsync()
        {
            return await _context.Set<Answer>().ToListAsync();
        }

        public async Task<Answer?> GetByIdAsync(int id)
        {
            return await _context.Set<Answer>().FindAsync(id);
        }

        public async Task AddAsync(Answer entity)
        {
            await _context.Set<Answer>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Answer entity)
        {
            _context.Set<Answer>().Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _context.Set<Answer>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<Answer>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
