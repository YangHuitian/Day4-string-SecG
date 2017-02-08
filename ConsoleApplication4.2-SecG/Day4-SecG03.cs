using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4._2_SecG
{
    class Day4_SecG03
    {
        public static void Main()
        {
            //G3 only upper the first char in each substring
            Console.Write("Upper 1st: ");
            string s = Console.ReadLine();
            string[] u = s.Split(' ');

            for (int i = 0; i <= u.Length - 1; i++)
            {
                //if (u.Length == 0) continue;
                Char firstc = Char.ToUpper((u[i])[0]);
                string rest = "";

                if (u.Length > 1)
                {
                    rest = u[i].Substring(1).ToLower();//make sure only Firstc upper
                }

                u[i] = firstc + rest;

            }
            Console.Write(u);
            //return String.Join(" ", words);
        }
    }
}
