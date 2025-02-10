using DBTargetQuiz.Models;

namespace DBTargetQuiz.Services.Interfaces
{
    public interface IQuizAnswerService
    {
        Task<IEnumerable<QuizAnswer>> GetAllAsync();
        Task<QuizAnswer?> GetByIdAsync(int id);
        Task AddAsync(QuizAnswer entity);
        Task UpdateAsync(QuizAnswer entity);
        Task DeleteAsync(int id);
        Task AddRangeAsync(IEnumerable<QuizAnswer> entities);
    }
}
