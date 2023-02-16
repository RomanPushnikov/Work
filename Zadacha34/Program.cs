// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] array = new int[5];

Random rnd = new Random();
for (int i = 0; i < array.Length; i++) // Сгенерировали массив
{
    array[i] = rnd.Next(100, 1000);
    Console.Write(array[i] + " "); // Вывели массив
}

int numbEvenNumb = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        numbEvenNumb += 1;
    }
}

Console.WriteLine();
Console.Write($"Количестов четных числе в массиве: {numbEvenNumb}");
