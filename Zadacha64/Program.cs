// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.Clear();

int newNumber()  // Конструкция Функции Ввода разных параметров.
{
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void VuvodCelih(int n)
{
    if(n > 0) 
    {
        Console.Write($"{n}, ");
        VuvodCelih(n-1);
    } 
   
}

System.Console.Write("Поиск всех натуральных чисел в промежутке от n до 1: n = ");
int n = newNumber();
VuvodCelih(n);
