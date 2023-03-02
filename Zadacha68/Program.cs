// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.Clear();

int AkkermanFunk (int n, int m)
{
    if (n == 0) return m + 1;
    else 
    {
        if (n != 0 && m == 0) return AkkermanFunk(n - 1, 1);
        else 
        {
            return AkkermanFunk(n - 1, AkkermanFunk(n, m - 1));
        }
    }
}

Console.Write("Введите неотрицательное значение n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите неотрицательное значение m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write($"A(n,m) = {AkkermanFunk (n, m)}.");
