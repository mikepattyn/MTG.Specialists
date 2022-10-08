using System.Text.Json.Serialization;

public class DomainCardRuling
{
    public int Id { get; set; }
    public DateOnly Date { get; set; }
    [JsonPropertyName("text")]
    public string Description { get; set; }

    public DomainCard Card { get; set; }
}