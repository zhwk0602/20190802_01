using System;
using System.Collections.Generic;
using System.Text;

namespace _20190802_01
{
   public static class StaticClass
    {
        public static void AA()
        {
            Console.WriteLine("this is static method");
        }
        public static string Append(this string s)
        {
            return s + "pppp";
        }
    }
}
