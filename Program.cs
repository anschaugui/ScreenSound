using System.Runtime.InteropServices;

Musica musica1 = new()
{
    Nome = "Roxane",
    Artista = "The Police",
    Duracao = 273,
    Disponivel = true
};
System.Console.WriteLine(musica1.Disponivel);

Musica musica2 = new Musica();
musica2.Nome = "Vertigol";
musica2.Artista = "U2";
musica2.Duracao = 367;
musica2.Disponivel = false;
System.Console.WriteLine(musica2.Disponivel);
musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();





