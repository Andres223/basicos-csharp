namespace HelloApp;

partial class Program
{
    static void ProductSalesDemo()
    {
        
    }
    
    class Product
    {
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

        public Product(string name, decimal price, int stock)
        {
            Name = name;
            Price = price;
            Stock = stock;
        }
        
        public void ShowInfo()
        {
            Console.WriteLine($"Producto: {Name}, Precio: {Price}, Stock: {Stock}");
        }
        
        public bool Sell(int quantity)
        {
            if (quantity <= Stock)
            {
                Stock -= quantity;
                Console.WriteLine($"Venta realizada: {quantity} unidades de {Name}");
                return true;
            }

            Console.WriteLine($"Stock insuficiente para {Name}");
            return false;
        }
    }
    
    class Inventory
    {
        
    }
}