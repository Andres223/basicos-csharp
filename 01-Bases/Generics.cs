namespace HelloApp._01_Bases;

partial class Program
{
    static void Generics()
    {
        string[] names = { "Juan", "Luis", "Diana" };
        int[] numbers = [1, 2, 3];

        Console.WriteLine($"Tamaño del arreglo númerico: {GetArrayLength(numbers)}");
        Console.WriteLine($"Tamaño del arreglo nombres: {GetArrayLength(names)}");

        Box<int> numberBox = new() { Content = 50 };
        Box<string> stringBox = new() { Content = "Ahora soy texto." };
        numberBox.Show();
        stringBox.Show();
    }

    static int GetArrayLength<T>(T[] array)
    {
        return array.Length;
    }
}

class Box<T>
{
    public T? Content { get; set; }

    public void Show()
    {
        Console.WriteLine($"Contenido: {Content}");
    }
}