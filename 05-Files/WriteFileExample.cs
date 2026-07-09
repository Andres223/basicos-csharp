namespace HelloApp._05_Files;

partial class Program
{
    static void WriteFileExample()
    {
        var filePath = "./05-Files/EjemploEscritura.txt";
        var content = "Podemos escribir en un archivo";
        var streamWriter = new StreamWriter(filePath, append: true);
        streamWriter.WriteLine(content);
        streamWriter.WriteLine($"La hora actual es: {DateTime.Now:HH:mm:ss}");
        streamWriter.WriteLine("Añadiendo nuevo contenido");
        streamWriter.Dispose();
    }
}