using System;
namespace Lab1
{
    internal class metod
    {
        public double ReadDouble()
        {
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out double value))
                {
                    return value;
                }
                Console.Write("Пожалуйста, введите число: ");
            }
        }
        public double fraction(double x)
        {
            int wholePart = (int)x;
            double fractionalPart = x - wholePart;
            return fractionalPart;
        }
        public char ReadChar()
        {
            while (true)
            {
                string s = Console.ReadLine();
                if (s != null && s != "" && s.Length == 1)
                {
                    return s[0];
                }
                Console.WriteLine("Введите один символ: ");

            }
        }
        public int charToNum(char x)
        {
            return x - '0';


        }
        public int ReadInt()
        {
            while (true)
            {
                try
                {
                    int value = int.Parse(Console.ReadLine());
                    return value;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Это не число.Попробуйте ещё раз");
                }
            }
        }
        public long ReadLong()
        {
            while (true)
            {
                try
                {
                    Console.Write("Введите целое число: ");
                    long value = long.Parse(Console.ReadLine());
                    return value;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Это не число. Попробуйте ещё раз.");
                }
            }
        }
        public void printArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        public bool is2Digits(int x)
        {
            int abs = Math.Abs(x);
            return abs >= 10 && abs <= 99;
        }
        public bool isInRange(int a, int b, int num)
        {
            int min = Math.Min(a, b);
            int max = Math.Max(a, b);
            return num >= min && num <= max;
        }
        public bool isEqual(int a, int b, int c)
        {
            return a == b && b == c;
        }
        public int abs(int x)
        {
            if (x < 0)
            {
                return -x;
            }
            else
            {
                return x;
            }
        }
        public bool is35(int x)
        {
            bool y3 = x % 3 == 0;
            bool y5 = x % 5 == 0;
            return y3 ^ y5;
        }
        public int max3(int x, int y, int z)
        {
            int max = x;
            if (y > max)
            {
                max = y;
            }
            if (z > max)
            {
                max = z;
            }
            return max;
        }
        public int sum2(int x, int y)
        {
            int sum = x + y;
            if (sum >= 10 && sum <= 19)
            {
                return 20;
            }
            return sum;
        }
        public String day(int x)
        {
            String result = "это не день недели";
            switch (x)
            {
                case 1:
                    result = "понедельник";
                    break;
                case 2:
                    result = "вторник";
                    break;
                case 3:
                    result = "среда";
                    break;
                case 4:
                    result = "четверг";
                    break;
                case 5:
                    result = "пятница";
                    break;
                case 6:
                    result = "суббота";
                    break;
                case 7:
                    result = "воскресенье";
                    break;
                default:
                    break;
            }
            return result;
        }
        public String listNums(int x)
        {
            String result = "";
            for (int i = 0; i <= x; i++)
            { 
                result = result + i + " "; 
            }
            return result.Trim();
        }
        public String chet(int x)
        {
            String result = "";
            for (int i = 0; i <= x; i += 2)
            { 
                result = result + i + " ";
            }
            return result.Trim();
        }
        public int numLen(long x)
        {
            if (x == 0)
            { 
                return 1;
            }
            x = Math.Abs(x);
            int count = 0;
            while (x > 0)
            {
                x = x / 10;
                count++;
            }
            return count;
        }
        public void square(int x)
        {
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < x; j++)
                { 
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
        public void rightTriangle(int x)
        {
            for (int i = 1; i <= x; i++)
            {
                for (int j = 0; j < x - i; j++)
                { 
                    Console.Write(" "); 
                }

                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public int findFirst(int[] arr, int x)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                {
                    return i;
                }
            }
            return -1;
        }
        public int maxAbs(int[] arr)
        {
            int maxAbs = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (Math.Abs(arr[i]) > Math.Abs(maxAbs))
                {
                    maxAbs = arr[i];
                }

            }
            return maxAbs;

        }
        public int[] add(int[] arr, int[] ins, int pos)
        {
            int[] result = new int[arr.Length + ins.Length];
            for (int i = 0; i < pos; i++)
            { result[i] = arr[i]; }
            for (int i = 0; i < ins.Length; i++)
            {
                result[pos + i] = ins[i];
            }
            for (int i = pos; i < arr.Length; i++)
            {
                result[i + ins.Length] = arr[i];
            }
            return result;
        }
        public int[] reverseBack(int[] arr)
        {
            int[] result = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                result[arr.Length - 1 - i] = arr[i];
            }

            return result;
        }
        public int[] findAll(int[] arr, int x)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                {
                    count++;
                }
            }
            int[] result = new int[count];
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                {
                    result[index] = i;
                    index++;
                }
            }
            return result;
        }
    }
}

