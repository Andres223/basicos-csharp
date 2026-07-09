
partial class Program
{
  static void TypeDifference()
  { 
    Person person1 = new() { Name = "andres" };
    Person person2 = person1;
    person2.Name = "Alicia";

    Console.WriteLine($"person1.Name {person1.Name}");
  }
}

class Person
{
  public string? Name { get; set; }
}