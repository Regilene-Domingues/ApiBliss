using System;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Services.Health;

namespace Api.Service.Services
{
    public class HealthService : IHealthService
    {
        public async Task<StatusEntity> Get()
        {
            var random = await Task.FromResult(new Random().Next(3));
            var verifytype = (random % 2 == 0) ? true : false;
            return new StatusEntity()
            {
                Status = (verifytype) ? "Ok" : "Service Unavailable. Please try again later.",
                Result = verifytype
            };
        }
    }
}
