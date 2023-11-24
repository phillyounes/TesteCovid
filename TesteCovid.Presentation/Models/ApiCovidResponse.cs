namespace TesteCovid.Presentation.Models;

public class ApiCovidResponse
{
    public InfoGlobalResponse Global { get; set; }
    public CountryResponse[] Countries { get; set; }
}

public class InfoGlobalResponse
{
    public int NewConfirmed { get; set; }
    public int TotalConfirmed { get; set; }
    public int NewDeaths { get; set; }
    public int TotalDeaths { get; set; }
    public int NewRecovered { get; set; }
    public int TotalRecovered { get; set; }
}

public class CountryResponse
{
    public string Country { get; set; }
    public string CountryCode { get; set; }
    public string Slug { get; set; }
    public int NewConfirmed { get; set; }
    public int TotalConfirmed { get; set; }
    public int NewDeaths { get; set; }
    public int TotalDeaths { get; set; }
    public int NewRecovered { get; set; }
    public int TotalRecovered { get; set; }
    public DateTime Date { get; set; }
}
