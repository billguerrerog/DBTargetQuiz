using DBTargetQuiz.Data;
using DBTargetQuiz.Models;
using DBTargetQuiz.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DBTargetQuiz.Repository
{
    public class CandidateAnswerRepository : ICandidateAnswerRepository
    {
        private readonly ApplicationDbContext _context;

        public CandidateAnswerRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<CandidateAnswer>> GetAllAsync()
        {
            return await _context.Set<CandidateAnswer>().ToListAsync();
        }

        public async Task<CandidateAnswer?> GetByIdAsync(int id)
        {
            return await _context.Set<CandidateAnswer>().FindAsync(id);
        }

        public async Task AddAsync(CandidateAnswer entity)
        {
            await _context.Set<CandidateAnswer>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(CandidateAnswer entity)
        {
            _context.Set<CandidateAnswer>().Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _context.Set<CandidateAnswer>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<CandidateAnswer>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
