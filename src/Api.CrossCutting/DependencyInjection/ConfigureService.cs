using Api.Domain.Interfaces.Services.Choice;
using Api.Domain.Interfaces.Services.Health;
using Api.Domain.Interfaces.Services.Question;
using Api.Service.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Api.CrossCutting.DependencyInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependenciesService(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IChoiceService, ChoiceService>();
            serviceCollection.AddTransient<IQuestionService, QuestionService>();
            serviceCollection.AddTransient<IHealthService, HealthService>();
        }
    }
}
