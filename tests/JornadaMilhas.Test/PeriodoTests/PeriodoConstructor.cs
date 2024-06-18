using JornadaMilhasV1.Modelos;

namespace JornadaMilhas.Test.PeriodoTests;

public class PeriodoConstructor
{
    [Theory]
    [InlineData("2024-01-01", "2024-02-02")]
    public void RetornaVerdadeiroQuandoAtributosInicializadosCorretamente(string dataInicial, string dataFinal)
    {
        var periodo = new Periodo(DateTime.Parse(dataInicial), DateTime.Parse(dataFinal));

        Assert.NotNull(periodo);
        Assert.Equal(DateTime.Parse(dataInicial), periodo.DataInicial);
        Assert.Equal(DateTime.Parse(dataFinal), periodo.DataFinal);
    }

    [Theory]
    [InlineData("2024-02-02", "2024-01-01")]
    public void RetornarErroQuandoDataInicialMaiorQueDataFinal(string dataInicial, string dataFinal)
    {
        int quantidadeErros = 1;

        var periodo = new Periodo(DateTime.Parse(dataInicial), DateTime.Parse(dataFinal));

        Assert.Equal(quantidadeErros, periodo.Erros.Count());
    }
}
