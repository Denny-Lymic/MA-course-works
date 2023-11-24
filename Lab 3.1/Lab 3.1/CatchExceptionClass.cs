using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3._1
{
    class CatchExceptionClass
    {
        public void CatchExceptionMethod()
        {
            try
            {
                MyArray ma = new MyArray();

                // 3) replace second elevent of array by 0

                int[] arr = new int[4] { 1, 2, 8, 5 };
                int[]? arr2 = null;
                ma.Assign(arr, 4);

            }

            // 8) catch all other exceptions here
            /*catch (Exception ex)
            {
                // 9) print System.Exception properties:
                // HelpLink, Message, Source, StackTrace, TargetSite

                Console.WriteLine(ex.ToString());
                Console.WriteLine("------------");
                Console.WriteLine(ex.HelpLink);
                Console.WriteLine("------------");
                Console.WriteLine(ex.Message);
                Console.WriteLine("------------");
                Console.WriteLine(ex.Source);
                Console.WriteLine("------------");
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("------------");
                Console.WriteLine(ex.TargetSite);
                Console.WriteLine("------------");
            }*/

            // 10) add finally block, print some message
            // explain features of block finally
            finally
            {
                Console.WriteLine("This code will always run");
            }
        }
    }
}
