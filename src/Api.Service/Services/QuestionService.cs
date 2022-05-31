using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Services.Question;

namespace Api.Service.Services
{
    public class QuestionService : IQuestionService
    {
        private IRepository<QuestionEntity> _repository;
        public QuestionService(IRepository<QuestionEntity> repository)
        {
            _repository = repository;
        }
        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<QuestionEntity> Get(Guid id)
        {
            return await _repository.SelectAsync(id);
        }

        public async Task<IEnumerable<QuestionEntity>> GetAll()
        {
            return await _repository.SelectAsync();
        }

        public async Task<QuestionEntity> Post(QuestionEntity question)
        {
            return await _repository.InsertAsync(question);
        }

        public async Task<QuestionEntity> Put(QuestionEntity question)
        {
            return await _repository.UpdateAsync(question);
        }
    }
}