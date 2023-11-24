using TesteCovid.Presentation.App.Interface;
using TesteCovid.Presentation.Services.Interface;
using TesteCovid.Presentation.ViewModel;

namespace TesteCovid.Presentation.App;

public class ListCovidRepostByCountryApp : IListCovidRepostByCountryApp
{
    private readonly IListCovidRepostByCountryService _listCovidRepostByCountryService;

    public ListCovidRepostByCountryApp(IListCovidRepostByCountryService listCovidRepostByCountryService)
    {
        _listCovidRepostByCountryService = listCovidRepostByCountryService;
    }

    public async Task<IList<ListCovidReportByCountryViewModel>> ListCovidReport()
    {
        var itensPorPagina = 10;
        var objectResponse = await _listCovidRepostByCountryService.ListCovidReport();

        var listViewModel = objectResponse.Countries
                    .Select(country => new ListCovidReportByCountryViewModel(
                                            country.Country,
                                            country.TotalConfirmed - country.TotalRecovered)).ToList();

        if (listViewModel is null)
            return new List<ListCovidReportByCountryViewModel>();

        var posicao = 1;
        foreach (var viewModel in listViewModel.OrderByDescending(c => c.TotalCasosAtivos).Take(itensPorPagina))
            viewModel.ChangePosicaoRanking(posicao++);

        return listViewModel
            .OrderByDescending(l => l.PosicaoRanking)
            .ToList();
    }
}
