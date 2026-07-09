namespace HelloApp._05_Files;

partial class Program
{
    static void FileExample()
    {
        var filePath = "./05-Files/Ejemplo.txt";
        var content = File.ReadAllText(filePath);

        var lines = File.ReadAllLines("./05-Files/Ejemplo.txt");
        foreach (var line in lines)
        {
            Console.WriteLine(line);
        }

        Console.WriteLine(lines[1]);
        
        // Copiando archivo y sobreescribiendo en caso de que exista
        File.Copy(filePath, "./05-Files/EjemploCopia.txt", overwrite:true);
        
        File.Delete("./05-Files/EjemploCopia.txt");
    }
}