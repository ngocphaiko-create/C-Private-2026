using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int hp = int.Parse(Console.ReadLine());
            double speed = double.Parse(Console.ReadLine());
            char rank = char.Parse(Console.ReadLine());
            bool live = hp > 0;
            Console.WriteLine("Ten: " + name);
            Console.WriteLine("HP: " + hp);
            Console.WriteLine("Toc do:" + speed);
            Console.WriteLine("Hang: " + rank);
            Console.WriteLine("Con song: " + live);
        }
    }
}
