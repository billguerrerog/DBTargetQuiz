using DBTargetQuiz.Data;
using DBTargetQuiz.Models;
using DBTargetQuiz.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DBTargetQuiz.Repository
{
    public class CandidateRepository : ICandidateRepository
    {
        private readonly ApplicationDbContext _context;

        public CandidateRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Candidate>> GetAllAsync()
        {
            return await _context.Set<Candidate>().ToListAsync();
        }

        public async Task<Candidate?> GetByIdAsync(int id)
        {
            return await _context.Set<Candidate>().FindAsync(id);
        }

        public async Task AddAsync(Candidate entity)
        {
            await _context.Set<Candidate>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Candidate entity)
        {
            _context.Set<Candidate>().Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _context.Set<Candidate>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<Candidate>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
