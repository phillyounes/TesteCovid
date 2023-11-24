namespace TesteCovid.Presentation.ViewModel;

public class ListCovidReportByCountryViewModel
{
    public string NomePais { get; init; }
    public int PosicaoRanking { get; private set; }
    public int TotalCasosAtivos { get; init; }

    public ListCovidReportByCountryViewModel(
        string nomePais,
        int totalCasosAtivos)
    {
        NomePais = nomePais;
        TotalCasosAtivos = totalCasosAtivos;
    }

    public void ChangePosicaoRanking(int posicaoRanking)
        => PosicaoRanking = posicaoRanking;
}
