partial class Program
{
  static void HandleNullables()
  {
    // No nulificable
    string firstName = "Andrés";
    
    // Nulificable
    string? lastName = null;
    Console.WriteLine($"Nombre: {firstName}");

    if (lastName != null)
    {
      Console.WriteLine($"Apellido: {lastName}");
    }
    else
    {
      Console.WriteLine("Apellido no especificado.");
    }
    
    // Operador de coalescencia nula "??"
    // Nos permite resumir la sentencia if-else de arriba
    Console.WriteLine($"Apellido: {lastName ?? "Apellido no especificado"}");
    
    // Operador de acceso nulo seguro. "?"
    string? text = null;
    Console.WriteLine(text?.Length);
    Console.WriteLine("Sigue ejecutando");
  }
}