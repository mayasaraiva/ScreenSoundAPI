using ScreenSoundAPI.Models;
using System.Linq;
namespace ScreenSoundAPI.Filters;

internal class LinqFilter
{
    public static void FilterAllGenresMusical(List<Musica> musicas)
    {
        var allGenres = musicas.Select(genero=>genero.Genero).Distinct().ToList();
        foreach (var genero in allGenres)
        {
            Console.WriteLine($"- {genero}");
        }
    }
    public static void FilterArtistGenresMusical(List<Musica> musicas, string genero)
    {
        var artistGenresMusical = musicas.Where(musicas => musicas.Genero!.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();
        Console.WriteLine($"Exibindo os artistas por gênero musical >> {genero}");
        foreach (var artista in artistGenresMusical)
        {
            Console.WriteLine($"- {artista}");
        }
    }

    public static void FilterMusicForArtist(List<Musica> musicas, string artista)
    {
        var musicArtist = musicas.Where(musicas => musicas.Artista!.Equals(artista)).ToList();
        Console.WriteLine(artista);
        foreach (var musica in musicArtist)
        {
            Console.WriteLine($"- {musica.Nome}");
        }
    }
    public static void FilterAllCars(List<Carro> carros)
    {
        var allCars = carros.Select(modelo => modelo.Modelo).Distinct().ToList();
        foreach (var modelo in allCars)
        {
            Console.WriteLine($"- {modelo}");
        }
    }
}
