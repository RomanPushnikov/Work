// Принимает *** число и выдает вторую цифру этого числа.
Console.Clear();

Console.Write("Введите трехзначное число: ");
int a;
string? str = (Console.ReadLine());
bool result = int.TryParse(str, out a); // bool хранит true или False, "int.TryParse" преобразует строку в целое число и выводит Тrue или False, отсюда и возьмём.

if (result == true & a > 99 & a < 1000)
{
    a = a / 10 % 10;
    Console.WriteLine($"Вторая цифра: {a}.");
}
else 
{
    Console.WriteLine("Проверьте правильность ввода, и повторите попытку!");
}

