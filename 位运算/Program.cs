using System;

namespace 位运算
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
        
        static void Main(string[] args)
        {
            int a = 1;
            print(a);
        }
    }
}