using TesteCovid.Presentation.Services;
using TesteCovid.Presentation.Services.Interface;

namespace TesteCovid.Presentation.Infra
{
    public static class DependencyInjectionExtension
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            Configurate(services);
            return services;
        }

        private static void Configurate(IServiceCollection services)
        {
            services.AddScoped<IListCovidRepostByCountryService, ListCovidRepostByCountryService>();
        }
    }
}
