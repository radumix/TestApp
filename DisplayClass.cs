using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    public class DisplayClass
    {
        private static string level = "level is a palindrome";
        private static string abba = "abba is a palindrome";
        private static string geek = "geek is NOT a palindrome";


        public string messages(string msg)
        {
            string resulut = "";
            switch (msg)
            {
                case "level":
                    resulut = level;
                    break;
                case "abba":
                    resulut = abba;
                    break;
                case "geek":
                    resulut = geek;
                    break;
            }

            return resulut;
        }

    }
}
