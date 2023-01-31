Console.Write("Введите 1-oe число и нажмите 'Enter': ");
int a = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите 2-oe число и нажмите 'Enter': ");
int b = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите 3-oe число и нажмите 'Enter': ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
{
    Console.WriteLine($"Max number = {max}.");
}

