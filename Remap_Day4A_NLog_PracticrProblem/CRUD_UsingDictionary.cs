using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remap_Day4A_NLog_PracticrProblem
{
    internal class CRUD_UsingDictionary
    {
        public static void CRUD_OperationUsingDictionary()
        {
            //Creation
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(300, "khushi");
            dict.Add(200, "raj");
            Console.WriteLine("Enter a value to store in dictionary");
            string val = Console.ReadLine();
            dict.Add(500, val);
            Console.WriteLine();
            //Read operation
            foreach (int key in dict.Keys)
            {
                Console.WriteLine(dict[key]);
            }
            Console.WriteLine();
            //Update operation
            dict[300] = "shoaib";
            dict[500] = "shaik";
            foreach (int key in dict.Keys)
            {
                Console.WriteLine(dict[key]);
            }

            //Delite operation
            dict.Remove(500);
            foreach (int key in dict.Keys)
            {
                Console.WriteLine(dict[key]);
            }
        }
    }
}
