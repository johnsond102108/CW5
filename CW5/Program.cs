using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW5
{
    class Program
    {
        static void Main(string[] args)
        {
            Bear burr = new Grizzly();
            ToyBear toy = new TeddyBear();
            ToyBear adapt = new BearAdapter(burr);

            Console.WriteLine("Grizzly:");
            burr.maul();
            burr.hibernate();
            Console.WriteLine();

            Console.WriteLine("Teddy:");
            toy.hug();
            Console.WriteLine();

            Console.WriteLine("Adapter:");
            adapt.hug();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
