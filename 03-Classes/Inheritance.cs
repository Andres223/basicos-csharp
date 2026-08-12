namespace HelloApp;

partial class Program
{
    public static void Inheritance()
    {
        HowgartsStudent student = new HowgartsStudent(){Name = "Harry Potter", House = "Gryffindor"};
        
        HowgartsProfessor professor = new HowgartsProfessor(){Name = "Severus Snape", Subject = "Pociones"};
        
        student.Greet();
        student.ShowHouse();
        
        professor.Greet();
        professor.MySubject();
    }
}

class Character
{
    public string? Name { get; set; }
    
    public virtual void Greet()
    {
        Console.WriteLine($"Hola, soy {Name}");
    }
}

class HowgartsStudent: Character
{
    public string? House { get; set; }

    public override void Greet()
    {
        Console.WriteLine($"Hola, soy {Name} y soy estudiante.");
    }
    
    public void ShowHouse()
    {
        Console.WriteLine($"Pertenezco a la casa {House} en Hogwarts");
    }
}

class HowgartsProfessor: Character
{
    public string? Subject { get; set; }
    
    public override void Greet()
    {
        Console.WriteLine($"Hola, soy {Name} y soy profesor.");
    }
    
    public void MySubject()
    {
        Console.WriteLine($"Enseño {Subject} en Hogwarts");
    }
}