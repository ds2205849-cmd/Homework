using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_ex._4___5_
{
    internal class Program
    {
        static void Main(string[] args)
        {
                       //ex.4

            string text = "   Уча C# и програмирам на C#.   ";
            Console.WriteLine(text);
            text = text.Trim();
            Console.WriteLine(text);

            Console.WriteLine(text.Contains("C#"));
            Console.WriteLine(text.Contains("Python"));
            Console.WriteLine(text.Contains("c#"));

            Console.WriteLine("========================");

            //ex.5

            Console.WriteLine(text.StartsWith("Уча"));
            Console.WriteLine(text.EndsWith("."));
            Console.WriteLine(text.EndsWith("C#"));
        }
    }
}
