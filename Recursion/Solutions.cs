using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace data_structures
{
    internal static class Solitions
    {

        public static int Multiply(int a, int b)
        {
            if (b <= 1)
            {
                return a;
            }

            return a + Multiply(a, b - 1);
        }

        public static int SumOfDigits(int n)
        {
            if (n < 10)
            {
                return n;
            }
            int num = n % 10;
            return num + SumOfDigits(n / 10);
        }

        public static int Power(int a, int b)
        {
            if (b <= 1)
                return a;

            return a * Power(a, b - 1);
        }

        public static void Reversed(int n)
        {
            if (n < 10)
            {
                Console.WriteLine(n);
                return;
            }
            Console.WriteLine(n % 10);
            Reversed(n / 10);
        }

        public static int FindSum(int[] arr, int length)
        {
            if (length <= 1)
            {
                return arr[length - 1];
            }
            int sum = arr[length - 1];
            sum += FindSum(arr, length - 1);
            return sum;
        }

        public static int Divide(int a, int b)
        {
            if (a <= 0)
            {
                return 0;
            }
            int counter = 1;
            counter += Divide(a - b, b);
            return counter;
        }

        public static bool IsPalindrome(string s)
        {
            if (s.Length <= 1)
                return true;
            else
            {
                if (s[0] != s[s.Length - 1])
                {
                    return false;
                }
                else
                {
                    return IsPalindrome(s.Substring(1, s.Length - 2));
                }
            }
        }

        public static string decimalToBinary(int n)
        {
            if (n == 0)
            {
                return "0";
            }
            if(n == 1)
            {
                return "1";
            }
            string reminder = Convert.ToString(n % 2);
            return decimalToBinary(n / 2) + reminder;
        }

        public static void Gcd(int a, int b)
        {

        }

    }
}

