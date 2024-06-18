using JornadaMilhas.ListaDeExercicios;

namespace JornadaMilhas.Test.TestesListaDeExercicios;

public class MusicaConstrutor
{
    [Theory]
    [InlineData("She's Gone")]
    [InlineData("Scar Tissue")]
    public void RetornaVerdadeiroQuandoNomeFoiInicializadoCorretamenteNaMusica(string nomeMusica)
    {
        Musica musica = new Musica(nomeMusica);

        Assert.Equal(nomeMusica, musica.Nome);
    }
    
    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(3)]
    public void RetornaVerdadeiroQuandoIdDaMusicaFoiInicializadoCorretamente(int idMusica)
    {
        Musica musica = new Musica("She's Gone") { Id = idMusica };

        Assert.True(idMusica == musica.Id);
    }
    
    [Theory]
    [InlineData(1, "She's Gone")]
    [InlineData(2, "Scar Tissue")]
    [InlineData(3, "Stricken")]
    public void RetornaStringDoMetodoToStringQuandoMusicaInicializadaEMetodoChamado(int idMusica, string nomeMusica)
    {
        Musica musica = new Musica(nomeMusica);
        musica.Id = idMusica;

        Assert.Contains($"Id: {idMusica} Nome: {nomeMusica}", musica.ToString());
    }

    [Fact]
    public void RetornaNuloQuandoAnoDaMusicaForNegativoOuMenorQueZero()
    {
        Musica musica = new Musica("Taste") { AnoLancamento = "0" };

        Assert.Null(musica.AnoLancamento);
    }

    [Theory]
    [InlineData("")]
    [InlineData(null)]
    public void RetornaArtistaDesconhecidoQuandoVazioOuNulo(string artista)
    {
        Musica musica = new Musica("The Way I Are") { Artista = artista };

        Assert.Contains("Artista Desconhecido", musica.Artista);
    }
}
