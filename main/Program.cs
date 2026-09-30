using System;
namespace Lab1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            metod tasks = new metod();
            Console.WriteLine("Задача 1.1");
            Console.Write("Введите число: ");
            double d1 = tasks.ReadDouble();
            Console.WriteLine("Дробная часть: " + tasks.fraction(d1));
            Console.WriteLine();

            Console.WriteLine("Задача 1.3");
            Console.Write("Введите символ-цифру: ");
            char c3 = tasks.ReadChar();
            Console.WriteLine("Число: " + tasks.charToNum(c3));
            Console.WriteLine();

            Console.WriteLine("Задача 1.5");
            Console.Write("Введите число: ");
            int x5 = tasks.ReadInt();
            Console.WriteLine("Двузначное: " + tasks.is2Digits(x5));
            Console.WriteLine();

            Console.WriteLine("Задача 1.7");
            Console.Write("Введите a: ");
            int a7 = tasks.ReadInt();
            Console.Write("Введите b: ");
            int b7 = tasks.ReadInt();
            Console.Write("Введите num: ");
            int num7 = tasks.ReadInt();
            Console.WriteLine("В диапазоне: " + tasks.isInRange(a7, b7, num7));
            Console.WriteLine();

            Console.WriteLine("Задача 1.9");
            Console.Write("Введите a: ");
            int a9 = tasks.ReadInt();
            Console.Write("Введите b: ");
            int b9 = tasks.ReadInt();
            Console.Write("Введите c: ");
            int c9 = tasks.ReadInt();
            Console.WriteLine("Все равны: " + tasks.isEqual(a9, b9, c9));
            Console.WriteLine();

            Console.WriteLine("Задача 2.1");
            Console.Write("Введите число: ");
            int x21 = tasks.ReadInt();
            Console.WriteLine("Модуль: " + tasks.abs(x21));
            Console.WriteLine();

            Console.WriteLine("Задача 2.3");
            Console.Write("Введите число: ");
            int x23 = tasks.ReadInt();
            Console.WriteLine("Результат: " + tasks.is35(x23));
            Console.WriteLine();

            Console.WriteLine("Задача 2.5");
            Console.Write("Введите x: ");
            int x25 = tasks.ReadInt();
            Console.Write("Введите y: ");
            int y25 = tasks.ReadInt();
            Console.Write("Введите z: ");
            int z25 = tasks.ReadInt();
            Console.WriteLine("Максимум: " + tasks.max3(x25, y25, z25));
            Console.WriteLine();

            Console.WriteLine("Задача 2.7");
            Console.Write("Введите x: ");
            int x27 = tasks.ReadInt();
            Console.Write("Введите y: ");
            int y27 = tasks.ReadInt();
            Console.WriteLine("Результат: " + tasks.sum2(x27, y27));
            Console.WriteLine();

            Console.WriteLine("Задача 2.9");
            Console.Write("Введите номер дня (1-7): ");
            int x29 = tasks.ReadInt();
            Console.WriteLine("День: " + tasks.day(x29));
            Console.WriteLine();

            Console.WriteLine("Задача 3.1");
            Console.Write("Введите число х, до которого будут записаны все числа от 0 включительно: ");
            int x31 = tasks.ReadInt();
            Console.WriteLine("Результат: " + tasks.listNums(x31));
            Console.WriteLine();

            Console.WriteLine("Задача 3.3");
            Console.Write("Введите x: ");
            int x33 = tasks.ReadInt();
            Console.WriteLine("Чётные: " + tasks.chet(x33));
            Console.WriteLine();

            Console.WriteLine("Задача 3.5");
            long x35 = tasks.ReadLong();
            Console.WriteLine("Количество цифр: " + tasks.numLen(x35));
            Console.WriteLine();

            Console.WriteLine("Задача 3.7");
            Console.Write("Введите размер квадрата: ");
            int x37 = tasks.ReadInt();
            Console.WriteLine("Квадрат:");
            tasks.square(x37);
            Console.WriteLine();

            Console.WriteLine("Задача 3.9");
            Console.Write("Введите высоту треугольника: ");
            int x39 = tasks.ReadInt();
            Console.WriteLine("Треугольник:");
            tasks.rightTriangle(x39);
            Console.WriteLine();

            Console.WriteLine("Задача 4.1");
            int[] arr41 = { 1, 5, 3, 8, 2, 4, 3 };
            Console.Write("Введите искомое число: ");
            int x41 = tasks.ReadInt();
            Console.WriteLine("Первый индекс: " + tasks.findFirst(arr41, x41));
            Console.WriteLine();

            Console.WriteLine("Задача 4.3");
            int[] arr43 = { 5, -6, -9, 2, 3, 6, 5 };
            Console.WriteLine("Максимум по модулю: " + tasks.maxAbs(arr43));
            Console.WriteLine();

            Console.WriteLine("Задача 4.5");
            int[] arr45 = { 1, 2, 3, 4, 5 };
            int[] ins45 = { 7, 8, 9 };
            int pos45 = 3;
            int[] result45 = tasks.add(arr45, ins45, pos45);
            Console.WriteLine("Результат:");
            tasks.printArray(result45);
            Console.WriteLine();

            Console.WriteLine("Задача 4.7");
            int[] arr47 = { 1, 2, 3, 4, 5 };
            int[] result47 = tasks.reverseBack(arr47);
            Console.WriteLine("Исходный: ");
            tasks.printArray(arr47);
            Console.WriteLine("Обратный: ");
            tasks.printArray(result47);
            Console.WriteLine();

            Console.WriteLine("Задача 4.9");
            int[] arr49 = { 1, 2, 3, 8, 2, 2, 9 };
            Console.Write("Введите искомое число: ");
            int x49 = tasks.ReadInt();
            int[] result49 = tasks.findAll(arr49, x49);
            Console.Write("Индексы вхождений:  ");
            tasks.printArray(result49);
            Console.WriteLine();
        }

    }
}