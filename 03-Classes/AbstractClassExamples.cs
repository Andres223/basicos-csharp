namespace HelloApp;

partial class Program
{
    static void AbstractClassExamples()
    {
        HomeApplience myWasher = new WashingMachine(){Brand = "LG"};
        HomeApplience myMicrowave = new Microwave(){Brand = "Samsung"};
        
        myWasher.TurnOn();
        myWasher.ShowBrand();
        
        myMicrowave.TurnOn();
        myMicrowave.ShowBrand();
    }
}

abstract class HomeApplience
{
    public string? Brand { get; set; }
    public abstract void TurnOn();
    public void ShowBrand()
    {
        Console.WriteLine($"La marca del electrodómestico es: {Brand}");
    }
}

class WashingMachine : HomeApplience
{
    public override void TurnOn()
    {
        Console.WriteLine("La lavadora a inicializado el ciclo de lavado");
    }
}

class Microwave : HomeApplience
{
    public override void TurnOn()
    {
        Console.WriteLine("El microondas está calentando la comida");
    }
}