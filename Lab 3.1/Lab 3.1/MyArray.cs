using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3._1
{
    class MyArray
    {
        int[] arr;

        public void Assign(int[]? arr, int size)
        {
            // 5) add block try (outside of existing block try)
            try
            {
                try
                {
                    this.arr = new int[size];

                    // 1) assign some value to cell of array arr, which index is out of range

                    for (int i = 0; i < this.arr.Length; i++)
                    {
                        this.arr[i] = arr[i];
                    }

                    for (int i = 0; i < arr.Length; i++)
                        this.arr[i] = arr[i] / arr[i];


                    // 7) use unchecked to assign result of operation 1000000000 * 100 
                    // to last cell of array

                    unchecked
                    {
                        arr[arr.Length - 1] = 1000000000 * 100;
                    }
                }
                // 2) catch exception index out of rage
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Index is out of range");
                }
                // 4) catch devision by 0 exception
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Division by 0");
                }
            }          
            // 6) add catch block for null reference exception of outside block try  
            // change the code to execute this block (any method of any class)
            catch (NullReferenceException)
            {
                Console.WriteLine("Null reference");
                throw new NullReferenceException();
            }
        }
    }
}
