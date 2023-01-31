Console.Write("Введиет первое число и нажмите 'Enter': ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введиет второе число и нажмите 'Enter': ");
int b = Convert.ToInt32(Console.ReadLine());

    if (a > b)
{
    Console.WriteLine($"max = {a}, min = {b}");
}
    if (a < b)
{
    Console.WriteLine($"max = {b}, min = {a}");
}
    if (a == b)
{
    Console.WriteLine("Они одинаковые!");
}

