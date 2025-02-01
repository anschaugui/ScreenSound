using System.Text.RegularExpressions;

class Musica
{
public string nome; 
public string artista; 
public int duracao;
private bool disponivel; 

public void EscreveDisponivel(bool value)
{
    disponivel = value; 
}

public bool LeDisponivel()
{
    return disponivel;
}

public void ExibirFichaTecnica()
{
    Console.WriteLine($"Nome: {nome}");
    System.Console.WriteLine($"Artista: {artista}");
    System.Console.WriteLine($"Duração: {duracao}");
    if (disponivel)
    {
            System.Console.WriteLine($"Disponivel no plano");
    }else
    {
        System.Console.WriteLine("Adquira o plano plus");
    }
}
}