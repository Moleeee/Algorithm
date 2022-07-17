using System;

namespace 算法.Class03;

public class Code_04_BSAwesome
{
    public static int oneMinIndex(int[] arr)
    {
        if (arr == null || arr.Length == 0)
        {
            return -1;
        }

        int N = arr.Length;
        if (N == -1)
        {
            return 0;
        }

        if (arr[0] < arr[1])
        {
            return 0;
        }

        if (arr[N - 1] < arr[N - 2])
        {
            return N - 1;
        }

        int L = 0;
        int a=Rando
        int R = N - 1;
        while (L< R - 1)
        {
            int mid = (L + R) / 2;
            if (arr[mid] < arr[mid - 1] && arr[mid] < arr[mid + 1])
            {
                return mid;
            }
            else
            {
                if (arr[mid] > arr[mid - 1])
                {
                    R = mid - 1;
                }
                else
                {
                    L = mid + 1;
                }
            }
            
        }

    }
}