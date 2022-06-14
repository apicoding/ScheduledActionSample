using DIE.ScheduledAction;
using Microsoft.Extensions.DependencyInjection;

namespace ScheduledActionSample
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();
            ConfigureServices(services);
            var provider = services.BuildServiceProvider();
            var service = provider.GetRequiredService<ScheduledAction>();
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddLogging();
            services.AddHostedService<ScheduledAction>();
        }
    }
}
