using Elsa.Activities.Console;
using Elsa.Builders;

namespace MyConsoleApp
{
    public class HelloWorld : IWorkflow
    {
        public void Build(IWorkflowBuilder builder) => builder.WriteLine("Hello World!");
    }
}