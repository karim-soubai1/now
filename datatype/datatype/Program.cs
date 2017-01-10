using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datatype
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = char.MinValue;
            int b = char.MaxValue;

            char c = 'k';
            int  d = 'k';
            char e = Convert.ToChar(d);



            Console.WriteLine("max char variabal = {0} \nmin char varibal = {1}\nle caracter est:{2}\nle nombre de caracter est:{3}\nle caracter={4}"
                ,b,a,c,d,e);


            string f = "my string  valio";
            bool g=true;
            Console.WriteLine("{0}\nmy booling vribal is:{1}", f,g);


            Console.ReadLine();


        }
    }
}
