﻿// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("ВВедите число М: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("ВВедите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

AkkermanFunktion(m, n);


// вызов функции Аккермана
void AkkermanFunktion(int m, int n)
{
    Console.Write(Akkerman(m, n));
}

// функция Аккермана
int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return(Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}