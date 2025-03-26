using System;
using System.Data;

namespace Example
{
       
    public class Test
    {
        static void swap( int a,  int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void swap(ref int a,ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void sort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        //int temp = arr[i];
                        //arr[i] = arr[j];
                        //arr[j] = temp;
                        //swap(arr[i], arr[j]);  //   ko swap đc
                        swap(ref arr[i], ref arr[j]); // swap đc
                    }
                }
            }
        }

        static void Main(string[] args)
        {

            int[] arr = { 3, 2, 1, 5, 4, 9, 6, 8, 10 };
            sort(arr);
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }

        }
    }



}

