partial class Program
{
  static void SalaryCalculator()
  {
    
    Console.WriteLine("Calculadora salario\n");
    
    Console.Write("Ingrese su nombre: ");
    string nombre = Console.ReadLine() ?? "";
    
    Console.Write("Ingrese total horas trabajadas: ");
    int horasTrabajadas = int.Parse(Console.ReadLine() ?? "0");
    
    Console.Write("Ingrese salario por hora: ");
    int SalarioHora = int.Parse(Console.ReadLine() ?? "0");
    
    Console.WriteLine($"Salario total de {nombre} es de -> {horasTrabajadas*SalarioHora:C}");
  }
}