using System;

namespace 算法
{
    public class Code03_SelectionSort
    {
        static void selectionSort(int[] arr)
        {
            int N = arr.Length;
            if (N<2)
            {
                return;
            }
            else
            {


                for (int i = 0; i < N; i++)
                {
                    int minValueIndex = i;
                    for (int j = i + 1; j < N; j++)
                    {
                        minValueIndex = (arr[j] < arr[minValueIndex]) ? j : minValueIndex;
                    }

                    swap(arr, i, minValueIndex);
                }
            }
        }

        static void swap(int[] arr,int i,int j)
        {
            int tmp = arr[i];
            arr[i] = arr[j];
            arr[j] = tmp;
        }

        static void print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        
        /*static void Main()
        {
            int[] arr = {1,7, 5, 9, 8, 6, 3, 4, 7, 15, 11};
            print(arr);
            selectionSort(arr);
            print(arr);
        }*/
    }
}