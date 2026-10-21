using System.Text.Json.Serialization;

namespace BlazorPokeApi.Models;

public class Pokemon
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    // Em decímetros
    [JsonPropertyName("height")]
    public int Height { get; set; }

    // Em hectogramas
    [JsonPropertyName("weight")]
    public int Weight { get; set; }

    [JsonPropertyName("sprites")]
    public Sprites Sprites { get; set; } = new();
}

public class Sprites
{
    [JsonPropertyName("other")]
    public OtherSprites Other { get; set; } = new();
}

public class OtherSprites
{
    [JsonPropertyName("official-artwork")]
    public OfficialArtwork OfficialArtwork { get; set; } = new();
}

public class OfficialArtwork
{
    [JsonPropertyName("front_default")]
    public string? FrontDefault { get; set; }
}
