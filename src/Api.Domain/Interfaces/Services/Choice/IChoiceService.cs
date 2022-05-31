using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces.Services.Choice
{
    public interface IChoiceService
    {
        Task<ChoiceEntity> Get(Guid id);
        Task<IEnumerable<ChoiceEntity>> GetAll();
        Task<ChoiceEntity> Post(ChoiceEntity choice);
        Task<ChoiceEntity> Put(ChoiceEntity choice);
        Task<bool> Delete(Guid id);
    }
}
