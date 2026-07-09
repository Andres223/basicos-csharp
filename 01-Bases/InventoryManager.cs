partial class Program
{
  static void InventoryManager()
  {
    string[] products = ["Monitor", "Mouse", "Teclado"];
    int[] stock = [1000, 25, 30];
    double[] prices = [250.50, 20.50, 45.00];

    Console.WriteLine("Inventario de Productos");
    Console.WriteLine("-----------------------");
    
    for(int i=0; i<products.Length; i++)
    {
      Console.WriteLine($"Producto: {products[i]}, stock: {stock[i]}, precio: {prices[i]}");
    }

    Console.Write("\nIngrese el producto que desea comprar: ");
    string? searchedProduct = Console.ReadLine();
    Console.Write("Ingrese la cantidad que desea comprar: ");
    int quantity = int.Parse(Console.ReadLine()!);

    for (int i = 0; i < products.Length; i++)
    {
      if (products[i].Equals(searchedProduct, StringComparison.OrdinalIgnoreCase))
      {
        if (quantity <= stock[i])
        {
          double total = quantity * prices[i];
          Console.WriteLine($"Compra exitosa: {total}");
        }
        else
        {
          Console.WriteLine("No hay suficiente stock");
        }
      }
    }
  }
}