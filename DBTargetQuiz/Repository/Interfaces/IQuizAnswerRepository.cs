using DBTargetQuiz.Models;

namespace DBTargetQuiz.Repository.Interfaces
{
    public interface IQuizAnswerRepository
    {
        Task<IEnumerable<QuizAnswer>> GetAllAsync();
        Task<QuizAnswer?> GetByIdAsync(int id);
        Task AddAsync(QuizAnswer entity);
        Task UpdateAsync(QuizAnswer entity);
        Task DeleteAsync(int id);
        Task AddRangeAsync(IEnumerable<QuizAnswer> entities);
    }
}
