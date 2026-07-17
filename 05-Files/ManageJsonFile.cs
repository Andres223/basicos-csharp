using System.Text.Json;

namespace HelloApp._05_Files;


class Character
{
  public int Id { get; set; }
  public string? Name { get; set; }
  public string? Alias { get; set; }
  public string? Team { get; set; }
}
partial class Program
{
  public static void ManageJsonFile()
  {
    List<Character> characters =
    [
      new Character { Id = 1, Name = "Peter Parker", Alias = "Spider", Team = "Avengers" },
      new Character { Id = 2, Name = "Tony Stark", Alias
      = "Iron Man", Team = "Avengers" },
      new Character { Id = 3, Name = "Steve Rogers", Alias = "Capitán América", Team = "Avengers" }
    ];
    
    // Serializar a JSON
    var charactersJson = JsonSerializer.Serialize(
      characters,
      new JsonSerializerOptions { 
        WriteIndented=true, 
        Encoder=System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
      }
    );
    
    // Escribir un archivo JSON con esta transformación
    File.WriteAllText("./05-files/characters.json", charactersJson);
    
    // Deserializar JSON a un objeto
    var characterFromFile = File.ReadAllText("./05-Files/characters.json");
    var characterList = JsonSerializer.Deserialize<List<Character>>(characterFromFile);
    if (characterList != null)
      foreach (var character in characterList)
      {
        Console.WriteLine($"Id: {character.Id}, Nombre: {character.Name}, Alias: {character.Alias}, Equipo: {character.Team}");
      }
  }
}