using DBTargetQuiz.Models;

namespace DBTargetQuiz.Services.Interfaces
{
    public interface IAnswerService
    {
        Task<IEnumerable<Answer>> GetAllAsync();
        Task<Answer?> GetByIdAsync(int id);
        Task AddAsync(Answer entity);
        Task UpdateAsync(Answer entity);
        Task DeleteAsync(int id);
    }
}
