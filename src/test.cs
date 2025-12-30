using System;

namespace ClassFunctions
{

    public static class Functions
    {
        public static int[] BubbleSort(int[] arr)
        {
            int[] sorted = (int[])arr.Clone();
            int n = sorted.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (sorted[j] > sorted[j + 1])
                    {
                        int temp = sorted[j];
                        sorted[j] = sorted[j + 1];
                        sorted[j + 1] = temp;
                    }
                }
            }
            return sorted;
        }
        public static bool IsPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s))
                return false;

            int length = s.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (s[i] != s[length - 1 - i])
                    return false;
            }
            return true;
        }
        public static int Factorial(int n)
        {
            if (n < 0)
                throw new ArgumentException("Факториал не определён для отрицательных чисел");

            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
        public static int Fibonacci(int n)
        {
            if (n <= 0)
                throw new ArgumentException("n должно быть положительным числом");

            if (n == 1)
                return 0;
            else if (n == 2)
                return 1;

            int x = 0, y = 1, z = 0;
            for (int i = 3; i <= n; i++)
            {
                z = x + y;
                x = y;
                y = z;
            }
            return y;
        }
        public static bool ContainsSubstring(string s, string sub)
        {
            if (s == null || sub == null)
                throw new ArgumentNullException("Строки не должны быть пустыми");

            return s.Contains(sub);
        }
        public static bool IsPrime(int n)
        {
            if (n <= 1)
                return false;

            int limit = (int)Math.Sqrt(n);
            for (int i = 2; i <= limit; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
        public static int ReverseInt(int x)
        {
            long reversed = 0;
            int sign = x < 0 ? -1 : 1;
            x = Math.Abs(x);

            while (x > 0)
            {
                int digit = x % 10;
                reversed = reversed * 10 + digit;
                x /= 10;

                if (reversed > int.MaxValue)
                    return 0;
            }

            reversed *= sign;

            if (reversed < int.MinValue || reversed > int.MaxValue)
                return 0;

            return (int)reversed;
        }
        public static string ToRoman(int number)
        {
            if (number <= 0 || number > 3999)
                throw new ArgumentOutOfRangeException(nameof(number), "Число должно быть в диапазоне от 1 до 3999");
            var romanNumerals = new[]
            {
            new { Value = 1000, Symbol = "M" },
            new { Value = 900,  Symbol = "CM" },
            new { Value = 500,  Symbol = "D" },
            new { Value = 400,  Symbol = "CD" },
            new { Value = 100,  Symbol = "C" },
            new { Value = 90,   Symbol = "XC" },
            new { Value = 50,   Symbol = "L" },
            new { Value = 40,   Symbol = "XL" },
            new { Value = 10,   Symbol = "X" },
            new { Value = 9,    Symbol = "IX" },
            new { Value = 5,    Symbol = "V" },
            new { Value = 4,    Symbol = "IV" },
            new { Value = 1,    Symbol = "I" }
        };
            var result = new System.Text.StringBuilder();
            foreach (var item in romanNumerals)
            {
                while (number >= item.Value)
                {
                    result.Append(item.Symbol);
                    number -= item.Value;
                }
            }
            return result.ToString();
        }
        public static void Main()
        {

        }
    }

}
