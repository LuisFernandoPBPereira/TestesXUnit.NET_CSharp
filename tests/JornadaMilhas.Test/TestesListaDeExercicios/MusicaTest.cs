using JornadaMilhas.ListaDeExercicios;

namespace JornadaMilhas.Test.TestesListaDeExercicios;

public class MusicaTest
{
    [Fact]
    public void TesteNomeMusicaInicializadoCorretamente()
    {
        string nomeMusica = "She's Gone";

        Musica musica = new Musica(nomeMusica);

        Assert.Equal("She's Gone", musica.Nome);
    }
    
    [Fact]
    public void TesteIdMusicaInicializadoCorretamente()
    {
        int idMusica = 1;

        Musica musica = new Musica("She's Gone") { Id = idMusica };

        Assert.True(idMusica == musica.Id);
    }
    
    [Fact]
    public void TesteSaidaToString()
    {
        int idMusica = 1;
        string nomeMusica = "She's Gone";

        Musica musica = new Musica(nomeMusica);
        musica.Id = idMusica;

        Assert.Contains($"Id: {idMusica} Nome: {nomeMusica}", musica.ToString());
    }
}
