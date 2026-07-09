namespace HelloApp._05_Files;

partial class Program
{
    static void DirectoryExample()
    {
        var directoryPath = "./05-Files/";
        Directory.CreateDirectory($"{directoryPath}/DirEjemplo/OtherDir");
        
        if (Directory.Exists($"{directoryPath}/DirEjemplo/OtherDir"))
        {
            Console.WriteLine("Ya existe el directorio");
        }
        
        Directory.Delete($"{directoryPath}/DirEjemplo/OtherDir");
    }
}