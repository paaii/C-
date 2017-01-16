using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("anna luku");
            int luku;
            luku = int.Parse(Console.ReadLine());
            if (luku < 18)
                Console.WriteLine("alaikainen");
            if (luku == 18 || luku <= 56)
                Console.WriteLine("aikuinen");
            else Console.WriteLine("seniori");
            Console.ReadLine();
        }
    }
}
