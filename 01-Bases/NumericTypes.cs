partial class Program
{
  static void ShowNumericTypes()
  {
    int integerNumber = int.MaxValue;
    Console.WriteLine($"integer -> {integerNumber}");
    
    double doubleNumber = double.MaxValue;
    Console.WriteLine($"double -> {doubleNumber}");
    
    float floatNumber = float.MaxValue;
    float floatNumberDos = 274f;
    Console.WriteLine($"float -> {floatNumber} | floatSintaxis -> {floatNumberDos}");
    
    long longNumber = 300_200_100L;
    long longNumberMaxValue = long.MaxValue;
    Console.WriteLine($"long -> {longNumber} | longMaxValue  -> {longNumberMaxValue}");
    
    // Para cálculos financieros, mayor precisión
    decimal monetaryNumber = 99.99m;
    Console.WriteLine($"decimal -> {monetaryNumber}");
    
    // Inferir el tipo
    //var integerNumberVar = 1;
  }
}