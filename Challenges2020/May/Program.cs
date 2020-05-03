using System;
using System.Collections.Generic;

namespace May
{
    class Program
    {
        static void Main(string[] args)
        {
            string J = "";
            string S = "abcdbaghj";

            bool c = Problem_3.CanConstruct(J, S);

            Console.WriteLine(c);
        }
    }
}
