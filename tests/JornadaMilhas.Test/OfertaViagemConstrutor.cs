using JornadaMilhasV1.Modelos;

namespace JornadaMilhas.Test;

public class OfertaViagemConstrutor
{
    [Theory]
    [InlineData("", null, "2024-01-01", "2024-01-02", 0, false)]
    [InlineData("OrigemTeste", "DestinhoTeste", "2024-01-01", "2024-01-02", 100, true)]
    public void RetornaEhValidoDeAcordoComOsDadosDeEntrada
        (string origem, string destino, string dataIda, string dataVolta, double preco, bool validacao)
    {
        Rota rota = new Rota(origem, destino);
        Periodo periodo = new Periodo(DateTime.Parse(dataIda), DateTime.Parse(dataVolta));
        
        OfertaViagem oferta = new OfertaViagem(rota, periodo, preco);

        Assert.Equal(validacao, oferta.EhValido);
    }
    
    [Fact]
    public void RetornaMensagemDeErroQuandoOfertaComRotaNula()
    {
        Rota rota = null;
        Periodo periodo = new Periodo(new DateTime(2024, 2, 1), new DateTime(2024, 2, 5));
        double preco = 100.0;

        OfertaViagem oferta = new OfertaViagem(rota, periodo, preco);

        Assert.Contains("A oferta de viagem não possui rota ou período válidos.", oferta.Erros.Sumario);
        Assert.False(oferta.EhValido);
    }

    [Theory]
    [InlineData(-100)]
    [InlineData(0)]
    public void RetornaMensagemDeErroDePrecoInvalidoQuandoPrecoMenorQueZero(double preco)
    {
        Rota rota = new Rota("OrigemTeste", "DestinoTeste");
        Periodo periodo = new Periodo(new DateTime(2024, 2, 1), new DateTime(2024, 2, 5));

        OfertaViagem oferta = new OfertaViagem(rota, periodo, preco);

        Assert.Contains("O preço da oferta de viagem deve ser maior que zero.", oferta.Erros.Sumario);
    }
}