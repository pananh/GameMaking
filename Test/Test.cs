using System;
using System.Data;

namespace Example
{
   
    public class StopWatch
    {
        private DateTime startTime;
        private DateTime endTime;

        public void Start()
        {
            startTime = DateTime.Now;
        }

        public void Stop()
        {
            endTime = DateTime.Now;
        }

        public double GetElapsedTime()
        {
            TimeSpan timeSpan = endTime - startTime;
            return timeSpan.TotalMilliseconds;
        }
    }

    public class Test
    {
        static void MakeRandom (int[] array)
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next();
            }

        }

        static void SelectionSorting(int[] array)
        {
            for (int i = 0; i < array.Length -1; i++ )
            {
                int minIndex = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }
                if (!(minIndex == i))
                {
                    int temp = array[i];
                    array[i] = array[minIndex];
                    array[minIndex] = temp;
                }

            }

        }

        static void MergeArr(int[] array, int st, int mid, int end)
        {
            int n1 = mid - st + 1;
            int n2 = end - mid;
            int[] leftArr = new int[n1];
            int[] rightArr = new int[n2];
            
            Array.Copy(array, st, leftArr, 0, n1);
            Array.Copy(array, mid + 1, rightArr, 0, n2);

            int i = 0, j = 0;
            int k = st;
            while (i < n1 && j < n2)
            {
                if (leftArr[i] <= rightArr[j])
                {
                    array[k] = leftArr[i];
                    i++;
                }
                else
                {
                    array[k] = rightArr[j];
                    j++;
                }
                k++;
            }
            while (i < n1)
            {
                array[k] = leftArr[i];
                i++;
                k++;
            }
            while (j < n2)
            {
                array[k] = rightArr[j];
                j++;
                k++;
            }
        }

        static void MergeSorting(int[] array, int st, int end)
        {
            if (st < end)
            {
                int mid = (st + end) / 2;
                MergeSorting(array, st, mid);
                MergeSorting(array, mid + 1, end);
                MergeArr(array, st, mid, end);
            }
        }

       static void QuickSort(int[] array, int st, int end)
        {
            if (st < end)
            {
                int pivot = array[end];
                int i = st - 1;
                for (int j = st; j < end; j++)
                {
                    if (array[j] < pivot)
                    {
                        i++;
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
                int temp1 = array[i + 1];
                array[i + 1] = array[end];
                array[end] = temp1;
                int pivotIndex = i + 1;
                QuickSort(array, st, pivotIndex - 1);
                QuickSort(array, pivotIndex + 1, end);
            }
        }

        public static void TestOverMemory(int i)
        {
            if (i < 19284) { TestOverMemory(i + 1); }   // Number of recursive calls is 19284
            else { return; }

        }

        public static void Main(string[] args)
        {
            //TestOverMemory(0);

            int nMax = 5000;
            int[] array1 = new int[nMax];
            MakeRandom(array1);
            
            //Console.WriteLine("Before sorting:");
            //for (int i = 0; i < nMax; i++)
            //{
            //    Console.Write(array1[i] + " ");
            //}
            //Console.WriteLine();

            int[] array2 = new int[nMax];
            Array.Copy(array1, array2, nMax);
            int[] array3 = new int[nMax];
            Array.Copy(array1, array3, nMax);
            int[] array4 = new int[nMax];
            Array.Copy(array1, array4, nMax);

            Console.WriteLine("Nmax = " + nMax);

            StopWatch TuanAnhWatch = new StopWatch();
            if (nMax > 150000) { Console.WriteLine("Nmax > 150000. Selection Sort is too slow. Dont run"); }
            else
            {
                TuanAnhWatch.Start();
                SelectionSorting(array1);
                TuanAnhWatch.Stop();
                Console.WriteLine("Time elapsed Slection Sort: " + TuanAnhWatch.GetElapsedTime() + "ms");
            }

            TuanAnhWatch.Start();
            MergeSorting(array2, 0, nMax - 1);
            TuanAnhWatch.Stop();
            Console.WriteLine("Time elapsed Merge Sort: " + TuanAnhWatch.GetElapsedTime() + "ms");

            TuanAnhWatch.Start();
            QuickSort(array3, 0, nMax - 1);
            TuanAnhWatch.Stop();
            Console.WriteLine("Time elapsed Quick Sort: " + TuanAnhWatch.GetElapsedTime() + "ms");

            TuanAnhWatch.Start();
            Array.Sort(array4);
            TuanAnhWatch.Stop();
            Console.WriteLine("Time elapsed procedure Array.Sort: " + TuanAnhWatch.GetElapsedTime() + "ms");


            //Console.WriteLine("After sorting:");
            //for (int i = 0; i < nMax; i++)
            //{
            //    Console.Write(array4[i] + " ");
            //}


        }
    }

}

