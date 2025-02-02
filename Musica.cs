using System.Text.RegularExpressions;

class Musica
{
public string Nome {get; set;} 
public string Artista{get ; set;} 
public int Duracao{get ; set;}
public bool Disponivel { get; set;}
public string NomeCompleto { get; set; }

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