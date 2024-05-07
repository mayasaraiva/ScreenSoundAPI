using System.Text.Json.Serialization;

namespace ScreenSoundAPI.Models;

internal class Carro
{
    [JsonPropertyName("marca")]
    public string? Marca { get; set; }
    [JsonPropertyName("modelo")]
    public string? Modelo { get; set; }
    [JsonPropertyName("motor")]
    public string? Motor { get; set; }
    [JsonPropertyName("ano")]
    public int Ano { get; set; }

    public void ExibirDetalhesCarros()
    {
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"Motor: {Motor}");
        Console.WriteLine($"Ano: {Ano}");

    }
}
