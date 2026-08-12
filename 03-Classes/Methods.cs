namespace HelloApp;

partial class Program
{
    static void Methods()
    {   
        // Un constructor
        Car sportsCar = new Car("Ferrari", 2020);
        Console.WriteLine(sportsCar.ShowInfo());
        
        // Sintaxis simplificada
        Car collectionCar = new Car { Model="Cadillac", Year=2020 };
        Console.WriteLine(collectionCar.ShowInfo());
        
        // Lista de objetos
        Console.WriteLine("Listado de autómoviles:");
        List<Car> cars = new()
        {
            new Car(){ Model="Duster", Year=2021},
            new Car(){ Model="Stepway", Year=2019},
            new Car(){ Model="Captur", Year=2000},
        };
        foreach (var car in cars)
        {
            Console.WriteLine(car.ShowInfo());
        }
    } 
}

class Car
{
    public string? Model { get; set; }
    public int? Year { get; set; }

    // Constructor con parametros
    public Car(string model, int? year)
    {
        Model = model;
        Year = year;
    }

    // Constructor por defecto
    public Car()
    {
        
    }
    
    // Destructor ()
    ~Car()
    {
        Console.WriteLine("Destructor llamado. Recurso liberado");
    }
        
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
    
    // Recibe un argumento y lo imprime
    public void ShowMessage(string message) => Console.WriteLine(message);
    
    // método estático
    public static void GeneralInfo()
    {
        Console.WriteLine("El autómovil es uno de los transportes más utilizados");
    }
}