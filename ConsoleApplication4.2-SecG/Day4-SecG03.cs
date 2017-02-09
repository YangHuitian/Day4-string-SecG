using System;

namespace ConsoleApplication4._2_SecG
{
    class Day4_SecG03
    {
        public static void Main()
        {
            //G3 
            //only upper the first char in each substring
            Console.Write("Upper 1st: ");
            string s = Console.ReadLine();
            string[] u = s.Split(' ');

            for (int i = 0; i <= u.Length - 1; i++)
            {
                //if (u.Length == 0) continue;c
                Char firstc = Char.ToUpper((u[i])[0]);// not learnt : //Char firstc = Char.ToUpper(u[i])[0]),not change the rest
                string rest = "";

                if (u.Length > 1)
                {
                    rest = u[i].Substring(1).ToLower();//make sure only Firstc upper
                }

                u[i] = firstc + rest;

            }

            Console.WriteLine(String.Join(" ", u));// not learnt : //String.Join(" ", u)
        }
    }
}
