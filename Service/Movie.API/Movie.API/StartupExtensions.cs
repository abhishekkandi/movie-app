using Microsoft.Extensions.DependencyInjection;
using Movie.API.Services;

namespace Movie.API
{
    public static class StartupExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<IMovieRepository, MovieRepository>();

            return services;
        }
    }
}
