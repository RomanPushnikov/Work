// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.Clear();

int Method1(int first, int sec)
{
    int resPow = (int)Math.Pow(first, sec);
    return(resPow);
}

int newNumber()  // Конструкция Функции Ввода разных параметров.
{
    System.Console.WriteLine("Введите параметр: ");
    int number = Convert.ToInt32 (Console.ReadLine());
    return number;

}

int a = newNumber();
int b = newNumber();

int pow = Method1(a, b);
Console.WriteLine($"Первое число в степени второго: {pow}");  
