using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Services.Choice;

namespace Api.Service.Services
{
    public class ChoiceService : IChoiceService
    {
        private IRepository<ChoiceEntity> _repository;
        public ChoiceService(IRepository<ChoiceEntity> repository)
        {
            _repository = repository;
        }
        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<ChoiceEntity> Get(Guid id)
        {
            return await _repository.SelectAsync(id);
        }

        public async Task<IEnumerable<ChoiceEntity>> GetAll()
        {
            return await _repository.SelectAsync();
        }

        public async Task<ChoiceEntity> Post(ChoiceEntity choice)
        {
            return await _repository.InsertAsync(choice);
        }

        public async Task<ChoiceEntity> Put(ChoiceEntity choice)
        {
            return await _repository.UpdateAsync(choice);
        }
    }
}
