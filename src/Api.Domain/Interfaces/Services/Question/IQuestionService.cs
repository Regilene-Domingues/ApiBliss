using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces.Services.Question
{
    public interface IQuestionService
    {
        Task<QuestionEntity> Get(int id);
        Task<IEnumerable<QuestionEntity>> GetAll(int? page);
        // Task<QuestionEntity> Post(QuestionEntity question);
        // Task<QuestionEntity> Put(QuestionEntity question);
        // Task<bool> Delete(Guid id);
    }
}
