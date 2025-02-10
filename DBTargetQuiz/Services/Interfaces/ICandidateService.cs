using DBTargetQuiz.Models;

namespace DBTargetQuiz.Services.Interfaces
{
    public interface ICandidateService
    {
        Task<IEnumerable<Candidate>> GetAllAsync();
        Task<Candidate?> GetByIdAsync(int id);
        Task AddAsync(Candidate entity);
        Task UpdateAsync(Candidate entity);
        Task DeleteAsync(int id);
    }
}
