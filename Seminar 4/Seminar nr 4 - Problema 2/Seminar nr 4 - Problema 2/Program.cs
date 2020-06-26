using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar_nr_4___Problema_2
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("PROBLEMA 2");

            int xm = int.Parse(Console.ReadLine());
            int ym = int.Parse(Console.ReadLine());
            Console.WriteLine("M(" + xm + "," + ym + ")");

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("d:" + a + "x" + "+" + b + "y" + "+" + c + "=0");

            double k = (double)Math.Sqrt(a * a + b * b);

            double t = Math.Abs(a * xm + b * ym + c);

            double p = (double)t / k;

            Console.WriteLine(" Distanta de la punctul M la  dreapta d este" + " " + p);


          
        }
    }
}
