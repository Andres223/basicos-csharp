namespace HelloApp;

partial class Program
{
    static void Main(string[] args)
    {
        
    }
}

class Vehicle
{
    // Propiedades
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    
    // Métodos
    public void ShowInfo()
    {
        Console.WriteLine($"Este vehículo es un {Brand} {Model} del año {Year}");
    }
}