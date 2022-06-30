using System;

namespace 算法
{
    public class Code02_SumOfFactorial
    {
        static void SumOfFactorial(int num)
        {
            int p = 1;
            int s = 0;
            for (int i = 1; i <= num; i++)
            {
                p = p * i;
                s = s + p;
            }
            Console.Write(s);
        }
        
        /*static void Main()
        {
            int a = 5;
            SumOfFactorial(a);
        }*/
    }
}