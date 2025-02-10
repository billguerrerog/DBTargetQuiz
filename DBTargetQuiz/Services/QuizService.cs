using DBTargetQuiz.Models;
using DBTargetQuiz.Repository.Interfaces;
using DBTargetQuiz.Services.Interfaces;

namespace DBTargetQuiz.Services
{
    public class QuizService : IQuizService
    {
        private readonly IQuizRepository _repository;

        public QuizService(IQuizRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Quiz>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Quiz?> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task AddAsync(Quiz entity)
        {
            await _repository.AddAsync(entity);
        }

        public async Task UpdateAsync(Quiz entity)
        {
            await _repository.UpdateAsync(entity);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }

        public async Task CalculateMatchingCandidates(int quizId)
        {
            await _repository.CalculateMatchingCandidates(quizId);
        }
    }
}
