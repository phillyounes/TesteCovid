using TesteCovid.Presentation.App;
using TesteCovid.Presentation.App.Interface;
using TesteCovid.Presentation.Services;
using TesteCovid.Presentation.Services.Interface;

namespace TesteCovid.Presentation.Infra
{
    public static class DependencyInjectionExtension
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            ConfigurateServices(services);
            ConfigurateApplication(services);
            return services;
        }

        private static void ConfigurateServices(IServiceCollection services)
        {
            services.AddScoped<IListCovidRepostByCountryService, ListCovidRepostByCountryService>();
        }

        private static void ConfigurateApplication(IServiceCollection services)
        {
            services.AddScoped<IListCovidRepostByCountryApp, ListCovidRepostByCountryApp>();
        }
    }
}
