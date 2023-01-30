namespace EventsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello World!");
            Demo.add += new DelEventHandler(Demo.India);
            Demo.add += new DelEventHandler(Demo.USA);
            Demo.add += new DelEventHandler(Demo.England);
            //Demo.InvokeAdd();
            Console.WriteLine("************Event Handling****************");
            EventHandling.ImplementEvent();
            Console.ReadKey();
        }
    }
}