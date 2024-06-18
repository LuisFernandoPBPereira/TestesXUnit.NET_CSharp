using JornadaMilhasV1.Modelos;

namespace JornadaMilhas.Test.RotaTests;

public class RotaConstructor
{
    [Theory]
    [InlineData("Curitiba", "São Paulo")]
    public void RetornaVerdadeiroQuandoDadosInicializadosCorretamente(string origem, string destino)
    {
        var rota = new Rota(origem, destino);

        Assert.NotNull(rota);
        Assert.NotNull(rota.Origem);
        Assert.NotNull(rota.Destino);
    }
    
    [Theory]
    [InlineData("", "")]
    [InlineData(null, null)]
    public void Retorna2ErrosQuandoOrigemEDestinoForemVaziosOuNulos(string origem, string destino)
    {
        int quantidadeErros = 2;

        var rota = new Rota(origem, destino);

        Assert.Equal(quantidadeErros, rota.Erros.Count());
    }
}
