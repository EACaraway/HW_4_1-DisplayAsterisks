using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkWeek4Problem1_DisplayAsterisks
{
    class Program
    {   // Evan Caraway, Srinivas Reddy Doma, Kipack Jeong
        static void Main(string[] args)
        {
            string[] stores = { "store 1", "store 2", "store 3", "store 4", "store 5" }; // create variable stores for an array of stores.
            int[] storeSales = new int[5]; // create variable storeSales to hold an array of store sale entries.

            for(int index = 0; index < 5; index++)
            {
                Console.Write($"Enter today's sales for {stores[index]}: "); // ask for store sales.
                int.TryParse(Console.ReadLine(), out int x); // try parse user input to int and save as "x"
                storeSales[index] = x; // save the value of "x" to storeSales array.
            }
            
            Console.WriteLine();

            var salesBarChart = new StringBuilder(); // create variable salesBarChart to hold appends from stringbuilder
            salesBarChart.AppendLine("SALES BAR CHART"); // appends text to salesBarChart
            salesBarChart.AppendLine("(Each * = $100)");

            for(int index = 0; index < 5; index++)
            {
                salesBarChart.AppendLine($"{stores[index]}: {DisplayAsterisks(storeSales[index] / 100)}");
            }

            Console.WriteLine(salesBarChart);

        }
        /// <summary>
        /// Returns a string of asterisks equal to "num"
        /// </summary>
        /// <param name="num"></param>
        /// <returns>string of asterisks</returns>
        static string DisplayAsterisks(int num)
        {
            var asterisks = new StringBuilder(); // create variable asterisks to hold appends from stringbuilder
            for (int i =0; i < num; i++)
            {
                asterisks.Append("*"); // appends text to variable asterisks
            }
            return asterisks.ToString();
        }
    }
}
