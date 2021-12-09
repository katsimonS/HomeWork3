using System;

namespace HomeWork3
{
    class Program
    {
        static double Task1(double num, int degree)
        {
            return Math.Pow(num, degree);
        }

        static int Task3(double num)
        {
            int result = 0;

            for (int i = 1; i * i < num; i++)
            {
                result = i;
            }

            return result;
        }

        static int Task4(int num)
        {
            int maxDivisor = 0;
            for (int i = num-1; i > 0; i--)
            {
                if(num % i == 0)
                {
                    maxDivisor = i;
                    break;
                }
            }
            return maxDivisor;
        }

        static int Task5(int a, int b, int divisor)
        {
            int sum=0;

            if (b < a)
            {
                int temp = b;
                b = a;
                a = temp;
            }
            for (int i = a; i <= b; i++)
                {
                    if (i % divisor == 0)
                    {
                        sum += i;
                    }
                }

            return sum;
        }

        static int Task6(int n)
        {
            int fibonacciSeries = 0;
            int a = 1;
            int temp;

            for (int i = 0; i < n; i++)
            {
                temp = fibonacciSeries;
                fibonacciSeries = a;
                a += temp;
            }

            return fibonacciSeries;
        }

        static int Task7(int a, int b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }

            return Math.Max(a, b);
        }

        static void Task8()
        {
            Console.WriteLine("later");
        }

        static int Task9(int n)
        {
            int result = 0;

            while (n != 0)
            {
                int digit = n % 10;
                n /= 10;
                if (digit % 2 != 0)
                {
                    result++;
                }
            }

            return result;
        }

        static int Task10(int n)
        {
            int result = 0;

            while (n != 0)
            {
                int currentDigit = n % 10;
                n /= 10;
                result *= 10;
                result += currentDigit;
            }

            return result;
        }

        static bool Task12(int a, int b)
        {
            while (a != 0)
            {
                int digitA = a % 10;
                while (b != 0)
                {
                    int digitB = b % 10;
                    b /= 10;
                    if (digitB == digitA)
                    {
                        return true;
                    }
                }
                a /= 10;
            }
            return false;
        }

        static void Main()
        {

        }
    }
}
