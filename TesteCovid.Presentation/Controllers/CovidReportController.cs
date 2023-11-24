using Microsoft.AspNetCore.Mvc;
using TesteCovid.Presentation.App.Interface;
using TesteCovid.Presentation.ViewModel;

namespace TesteCovid.Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CovidReportController : ControllerBase
{
    private readonly IListCovidRepostByCountryApp _listCovidRepostByCountryApp;

    public CovidReportController(IListCovidRepostByCountryApp listCovidRepostByCountryApp)
    {
        _listCovidRepostByCountryApp = listCovidRepostByCountryApp;
    }

    [HttpGet]
    public async Task<IList<ListCovidReportByCountryViewModel>> Get()
    {
        return await _listCovidRepostByCountryApp.ListCovidReport();
    }
}
