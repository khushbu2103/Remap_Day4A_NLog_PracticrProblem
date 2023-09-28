using NLog;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remap_Day4A_NLog_PracticrProblem
{
    internal class Addition
    {
        public static Logger log = LogManager.GetCurrentClassLogger();
        public static void Sum(int first, int second)
        {
            if(first <= 0 || second <= 0)
            {
                log.Error("It should not be negative number");
            }
            else
            {
                int sum = first + second;
                log.Info("Sum operation successful :" + sum);
            }
        }
    }
}
