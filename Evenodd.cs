using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Programming_Problem_Set_1.Model
{
    internal class Evenodd
    {
        public void Even_odd(int[] arr)

        {
            int i;
            int j = 0;
            int k = 0;
            //int [] arrN= arr;
            int[] arr_one = new int[arr.Length];
            int[] arr_two = new int[arr.Length];

            for (i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    arr_one[j] = arr[i];
                    j++;

                }

                else
                {
                    arr_two[k] = arr[i];
                    k++;
                    //Console.WriteLine($"The Odd elements are: {arr[i]}");

                }


            }
            Console.Write("The Even elements are: \n");
            //foreach(int l in arr_one)

           for (i = 0; i < j; i++)

            {
                Console.Write("{0}", arr_one[i] );
                //Console.WriteLine(i);
                //Console.WriteLine($"The odd elements are: {arr_one[i]}");
            }

            Console.Write("\nThe odd elements are:");
            //foreach(int m in arr_two)
           for (i = 0; i < k; i++)
            {

                // Console.WriteLine(j);
                Console.Write("{0}", arr_two[i] );
               // Console.WriteLine($"The odd elements are: {arr_two[i]}");
            }
            Console.Write("\n\n");
        }
    }
}