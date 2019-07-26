using Microsoft.Extensions.DependencyInjection;
using VillageDrill.Models.Repositories;

namespace VillageDrill.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureRepositoryWrapper(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
        }
    }
}
