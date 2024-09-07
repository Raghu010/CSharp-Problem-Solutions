using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Security.Permissions;


namespace Example
{
    class MainClass
    {
        public static string FirstReverse(string str)
        {
            string[] strSplit = str.Split(' ');
            string Str = "";
            for (int i = strSplit.Length - 1; i >= 0; i--) 
            {
                for(int j = strSplit[i].Length - 1; j >= 0; j--)
                {
                    Str += strSplit[i][j].ToString();
                }
                Str = Str + " ";
            }
            return Str;
        }

        static void Main()
        {
            Console.WriteLine(FirstReverse(Console.ReadLine()));
            Console.ReadKey();
        }
    }
}
