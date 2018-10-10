using System;

namespace BoringVector
{
    internal class Program
    {
        private static void Main()
        {
            Vector v = new Vector(1, 2);
            Vector k = new Vector(3, 5);
            v.Add(k);
            Console.WriteLine(v.ToString());
            v.Scale(5);
            Console.WriteLine(v.ToString());

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
