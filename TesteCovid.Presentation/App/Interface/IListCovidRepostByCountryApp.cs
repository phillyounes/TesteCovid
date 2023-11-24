using TesteCovid.Presentation.ViewModel;

namespace TesteCovid.Presentation.App.Interface;

public interface IListCovidRepostByCountryApp
{
    Task<IList<ListCovidReportByCountryViewModel>> ListCovidReport();
}
