using System.Threading.Tasks;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces.Services.Health
{
    public interface IHealthService
    {
        Task<StatusEntity> Get();
    }
}
