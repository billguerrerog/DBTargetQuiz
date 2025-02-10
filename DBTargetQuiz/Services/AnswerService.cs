using DBTargetQuiz.Models;
using DBTargetQuiz.Models;
using DBTargetQuiz.Repository.Interfaces;
using DBTargetQuiz.Services.Interfaces;

namespace DBTargetQuiz.Services
{
    public class AnswerService : IAnswerService
    {
        private readonly IAnswerRepository _repository;

        public AnswerService(IAnswerRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Answer>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Answer?> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task AddAsync(Answer entity)
        {
            await _repository.AddAsync(entity);
        }

        public async Task UpdateAsync(Answer entity)
        {
            await _repository.UpdateAsync(entity);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}
