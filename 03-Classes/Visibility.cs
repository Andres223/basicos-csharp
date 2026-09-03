namespace HelloApp;

partial class Program
{
    static void Visibility()
    {   
        Sith sith = new Sith();
        sith.PowerLevel = 4000;
        sith.LightsaberColor = "red";
        sith.UseForce();
    }
}

interface IForceUser
{
    int PowerLevel { get; set; }
    string LightsaberColor { get; set; }
    
    void UseForce();
}

class Jedi: IForceUser
{
    public string PublicField = "Soy un Jedi y mi poder es conocido";
    private string PrivateField = "Mis pensamientos más profundos son privados";
    protected string ProtectedField = "El lado oscuro no debe conocer mis secretos";
    public int PowerLevel { get; set; }
    public string? LightsaberColor { get; set; }

    public void UseForce()
    {
        Console.WriteLine($"Soy un jedi con un sable de luz {LightsaberColor} y mi nivel de poder es: {PowerLevel}");
    }
    
    private void Meditate()
    {
        Console.WriteLine("Estoy en profunda meditación con la fuerza");
    }
    
    protected void Train()
    {
        Console.WriteLine("Estoy entrenando para convertirme en el mejor jedi.");
    }
    
    public void RevealSecret()
    {
        Console.WriteLine(PrivateField);
        Console.WriteLine(ProtectedField);
    }
}

class Sith : Jedi, IForceUser
{
    public new void UseForce()
    {
        Console.WriteLine($"Soy un Sith con un sable de luz {LightsaberColor} y mi nivel de poder es: {PowerLevel}");
    }

    public void ShowProtected()
    {
        Console.WriteLine(ProtectedField);
        Train();
    }
}