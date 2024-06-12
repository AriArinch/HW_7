void PrintNaturalNumbers(int m, int n)
{
    if (m <= n)
    {
        Console.Write(m + " ");
        PrintNaturalNumbers(m + 1, n);
    }
}

    Console.Write("Введите значение M: ");
    int m = int.Parse(Console.ReadLine());

    Console.Write("Введите значение N: ");
    int n = int.Parse(Console.ReadLine());

    Console.Write("Натуральные числа в диапазоне от M до N: ");
    PrintNaturalNumbers(m, n);

    Console.WriteLine();