namespace HelloApp;

partial class Program
{
    static void Methods()
    {
        
    }
}

class Car
{
    public string? Model { get; set; }
    public int? Year { get; set; }
    
    // No devuelve nada, asigna valor a una propiedad
    public void ChangeModel(string newModel)
    {
        Model = newModel;
    }
    
    // No recibe nada, muestra información
    public string ShowInfo()
    {
        return $"Automóvil: {Model}, Año: {Year}";
    }
    
    // No recibe nada y devuelve información
    public void ShowMessage() => Console.WriteLine("Este es un automóvil");
    public void ShowMessage(string message) => Console.WriteLine(message);
}