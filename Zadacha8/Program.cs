Console.Clear();
Console.Write("Введите число: ");
string? str = (Console.ReadLine());
int a;
Console.WriteLine(int.TryParse(str, out a));
int b = 1;
Console.Write($"Чётные числа в диапазоне от 1 до {a}: ");

while (b <= a)
{
    if (b % 2 == 0)
    {
        Console.Write($"{b}, ");
        b = b + 1;
    }
    else
    {
        b = b + 1;
    }

}
