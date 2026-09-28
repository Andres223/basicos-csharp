using System.ComponentModel.DataAnnotations;

namespace HelloApp;

partial class Program
{
    static void Linq()
    {
        List<MarvelCharacter> characters = new List<MarvelCharacter>
        {
            new MarvelCharacter { Name = "Peter Parker", Alias = "Spider-Man", Team = "Avengers" },
            new MarvelCharacter { Name = "Tony Stark", Alias = "Iron Man", Team = "Avengers" },
            new MarvelCharacter { Name = "Steve Rogers", Alias = "Captain America", Team = "Avengers" },
            new MarvelCharacter { Name = "Natasha Romanoff", Alias = "Black Widow", Team = "Avengers" },
            new MarvelCharacter { Name = "T'Challa", Alias = "Black Panther", Team = "Wakanda" },
            new MarvelCharacter { Name = "Stephen Strange", Alias = "Doctor Strange", Team = "Defenders" }
        };

        // Obtener los primeros tres por query
        var firstThreeQuery =
            (from c in characters select c).Take(3);

        // Obtener los primeros tres por method
        var firstThreeMethod = characters.Take(3);

        Console.WriteLine("Obtener los primeros tres");
        foreach (var character in firstThreeQuery)
        {
            Console.WriteLine(character.Name);
        }
    }
}

class MarvelCharacter
{
    public string? Name { get; set; }
    public string? Alias { get; set; }
    public string? Team { get; set; }
}
