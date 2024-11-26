using Microsoft.Extensions.DependencyInjection;
using Repository.Repositories;
using Repository.Repositories.Interfaces;

namespace Repository
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddRepositorylayer(this IServiceCollection services)
        {
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            return services;
        }

    }
}
