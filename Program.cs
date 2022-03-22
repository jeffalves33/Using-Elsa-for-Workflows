using System.Threading.Tasks;
using Elsa.Services;
using Microsoft.Extensions.DependencyInjection;

namespace MyConsoleApp
{
    class Program
    {
        private static async Task Main()
        {
            /*adiciona um novo serviço à collection*/
            var services = new ServiceCollection()
                .AddElsa(options => options
                    .AddConsoleActivities()
                    .AddWorkflow<HelloWorld>())
                .BuildServiceProvider();

            var workflowRunner = services.GetRequiredService<IBuildsAndStartsWorkflow>();
            await workflowRunner.BuildAndStartWorkflowAsync<HelloWorld>();
        }
    }
}