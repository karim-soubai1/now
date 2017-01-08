using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 1f / 3;
            double b = 1d / 3;
            decimal c = 1m / 3;
            Console.WriteLine("a=" + a);
            Console.WriteLine("b=" + b);
            Console.WriteLine("c=" + c);
            


            float m = float.MinValue;
            float x = float.MaxValue;
            Console.WriteLine("max:{0} \n min:{1}",m,x);
            Console.ReadLine();
        }
    }
}
