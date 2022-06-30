using System;

namespace 算法
{
    class Program
    {
        static void print(int num)
        {
            for(int i=31;i>=0;i--)
            {
                Console.Write(((1<<i)&num)==0?"0":"1");
            }
        }
        
        /*static void Main()
        {
            int a = 11514;
            print(a);
        }*/
    }
}