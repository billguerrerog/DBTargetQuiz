using DBTargetQuiz.Models;

namespace DBTargetQuiz.Repository.Interfaces
{
    public interface IAnswerRepository
    {
        Task<IEnumerable<Answer>> GetAllAsync();
        Task<Answer?> GetByIdAsync(int id);
        Task AddAsync(Answer entity);
        Task UpdateAsync(Answer entity);
        Task DeleteAsync(int id);
    }
}
