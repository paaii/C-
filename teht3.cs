using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("anna kolme lukua");
            int luku1, luku2, luku3;
            luku1 = int.Parse(Console.ReadLine());
            luku2 = int.Parse(Console.ReadLine());
            luku3 = int.Parse(Console.ReadLine());
            Console.WriteLine("summa " + (luku1 + luku2 + luku3) + " keskiarvo " + ((luku1 + luku2 + luku3)/3));
            Console.ReadLine();
        }
    }
}
