using System.Text.Json;
using TesteCovid.Presentation.Models;
using TesteCovid.Presentation.Services.Interface;
using TesteCovid.Presentation.ViewModel;

namespace TesteCovid.Presentation.Services;

public class ListCovidRepostByCountryService : IListCovidRepostByCountryService
{
    public async Task<IList<ListCovidReportByCountryViewModel>> ListCovidReport()
    {
        var urlBase = "https://api.covid19api.com/summary";
        var itensPorPagina = 10;

        using (HttpClient client = new HttpClient())
        {
            try
            {
                var jsonResponse = await client.GetStringAsync(urlBase);
                var objectResponse = JsonSerializer.Deserialize<ApiCovidResponse>(jsonResponse);

                if (objectResponse is null)
                    return new List<ListCovidReportByCountryViewModel>();

                var listViewModel = objectResponse.Countries
                    .Select(country => new ListCovidReportByCountryViewModel(
                                            country.Country,
                                            country.TotalConfirmed - country.TotalRecovered)).ToList();

                var posicao = 1;
                foreach (var viewModel in listViewModel.OrderByDescending(c => c.TotalCasosAtivos).Take(itensPorPagina))
                    viewModel.ChangePosicaoRanking(posicao++);

                return listViewModel;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
