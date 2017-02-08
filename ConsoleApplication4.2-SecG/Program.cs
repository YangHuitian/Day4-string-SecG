using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4._2_SecG
{
    class Program
    {
        static void Main(string[] args)
        {
            //G1 find vowels in phrase
            Console.Write("Your phrase: ");
            string phrase = Console.ReadLine().ToUpper();
            string[] nospace = phrase.Split(' ');
            int a = 0;
            int e = 0;
            int i = 0;
            int o = 0;
            int u = 0;
            for (int pn = 0; pn <= nospace.Length - 1; pn++)
            {
                for (int wn = 0; wn <= nospace[pn].Length - 1; wn++)
                {
                    string n = nospace[pn].Substring(wn, 1);
                    if (n == "A")
                        a += 1;
                    else if (n == "E")
                        e += 1;
                    else if (n == "I")
                        i += 1;
                    else if (n == "O")
                        o += 1;
                    else if (n == "U")
                        u += 1;
                }
            }
            Console.WriteLine("Total vowels: {0}", a+e+i+o+u);
            Console.WriteLine("A: {0}", a);
            Console.WriteLine("E: {0}", e);
            Console.WriteLine("I: {0}", i);
            Console.WriteLine("O: {0}", o);
            Console.WriteLine("U: {0}", u);
        }
    }
}
