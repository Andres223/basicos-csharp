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

        // Conviertiendo a mayúsculas query
        var uppercaseNamesQuery = from c in characters
            select c.Name?.ToUpper();
        // Conviertiendo a mayúsculas method
        var uppercaseNamesMethod = characters.Select(c => c.Name?.ToUpper());

        Console.WriteLine("Con query");
        foreach (var name in uppercaseNamesQuery)
        {
            Console.WriteLine(name);
        }

        Console.WriteLine("Con method");
        foreach (var name in uppercaseNamesMethod)
        {
            Console.WriteLine(name);
        }
    }
}

class MarvelCharacter
{
    public string? Name { get; set; }
    public string? Alias { get; set; }
    public string? Team { get; set; }
}
