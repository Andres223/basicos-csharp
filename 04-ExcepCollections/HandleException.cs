namespace HelloApp;

partial class Program
{   
    static void HandleException()
    {
        try
        {
            ValidateAge(18);
        }
        catch(Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.ResetColor();
            Console.WriteLine("Esto siempre se ejecutará...");    
        }
    }
    
    static void ValidateAge(int age)
    {
        if (age < 18)
        {
            throw new ArgumentException("La edad debe ser mayor a 18");
        }
        else
        {
            Console.WriteLine("Eres mayor!!");
        }
    }
}