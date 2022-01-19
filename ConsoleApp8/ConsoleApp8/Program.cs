using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {

            Caluculator calc = new Caluculator();
            int result = calc.Add(8, 7);
            Class1 Cl = new Class1();
            int x = Cl.Sub(8, 7);
            Class2 C2 = new Class2();
            int y = C2.Mul(8, 7);
            Class3 C3 = new Class3();
            int z = C3.Div(8, 7);


            Console.WriteLine(y);
        }
    }
}
