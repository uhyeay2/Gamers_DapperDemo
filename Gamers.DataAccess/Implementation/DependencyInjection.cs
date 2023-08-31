using Gamers.DataAccess.Abstraction;
using Microsoft.Extensions.DependencyInjection;

namespace Gamers.DataAccess.Implementation
{
    public static class DependencyInjection
    {
        public static IServiceCollection InjectDataAccess(this IServiceCollection services, string connectionString)
        {
            services.AddSingleton<IDbConnectionFactory>(new DbConnectionFactory(connectionString));

            services.AddTransient<IDataAccess, DataAccess>();

            return services;
        }
    }
}
