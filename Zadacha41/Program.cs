// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Clear();

int moreThen0 = 0;

Console.Write("Введите необходимые числа через пробел: ");
string? str = Console.ReadLine(); // вводим строку
var array = str.Split(" "); // строку делим по пробелу

int[] arrayInt = new int[array.Length]; // переводим в int

for (int i = 0; i < array.Length; i++) // Сгенерировали массив
{
    arrayInt[i] = Convert.ToInt32(array[i]);
}

Console.Write("Массив: ");

foreach (var item in arrayInt)
{
    Console.Write(" " +  item);
}

Console.WriteLine();

for (int i = 0; i < array.Length; i++)
{
    if (arrayInt [i] > 0) 
    {
        moreThen0 += 1;
    }
}

Console.Write("Количество чисел > 0: " + moreThen0);
