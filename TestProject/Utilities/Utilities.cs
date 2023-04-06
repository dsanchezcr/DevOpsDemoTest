using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebApp.Data;

namespace TestProject.Utilities
{
    public static class Utilities
    {
        public static DbContextOptions<Context> TestDbContextOptions()
        {
            // Create a new service provider to create a new in-memory database.
            var serviceProvider = new ServiceCollection()
                .AddEntityFrameworkInMemoryDatabase()
                .BuildServiceProvider();

            // Create a new options instance using an in-memory database and 
            // IServiceProvider that the context should resolve all of its 
            // services from.
            var builder = new DbContextOptionsBuilder<Context>()
                .UseInMemoryDatabase("DevOpsDemoDB")
                .UseInternalServiceProvider(serviceProvider);

            return builder.Options;
        }
    }
}