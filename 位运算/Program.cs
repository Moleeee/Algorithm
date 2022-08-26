using System;

namespace 位运算
{
    class Program
    {
        static void print(int num) uyiyui
        {
            for(int i=31;i>=0;i--)5468qwewq
            {
                Console.Write(((1<<i)&num)==0?"0":"1");
            }
        }
        
        static void Main(string[] args) 111
        {
            int a = 1;
            print(a);
        }
    }
}