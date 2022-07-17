using System;
using System.Runtime.InteropServices;

namespace 算法.Class03
{
    public class Code_01_BSExist
    {
        public static bool Find(int[] arr, int num)
        {
            if (arr == null || arr.Length == 0)
            {
                return false;
            }

            int L = 0;
            int R = arr.Length - 1;
            while (L<=R)
            {
                int mid = (L + R) / 2;
                if (arr[mid] == num)
                {
                    return true;
                }
                else if (arr[mid] < num)
                {
                    L = mid + 1;
                }
                else if (arr[mid] > num)
                {
                    R = mid - 1;
                }
            }

            return false;
        }
        
        //arr有序，>=num 最左
        public static int mostLeftNoLessNumIndex(int[] arr, int num)
        {
            if (arr == null || arr.Length == 0)
            {
                return -1;
            }

            int L = 0;
            int R = arr.Length - 1;
            int ans = -1;
            while (L <= R)
            {
                int mid = (L + R) / 2;
                if (arr[mid] >= num)
                {
                    ans = mid;
                    R = mid - 1;
                }
                else
                {
                    L = mid + 1;
                }
            }

            return ans;
        }

        public static int mostRightNoMoreNumIndex(int[] arr, int num)
        {
            if (arr == null || arr.Length == 0)
            {
                return -1;
            }

            int L = 0;
            int R = arr.Length - 1;
            int ans = -1;
            while (L <= R)
            {
                int mid = (L + R) / 2;
                if (arr[mid] <= num)
                {
                    ans = mid;
                    L = mid + 1;
                }
                else
                {
                    R = mid - 1;
                }
            }

            return ans;
        }
        
        /*static void Main()
        {
            int[] arr={1,2,4,8,9,10};
            int num = 7;
            int ans = mostLeftNoLessNumIndex(arr, num);
            Console.WriteLine(ans);
            ans = mostRightNoMoreNumIndex(arr, num);
            Console.WriteLine(ans);
        }*/
    }
}