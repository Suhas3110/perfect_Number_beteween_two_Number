using System;

namespace perfect_Number_beteween_two_Number
{
    internal class Program
    {
        int n;
        public static Boolean perfect(int n)
        {
            int sum = 0;
            for (int i = 1; i <n; i++)
            {
                if (n % i == 0)
                {
                    sum = sum + i;
                }
            }
            if(sum==n)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter two Number from User");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            for(int i=a; i<b; i++)
            {
                if(perfect(i)==true)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
