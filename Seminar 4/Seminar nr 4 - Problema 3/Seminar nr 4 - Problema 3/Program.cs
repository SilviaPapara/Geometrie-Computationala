using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar_nr_4___Problema_3
{
    class Program
    {
        static void Main(string[] args)
        {



             Console.WriteLine("PROBLEMA 3");

             int xa = int.Parse(Console.ReadLine());
             int ya = int.Parse(Console.ReadLine());
             Console.WriteLine("A(" + xa + "," + ya + ")");


             int xb = int.Parse(Console.ReadLine());
             int yb = int.Parse(Console.ReadLine());
             Console.WriteLine("B(" + xb + "," + yb + ")");

             int xc = int.Parse(Console.ReadLine());
             int yc = int.Parse(Console.ReadLine());
             Console.WriteLine("C(" + xc + "," + yc + ")");

             Console.WriteLine("Folosim aplicatiile determinantului");
             int aria = Math.Abs((xa * yb) +( xb * yc) +( ya * xc) - (yb * xc) - (xa * yc) - (xb * ya));
             //float aria1 = (float)aria / 2;
             Console.WriteLine("Aria este" + " " + aria);

           
        }
    }
}
