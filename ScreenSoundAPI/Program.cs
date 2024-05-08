using ScreenSoundAPI.Filters;
using ScreenSoundAPI.Models;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        //musicas[0].ExibirDetalhesDaMusica();
        //LinqFilter.FilterAllGenresMusical(musicas);
        //LinqOrder.ExibirListaOrdenada(musicas);
        //LinqFilter.FilterArtistGenresMusical(musicas, "blues");
        LinqFilter.FilterMusicForArtist(musicas, "U2");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }

    try
    {
        string respostaCarro = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Carros.json");
        var carros = JsonSerializer.Deserialize<List<Carro>>(respostaCarro)!;
        //carros[4].ExibirDetalhesCarros();
        //LinqFilter.FilterAllCars(carros);
        LinqOrder.ExibirListaCarrosOrdenada(carros);
    } catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }

}