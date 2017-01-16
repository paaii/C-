using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtava5
{
    class Program
    {
        static void Main(string[] args)
        {
            int ts, s, m, h;

            Console.Write("Anna sekunnit > ");
            ts = int.Parse(Console.ReadLine());
            s = ts % 60;
            m = (ts / 60)/60;
            h = ((ts / 60)/60)/24;
            
            Console.WriteLine(h + " tunti, " + m + " minuuttia, " + s + " sekuntia.");
            Console.ReadLine();
            
        }
    }
}
