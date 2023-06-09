using System.Text.Json.Serialization;

namespace EF7Relationships.Models;

public class Weapon
{
    public int Id { get; set; }
    public string Name { get; set; }
    
    [JsonIgnore]
    public int CharacterId { get; set; }
    
    [JsonIgnore]
    public Character Character { get; set; }
}