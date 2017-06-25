using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestCommonString
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowCount = 0;
            
            if (args == null || args.Length == 0)
            {
                Console.WriteLine("How many rows you can to enter?");
                rowCount = int.Parse(Console.ReadLine());
                args = new string[rowCount];
                for (int i = 0; i < rowCount; i++)
                {
                    Console.WriteLine($"Enter Row number {i+1} - ");
                    args[i] = Console.ReadLine();
                }
            }            
            var obj = new Algo();
            var commonText = obj.Run(args);

            Console.WriteLine($"Longest Common text in {args.Length} lines is = '{commonText}'");
            Console.ReadLine();
        }
    }
}
