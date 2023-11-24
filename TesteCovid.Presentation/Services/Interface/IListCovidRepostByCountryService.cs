using TesteCovid.Presentation.Models;

namespace TesteCovid.Presentation.Services.Interface;

public interface IListCovidRepostByCountryService
{
    Task<ApiCovidResponse> ListCovidReport();
}
