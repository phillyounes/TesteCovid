using Microsoft.AspNetCore.Mvc;
using TesteCovid.Presentation.Services.Interface;
using TesteCovid.Presentation.ViewModel;

namespace TesteCovid.Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CovidReportController : ControllerBase
{
    private readonly IListCovidRepostByCountryService _listCovidRepostByCountryService;

    public CovidReportController(IListCovidRepostByCountryService listCovidRepostByCountryService)
    {
        _listCovidRepostByCountryService = listCovidRepostByCountryService;
    }

    [HttpGet]
    public async Task<IList<ListCovidReportByCountryViewModel>> Get()
    {
        return await _listCovidRepostByCountryService.ListCovidReport();
    }
}
