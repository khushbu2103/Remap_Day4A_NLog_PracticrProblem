using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remap_Day4A_NLog_PracticrProblem
{
    internal class CRUD_UsingArrayList
    {
        public static void CRUD_OpereationUsingArrayList()
        {
            ArrayList arrlist = new ArrayList(); //Creation

            arrlist.Add("khushi");
            arrlist.Add(58);
            arrlist.Add(58);

            //Read operation
            foreach (var elements in arrlist)
            {
                Console.WriteLine(elements);
            }
            Console.WriteLine();
            //Update operation
            arrlist[0] = 45;
            arrlist[1] = true;
            arrlist[2] = 45;
            foreach (var elements in arrlist)
            {
                Console.WriteLine(elements);
            }

            Console.WriteLine();
            //Delete operation
            arrlist.Remove(45);
            foreach (var elements in arrlist)
            {
                Console.WriteLine(elements);
            }
        }
    }
}
