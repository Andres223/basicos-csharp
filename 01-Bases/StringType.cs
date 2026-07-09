partial class Program
{
  static void ShowStringTypes()
  {
    string name = "Andrés";
    // Concatenar
    string message = "Hola "+name;
    // Interpolar
    string interpolateMessage = $"Hola {name}";
  }
}