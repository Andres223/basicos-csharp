namespace HelloApp._01_Bases;

partial class Program
{
    static void DataStructures()
    {
        CellPhone celular = new("Nokia 225", 2024);
        Console.WriteLine(celular);
    }
}

record CellPhone(string Model, int Year);