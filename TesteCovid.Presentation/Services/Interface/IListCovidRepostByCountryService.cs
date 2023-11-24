using TesteCovid.Presentation.ViewModel;

namespace TesteCovid.Presentation.Services.Interface;

public interface IListCovidRepostByCountryService
{
    Task<IList<ListCovidReportByCountryViewModel>> ListCovidReport();
}
