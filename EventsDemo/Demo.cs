using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDemo
{
    public delegate void DelEventHandler();
    internal class Demo
    {
        public static event DelEventHandler add;
        public static void InvokeAdd()
        {
            Demo.add.Invoke();
        }
        public static void India()
        {
            Console.WriteLine("India");
        }
        public static void USA()
        {
            Console.WriteLine("USA");
        }
        public static void England()
        {
            Console.WriteLine("England");
        }
    }



}

