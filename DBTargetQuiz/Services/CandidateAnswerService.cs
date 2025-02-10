using DBTargetQuiz.Models;
using DBTargetQuiz.Repository.Interfaces;
using DBTargetQuiz.Services.Interfaces;

namespace DBTargetQuiz.Services
{
    public class CandidateAnswerService : ICandidateAnswerService
    {
        private readonly ICandidateAnswerRepository _repository;

        public CandidateAnswerService(ICandidateAnswerRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<CandidateAnswer>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<CandidateAnswer?> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task AddAsync(CandidateAnswer entity)
        {
            await _repository.AddAsync(entity);
        }

        public async Task UpdateAsync(CandidateAnswer entity)
        {
            await _repository.UpdateAsync(entity);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}
