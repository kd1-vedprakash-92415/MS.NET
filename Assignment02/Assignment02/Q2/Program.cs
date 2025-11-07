using Q_2;

namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Product p = new Product(101, "Laptop", 39999.99);

            Console.WriteLine("Entr Product Id :");
            int productId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Product Name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Product Price :");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Brand Name :  ");
            string brand = Console.ReadLine();
            Console.WriteLine("Enter Warentty Year : ");
            int year = Convert.ToInt32(Console.ReadLine());


            Product p = new Electronics_Product(productId,name,price,brand,year);
            p.Display();
            


        }
    }
}
