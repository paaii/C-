using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("anna vuosi ");
            int luku;
            luku = int.Parse(Console.ReadLine());
            if (luku % 4 == 0 ||luku % 400 == 0)
                Console.WriteLine("vuosi on karkausvuosi");
            Console.ReadLine();
        }
    }
}
