// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Задача 64. Вывести все натуральные числа от N до 1");
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());
if (n > 1)
{
    Console.Write($"{NaturalNum(n)}, ");
    int NaturalNum(int n)
    {
        Console.Write($"{n}, ");
        if (n == 2) return 1; 
        return n = NaturalNum(n - 1);
    } 
}
else Console.WriteLine($"Введено число: {n} должно быть больше 1");    




// // Задача 66: Задайте значения M и N. Напишите программу, 
// // которая найдёт сумму натуральных элементов в промежутке от M до N.
// // M = 1; N = 15 -> 120
// // M = 4; N = 8. -> 30

Console.WriteLine();
Console.WriteLine("Задача 66. Выведет сумму натуральных элементов в промежутке от M до N");
Console.Write("Введите число M: ");
int mNum = int.Parse(Console.ReadLine());

Console.Write("Введите число N: ");
int nNum = int.Parse(Console.ReadLine());

if (mNum > 0 &
    nNum > mNum)
{
    int sum = 0;
    Console.WriteLine($"Сумма всех элементов = {SumNum(mNum, nNum)}");    
    int SumNum(int m, int n)
    {
        if (m > n) return sum;
        sum = sum + m;
        m++;
        SumNum(m, n); 
        return sum;
    }
}
else 
{
    if (mNum <= 0) Console.WriteLine($"Первое значение {mNum} должно быть больше 0");
    if (nNum <= mNum) Console.WriteLine($"Второе значение {nNum} должно быть больше первого {mNum}");
}

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine();
Console.WriteLine("Задача 68. Вычисления функции Аккермана с помощью рекурсии.");

Console.Write("Введите первое неотрицательное число: ");
int numM = int.Parse(Console.ReadLine());

Console.Write("Введите второе неотрицательное число: ");
int numN = int.Parse(Console.ReadLine());
Console.WriteLine();

if (numM >= 0 && numN >= 0)
{
    Console.WriteLine($"Ответ = {Ackermann(numM, numN)}");
    int Ackermann(int m, int n)
    {
        if (m == 0) return n + 1;
        if (m != 0 && n == 0) return Ackermann(m -1, 1);
        if (m > 0 && n > 0) return Ackermann(m - 1, Ackermann(m, n - 1));
        return Ackermann(m, n);
    }
}
else Console.WriteLine("Введены некорректные данные");
