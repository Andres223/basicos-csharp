namespace HelloApp._05_Files;

partial class Program
{
    static void PathExample()
    {
        var filePath = "./05-Files/Ejemplo.txt";
        
        // Extraer el nombre de un archivo
        var fileName = Path.GetFileName(filePath);
        
        // Extraer la extensión de un archivo
        var fileExtension = Path.GetExtension(filePath);
        
        // Extraer nomnbre del directorio
        var directoryName = Path.GetDirectoryName(filePath);
        
        // Combinar rutas
        var combinedPath = Path.Combine("C:", "User", "Documents", "Ejemplo.txt");
        
        // Obtener ruta completa de un archivo
        var fullFilePath = Path.GetFullPath(filePath);

        Console.WriteLine($"Nombre del archivo: {fileName}");
        Console.WriteLine($"Extensión del archivo: {fileExtension}");
        Console.WriteLine($"Nombre del directorio del archivo: {directoryName}");
        Console.WriteLine($"Ruta combinada: {combinedPath}");
        Console.WriteLine($"Ruta completa del archivo: {fullFilePath}");
    }
}