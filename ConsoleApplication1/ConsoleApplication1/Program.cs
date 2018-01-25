using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
       
            //Rotate array to the right of a given pivot
        public static void Rotate(int[] x, int pivot)
        {
            if (pivot < 0 || x == null)
                throw new Exception("Invalid argument");

            pivot = pivot % x.Length;

            //Rotate first half
            x = RotateSub(x, 0, pivot - 1);

            //Rotate second half
            x = RotateSub(x, pivot, x.Length - 1);

            //Rotate all
            // x = RotateSub(x, 0, x.Length - 1);
            if(x.Length>0)
            {
                for (int i = 0; i < x.Length; i++)
                {
                    Console.WriteLine(x[i]);
                }
            }
            
            // return x;
        }

         private static int[] RotateSub(int[] x, int start, int end)
        {
            while (start < end)
            {
                int temp = x[start];
                x[start] = x[end];
                x[end] = temp;
                start++;
                end--;
            }
            return x;
        }

        static void Main(string[] args)
         {
             int[] arr = new int[5];
             int pivot = 0;
             int[] returnValue=new int[5];
             Console.WriteLine("enter the 5 array elements");
            for(int i=0;i<5;i++)
            {
                string str = Console.ReadLine();
                arr[i]= Convert.ToInt32(str);
            }
            Console.WriteLine("enter the pivot element");
            pivot = Console.Read();
            Rotate(arr, pivot);
            
            Console.ReadKey();


         }
        }


    }
