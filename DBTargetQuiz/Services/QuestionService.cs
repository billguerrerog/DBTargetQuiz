using DBTargetQuiz.Models;
using DBTargetQuiz.Repository.Interfaces;
using DBTargetQuiz.Services.Interfaces;

namespace DBTargetQuiz.Services
{
    public class QuestionService : IQuestionService
    {
        private readonly IQuestionRepository _repository;

        public QuestionService(IQuestionRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Question>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Question?> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task AddAsync(Question entity)
        {
            await _repository.AddAsync(entity);
        }

        public async Task UpdateAsync(Question entity)
        {
            await _repository.UpdateAsync(entity);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }
        public async Task<IEnumerable<Question>> GetAllWithAnswersAsync()
        {
            return await _repository.GetAllWithAnswersAsync();
        }
    }
}
