using DBTargetQuiz.Models;

namespace DBTargetQuiz.Services.Interfaces
{
    public interface ICandidateAnswerService
    {
        Task<IEnumerable<CandidateAnswer>> GetAllAsync();
        Task<CandidateAnswer?> GetByIdAsync(int id);
        Task AddAsync(CandidateAnswer entity);
        Task UpdateAsync(CandidateAnswer entity);
        Task DeleteAsync(int id);
    }
}
