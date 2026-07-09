namespace HelloApp._01_Bases;

partial class Program
{
    static void ListDictionary()
    {
        // Listas
        List<string> names = new List<string> { "Ana", "Carlos", "Juan" };

        names.Add("Lucia");
        Console.WriteLine($"Total de nombres: {names.Count}");

        foreach (var name in names)
        {
            Console.WriteLine(name);
        }

        names.Remove("Ana");
        bool isPresent = names.Contains("Ana");
        Console.WriteLine($"Ana está en la lista? {isPresent}");



        // Dictionary
        Console.WriteLine("\nDictionary");
        Dictionary<int, string> students = new Dictionary<int, string>
        {
            {1, "Carlos"},
            {2, "Felipe"},
            {3, "Elena"},
        };

        Console.WriteLine(students[1]);

        foreach (var student in students)
        {
            Console.WriteLine(student);
            Console.WriteLine($"ID: {student.Key}, Nombre: {student.Value}");
        }
    }
}