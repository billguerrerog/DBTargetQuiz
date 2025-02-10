using DBTargetQuiz.Models;

namespace DBTargetQuiz.Repository.Interfaces
{
    public interface ICandidateRepository
    {
        Task<IEnumerable<Candidate>> GetAllAsync();
        Task<Candidate?> GetByIdAsync(int id);
        Task AddAsync(Candidate entity);
        Task UpdateAsync(Candidate entity);
        Task DeleteAsync(int id);
    }
}
