using System;

namespace 算法
{
    public class Code05_insertSort
    {
        static void insertSort01(int[] arr)
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
                    int newNumIndex = i;
                    while (newNumIndex>=1 && arr[newNumIndex-1]>arr[newNumIndex])
                    {
                        swap(arr,newNumIndex,newNumIndex-1);
                        newNumIndex--;
                    }
                }
            }
        }

        static void insertSort02(int[] arr)
        {
            int N = arr.Length;
            if (N<2)
            {
                return;
            }
            else
            {
                for (int i = 1; i < N; i++)
                {
                    for (int j = i-1; j>=0 && arr[j]>arr[j+1] ; j--)
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
            insertSort02(arr);
            print(arr);
        }*/
    }
}