using System;

class Program
{
    static void Main()
    {
        int a, b, c;
        Console.WriteLine("Введіть число 1");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введіть число 2");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введіть число 3");
        c = Convert.ToInt32(Console.ReadLine());
        int[] selectedNumbers = { a, b, c };
        Console.WriteLine("Числа, що належать інтервалу [1, 12]:");
        foreach (int num in selectedNumbers)
        {
            if (num >= 1 && num <= 12)
            {
                Console.WriteLine(num);
            }
        }
        Console.WriteLine();

        double sideA, sideB, sideC;
        Console.WriteLine("Введіть сторону А");
        sideA = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введіть сторону В");
        sideB = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введіть сторону С");
        sideC = Convert.ToDouble(Console.ReadLine());

        if (sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA)
        {
            double perimeter = sideA + sideB + sideC;
            double s = perimeter / 2;
            double area = Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));

            Console.WriteLine("Периметр трикутника: " + perimeter);
            Console.WriteLine("Площа трикутника: " + area);

            if (sideA == sideB && sideB == sideC)
                Console.WriteLine("Трикутник є рівностороннім.");
            else if (sideA == sideB || sideB == sideC || sideA == sideC)
                Console.WriteLine("Трикутник є рівнобедреним.");
            else
                Console.WriteLine("Трикутник є різностороннім.");
        }
        else
        {
            Console.WriteLine("Такий трикутник не існує.");
        }
        Console.WriteLine();

        int[] X = { 12, 5, 7, 0, 20, -3, 15, 18, 6, 10, 21, -10 };

        int min = X[0], max = X[0];
        foreach (int num in X)
        {
            if (num < min)
                min = num;
            if (num > max)
                max = num;
        }

        Console.WriteLine("Мінімальне значення в масиві Х: " + min);
        Console.WriteLine("Максимальне значення в масиві Х: " + max);
        Console.WriteLine("Масив Х: " + string.Join(", ", X));
        Console.WriteLine();

        int M = 8;

        int[] Y = new int[X.Length];
        int y = 0;
        foreach (int num in X)
        {
            if (Math.Abs(num) > M)
            {
                Y[y] = num;
                y++;
            }
        }

        Console.WriteLine("Число M: " + M);
        Console.WriteLine("Масив Х: " + string.Join(", ", X));
        Console.Write("Отриманий масив Y: ");
        Array.Resize(ref Y, y);
        Console.WriteLine(string.Join(", ", Y));
    }
}
