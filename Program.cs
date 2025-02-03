using System.Runtime.InteropServices;

Musica musica1 = new Musica();
musica1.Nome = "Roxane";
musica1.Artista = "The police";
musica1.Duracao = 273;
musica1.Disponivel = true;
Console.WriteLine(musica1.DescricaoResumida);
Console.WriteLine($"a musica está disponivel: {musica1.Disponivel}");

Musica musica2 = new Musica();
musica2.Nome = "Toxicity";
musica2.Artista = "System of down";
musica2.Duracao = 235;
musica2.Disponivel = false;
Console.WriteLine(musica2.DescricaoResumida);
Console.WriteLine($"a musica está disponivel: {musica2.Disponivel}");

//exibir a ficha tecnica das instâncias criadas a partir da classe "Musica"
musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();





