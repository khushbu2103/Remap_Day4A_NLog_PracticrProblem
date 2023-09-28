using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remap_Day4A_NLog_PracticrProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                Console.WriteLine("Choose any program");
                Console.WriteLine("1. NLog\n" +
                    "2. CRUD operation using arraylist collection\n" +
                    "3. CRUD operation using dictionary collection");

                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Addition.Sum(3, 7);
                        break;
                    case 2:
                        CRUD_UsingArrayList.CRUD_OpereationUsingArrayList();
                        break;
                    case 3:
                        CRUD_UsingDictionary.CRUD_OperationUsingDictionary();
                        break;
                }
            Console.ReadLine();
        }
    }
}
