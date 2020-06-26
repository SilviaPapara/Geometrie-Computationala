using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrie___Seminar_4__problema_1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Problema 1 -  ecuația dreptei determinată de  cele 2 puncte - TERMINATA
             Console.WriteLine("PROBLEMA 1");

             int xa = int.Parse(Console.ReadLine());
             int ya = int.Parse(Console.ReadLine());
             Console.WriteLine("A(" + xa + "," + ya + ")");

             Console.WriteLine();

             int xb = int.Parse(Console.ReadLine());
             int yb = int.Parse(Console.ReadLine());
             Console.WriteLine("B(" + xb + "," + yb + ")");

             double panta = (double)(yb - ya) / (xb - xa);
             Console.WriteLine("panta este" + panta) ;

             Console.WriteLine("d:y-" + ya + "=" + panta + "(x-" + xa+")");

           

        }
    }
}
