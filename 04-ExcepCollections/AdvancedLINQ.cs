namespace HelloApp;

class Hero
{
  public int Id { get; set; }
  public string? Name { get; set; }
  public string? Alias { get; set; }
  public string? Team { get; set; }
}

class Ability
{
  public int CharacterId { get; set; }
  public string? Description { get; set; }
}

class Statistic
{
  public int CharacterId { get; set; }
  public int Power { get; set; }
}

partial class Program
{
  public static void AdvancedLINQ()
  {
    List<Hero> characters =
    [
      new Hero { Id = 1, Name = "Peter Parker", Alias = "Spider-Man", Team = "Avengers" },
      new Hero { Id = 2, Name = "Tony Stark", Alias = "Iron Man", Team = "Avengers" },
      new Hero { Id = 3, Name = "Steve Rogers", Alias = "Capitán América", Team = "Avengers" },
      new Hero { Id = 4, Name = "T'Challa", Alias = "Black Panther", Team = "Wakanda" },
      new Hero { Id = 5, Name = "Stephen Strange", Alias = "Doctor Strange", Team = "Defenders" }
    ];

    List<Ability> abilities =
    [
      new Ability { CharacterId = 1, Description = "Sentido arácnido" },
      new Ability { CharacterId = 1, Description = "Trepar paredes" },
      new Ability { CharacterId = 2, Description = "Inteligencia y armadura de alta tecnología" },
      new Ability { CharacterId = 3, Description = "Super fuerza" },
      new Ability { CharacterId = 4, Description = "Reflejos aumentados" },
      new Ability { CharacterId = 5, Description = "Magia y hechicería" }
    ];
    List<Statistic> statistics =
    [
      new Statistic { CharacterId = 1, Power = 85 },
      new Statistic { CharacterId = 2, Power = 90 },
      new Statistic { CharacterId = 3, Power = 88 },
      new Statistic { CharacterId = 4, Power = 80 },
      new Statistic { CharacterId = 5, Power = 95 }
    ];

    // Unir colecciones - query
    var charactersWithAbilities = from c in characters
      join a in abilities on c.Id equals a.CharacterId
      select new { c.Alias, c.Name, a.Description };

    Console.WriteLine("🦸‍♂️ Personajes y sus habilidades:");
    foreach (var character in charactersWithAbilities)
    {
      Console.WriteLine($"{character.Alias} {character.Name} - Habilidad: {character.Description}");
    }
  }
}

// WriteLine($"⚡ Poder total de todos los personajes: {totalPower}");
// WriteLine($"🛡️ Promedio de poder de los Avengers: {avengersPower:F2}");
// WriteLine("📝 Cantidad de habilidades por personaje:");