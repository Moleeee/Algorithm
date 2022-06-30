using System;

namespace 算法
{
    public class Code04_bubbleSort
    {
        static void bubbleSort(int[] arr)
        {
            int N = arr.Length;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N-1-i; j++)
                {
                    if (arr[j]>arr[j+1])
                    {
                        swap(arr,j,j+1);
                    }
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
            bubbleSort(arr);
            print(arr);
        }*/
    }
}