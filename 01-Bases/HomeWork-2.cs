using System.Globalization;

partial class Program
{
  static void DaysOfLifes()
  {
    DateTime birthdate = new (2003, 11, 18);
    TimeSpan difference = DateTime.Now - birthdate;
    Console.WriteLine($"Has vivido {difference.Days} días.");
  }
  
  static void DayUntilNextBirthday()
  {
    Console.Write("Introduce tu fecha de nacimiento (dd/mm/aaaa): ");
    string birthdateString = Console.ReadLine()!;
    
    // parsear la fecha en string a fecha
    DateTime birthDate = DateTime.ParseExact(birthdateString, "dd/MM/yyyy", CultureInfo.InvariantCulture);
    
    DateTime currentDate = DateTime.Now.Date;
    
    DateTime nextBirthDay = new (currentDate.Year, birthDate.Month, birthDate.Day);

    if (nextBirthDay < currentDate)
    {
      nextBirthDay = nextBirthDay.AddYears(1);
    }

    int dayRemaining = (nextBirthDay - currentDate).Days;
    Console.WriteLine($"Faltan {dayRemaining} para tu próximo cumpleaños");
  }
}