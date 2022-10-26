using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegues
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tableau = new int[] { 4, 1, 8, 6, 5, 0 };
            new TrieurDeTableau().DemoTri1(tableau);
            Console.WriteLine("\n------------------------------------------------\n");
            new TrieurDeTableau().DemoTri2(tableau);
            Console.WriteLine("\n------------------------------------------------\n");
            new TrieurDeTableau().demotri3(tableau);
            Console.WriteLine("\n------------------------------------------------\n");
            new TrieurDeTableau().demotri4(tableau);
            Console.WriteLine("\n------------------------------------------------\n");
            new TrieurDeTableau().demotri5(tableau);
            Console.ReadKey();
        }
    }
}
