using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

public class DomainCard
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string ManaCost { get; set; }

    [JsonPropertyName("originalType")]
    public string Type { get; set; }
    [JsonPropertyName("originalText")]
    public string Description { get; set; }
    public string Rarity { get; set; }
    public string ImageUrl { get; set; }
    [NotMapped]
    public string[] Colors { get; set; }

    public List<DomainCardRuling> Rulings { get; set; }
}