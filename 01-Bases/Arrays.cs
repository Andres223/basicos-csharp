using System.Runtime.CompilerServices;

partial class Program
{
  static void Arrays()
  {
    int[] numbers = new int[5];
    numbers[0] = 1;
    
    // Directa
    int[] numbersArray = [5, 10, 15, 20, 25, 30];
    
    // índices
    Console.WriteLine($"Primer elemento {numbersArray[0]}");
    Console.WriteLine($"Segundo elemento {numbersArray[1]}");
    Console.WriteLine($"El numero de elementos es {numbersArray.Length}");
    
    // Recorrer desde el final del arreglo ^
    Console.WriteLine($"último elemento --> {numbersArray[^1]}");
    
    // Rangos para obtener arreglos
    int[] firstThree = numbersArray[..3];
    int[] fromIndexTwo = numbers[2..];
    foreach (var number in firstThree)
    {
      Console.WriteLine($"Los primeros tres --> {number}");
    }
  }
}