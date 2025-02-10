using DBTargetQuiz.Models;
using DBTargetQuiz.Repository.Interfaces;
using DBTargetQuiz.Services.Interfaces;

namespace DBTargetQuiz.Services
{
    public class QuizAnswerService : IQuizAnswerService
    {
        private readonly IQuizAnswerRepository _repository;

        public QuizAnswerService(IQuizAnswerRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<QuizAnswer>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<QuizAnswer?> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task AddAsync(QuizAnswer entity)
        {
            await _repository.AddAsync(entity);
        }

        public async Task UpdateAsync(QuizAnswer entity)
        {
            await _repository.UpdateAsync(entity);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }
        public async Task AddRangeAsync(IEnumerable<QuizAnswer> entities)
        {
            await _repository.AddRangeAsync(entities);
        }
    }
}
