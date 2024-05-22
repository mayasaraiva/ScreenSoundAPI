using System.Text.Json;

namespace ScreenSoundAPI.Models;

internal class MusicasFavoritas
{
    //Propriedades
    public string Nome { get; set; }
    public List<Musica> ListaDeMusicasFavoritas { get; }

    //Construtor
    public MusicasFavoritas(string nome)
    {
        Nome = nome;
        ListaDeMusicasFavoritas = new List<Musica>();
    }

    //Métodos
    public void AdicionarMusicasFavoritas(Musica musica)
    {
        ListaDeMusicasFavoritas.Add(musica);
    }

    public void ExibirListaMusicas()
    {
        Console.WriteLine($"Essas são as músicas favoritas -> {Nome}");
        foreach(var musica in ListaDeMusicasFavoritas)
        {
            Console.WriteLine($"- {musica.Nome} de {musica.Artista} ");
        }
        Console.WriteLine();
    }

    public void GerarArquivoJson()
    {
        string json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            musicas = ListaDeMusicasFavoritas
        });

        string nomeDoArquivo = $"musicas-favoritas-{Nome}.json";

        File.WriteAllText(nomeDoArquivo, json);
        Console.WriteLine($"Json criado com sucesso!{Path.GetFullPath(nomeDoArquivo)}");
    }
}
