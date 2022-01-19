using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Product pd= new Product();
            string OrderName = pd.GetProName();
            string ProductName = pd.GetOrdName();
            Console.WriteLine(ProductName + " belongs to " + OrderName);
        }
    }
}
