using System.Text.RegularExpressions;

class Musica
{

    public Musica(Banda artista)
    {
        Artista = artista;
    }
    public string Nome {get; set;} 
    public Banda Artista{get;} 
    public int Duracao{get ; set;}
    public bool Disponivel { get; set;}
    public string DescricaoResumida =>
            $"A musica {Nome}, pertence a banda {Artista}";

    public void ExibirFichaTecnica()
{
    Console.WriteLine($"Nome: {Nome}");
    System.Console.WriteLine($"Artista: {Artista}");
    System.Console.WriteLine($"Duração: {Duracao}");
    if (Disponivel)
    {
            System.Console.WriteLine($"Disponivel no plano");
    }else
    {
        System.Console.WriteLine("Adquira o plano plus");
    }
}
}