partial class Program
{
  static void ShowTime()
  {
    // Obtener fecha y hora actuales
    DateTime now = DateTime.Now;
    DateTime today = DateTime.Today;
    DateTime noeWeekAgo = now.AddDays(-4);
    DateTime customDate = new(2025, 03, 02);
    DayOfWeek weekDay = now.DayOfWeek;
    
    Console.WriteLine($"Fecha y hora actual -> {now}");
    Console.WriteLine($"Fecha y hora de hoy -> {today}");
    Console.WriteLine($"Fecha de un/os días pasados -> {noeWeekAgo}");
    Console.WriteLine($"Fecha creada -> {customDate}");
    Console.WriteLine($"Día de la semana -> {weekDay}");
  }
}