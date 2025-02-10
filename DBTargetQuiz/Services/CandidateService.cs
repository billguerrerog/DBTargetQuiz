using DBTargetQuiz.Models;
using DBTargetQuiz.Repository.Interfaces;
using DBTargetQuiz.Services.Interfaces;

namespace DBTargetQuiz.Services
{
    public class CandidateService : ICandidateService
    {
        private readonly ICandidateRepository _repository;

        public CandidateService(ICandidateRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Candidate>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Candidate?> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task AddAsync(Candidate entity)
        {
            await _repository.AddAsync(entity);
        }

        public async Task UpdateAsync(Candidate entity)
        {
            await _repository.UpdateAsync(entity);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}
