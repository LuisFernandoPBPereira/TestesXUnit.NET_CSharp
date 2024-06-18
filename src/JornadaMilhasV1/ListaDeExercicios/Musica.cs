namespace JornadaMilhas.ListaDeExercicios;

public class Musica
{
    private string anoLancamento;
    private string? artista;

    public Musica()
    {
        
    }
    public Musica(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; set; }
    public int Id { get; set; }
    public string? Artista 
    { 
        get => artista; 
        set
        {
            artista = value;

            if(artista is null || artista == string.Empty)
            {
                artista = "Artista Desconhecido";
            }
        } 
    }
    public string AnoLancamento 
    { 
        get => anoLancamento; 
        set
        {
            anoLancamento = value;
            
            if(int.Parse(anoLancamento) <= 0)
            {
                anoLancamento = null;
            }
        } 
    }

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");

    }

    public override string ToString()
    {
        return @$"Id: {Id} Nome: {Nome}";
    }
}
