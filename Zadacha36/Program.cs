// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] array = new int[5];

Random rnd = new Random();
for (int i = 0; i < array.Length; i++) // Сгенерировали массив
{
    array[i] = rnd.Next(-100, 100);
    Console.Write(array[i] + " "); // Вывели массив
}

int summNumbEvenPosition = 0;

for (int i = 0; i < array.Length; i = i + 2)
{
    summNumbEvenPosition += array[i]; 
}

Console.WriteLine();
Console.Write($"Сумма элементов на нечётных позициях равна: {summNumbEvenPosition}");
