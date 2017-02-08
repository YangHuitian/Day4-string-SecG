using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4._2_SecG
{
    class Day4_SecG2
    {
        public static void Main()
        {
            //G2 (a)(b) test if it's a palindrome
            Console.Write("Enter: ");
            string s = Console.ReadLine().ToUpper();
            //char[] p = new char[] {'.',','}; //no suitable for all , .
            s = s.Replace(" ","").Replace(",", "").Replace(".", "");
            bool ispali = true;
            
            for (int i = 0; i <= s.Length - 1; i++)
            {
                if (s[i] != s[s.Length - (i+1)])//count from back
                {
                    ispali = false;
                    break;
                }
            }

            if (ispali == false)
                Console.WriteLine("It's not a palindrome.");
            else
                Console.WriteLine("It's a palindrome.");

        }
    }
}
