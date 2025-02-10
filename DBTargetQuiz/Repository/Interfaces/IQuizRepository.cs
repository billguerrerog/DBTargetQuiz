using DBTargetQuiz.Models;

namespace DBTargetQuiz.Repository.Interfaces
{
    public interface IQuizRepository
    {
        Task<IEnumerable<Quiz>> GetAllAsync();
        Task<Quiz?> GetByIdAsync(int id);
        Task AddAsync(Quiz entity);
        Task UpdateAsync(Quiz entity);
        Task DeleteAsync(int id);
        Task CalculateMatchingCandidates(int quizId);
    }
}
