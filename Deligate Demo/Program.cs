using static Deligate_Demo.Demo;

namespace Deligate_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine("Delegate Demo");
            operation obj = new operation(Demo.Addition);
            Console.WriteLine("Addition is = {0}", obj(23, 27));
            //MulticastDelegate.ImplementDelegate();
            Console.ReadKey();
        }
    }
}