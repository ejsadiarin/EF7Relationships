namespace EF7Relationships.DTOs;

public record struct CharacterCreateDto(string Name, BackpackCreateDto Backpack);