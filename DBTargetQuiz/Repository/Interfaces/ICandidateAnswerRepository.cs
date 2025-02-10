using DBTargetQuiz.Models;

namespace DBTargetQuiz.Repository.Interfaces
{
    public interface ICandidateAnswerRepository
    {
        Task<IEnumerable<CandidateAnswer>> GetAllAsync();
        Task<CandidateAnswer?> GetByIdAsync(int id);
        Task AddAsync(CandidateAnswer entity);
        Task UpdateAsync(CandidateAnswer entity);
        Task DeleteAsync(int id);
    }
}
