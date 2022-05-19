using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    public class Class1
    {
        public static int[] GenerateNumbers()
        {
            int[] numbers = new int[] {1 ,2 ,3 ,4 ,5 , 6, 7 ,8, 9 ,10};
            return numbers;
        }
        public static void Reverse(int[] input)
        {
            int n = input.Length;
            int left;
            int right;
            if(n % 2 == 0)
            {
                left = n/2-1;
                right = n/2;
                while(left >=  0 && right < n)
                {
                    int temp = input[left];
                    input[left--] = input[right];
                    input[right++] = temp;
                }
            }
            else
            {
                left = n / 2 - 1;
                right = n / 2 + 1;
                while (left >= 0 && right < n)
                {
                    int temp = input[left];
                    input[left--] = input[right];
                    input[right++] = temp;
                }
            }

        }
        public static void PrintNumber(int[] input)
        {
            foreach(int n in input)
            {
                Console.Write(n + " ");
            }
        }
        public static void Fibonacci(int n) 
        {
            int[] memo = new int[n+1];
            int res = helper(memo, n);
            Console.WriteLine(res);
        }
        public static int helper(int[] memo, int n)
        {
            if (n == 0 || n == 1) return n;
            if(memo[n] != 0) return memo[n];
            memo[n] = helper(memo, n-1) + helper(memo, n-2);
            return memo[n];
        }
    }
}
