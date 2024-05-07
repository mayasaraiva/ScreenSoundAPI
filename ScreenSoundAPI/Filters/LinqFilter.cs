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

    public static void FilterAllCars(List<Carro> carros)
    {
        var allCars = carros.Select(modelo => modelo.Modelo).Distinct().ToList();
        foreach (var modelo in allCars)
        {
            Console.WriteLine($"- {modelo}");
        }
    }
}
