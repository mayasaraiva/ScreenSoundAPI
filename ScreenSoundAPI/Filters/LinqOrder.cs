using ScreenSoundAPI.Models;
using System.Linq;
using System.Net.WebSockets;

namespace ScreenSoundAPI.Filters;

internal class LinqOrder
{
    public static void ExibirListaOrdenada(List<Musica> musicas)
    {
        var artistasOrdenados = musicas.OrderBy(musica => musica.Artista).Select(musica => musica.Artista).Distinct().ToList();
        Console.WriteLine("Lista de artistas ordenados:");
        foreach (var artista in artistasOrdenados)
        {
            Console.WriteLine($"- {artista}");
        }
    }

    public static void ExibirListaCarrosOrdenada(List<Carro> carros)
    {
        var carroOrdenado = carros.OrderBy(carros => carros.Modelo).Select(carros => carros.Modelo).Distinct().ToList();
        Console.WriteLine("Lista de carros ordenados:");
        foreach (var carro in carroOrdenado)
        {
            Console.WriteLine($"- {carro}");
        }
    }
}
