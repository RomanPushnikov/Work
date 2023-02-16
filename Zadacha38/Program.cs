// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.Clear();

int[] array = new int[10];

Random rnd = new Random();
Console.Write("Массив: ");
for (int i = 0; i < array.Length; i++) // Сгенерировали массив
{
    array[i] = rnd.Next(1, 100);
    Console.Write(array[i] + " "); // Вывели массив
}


Console.WriteLine();
Console.Write("Oтсортированный массив: ");

void SelectionSortmax(int[] arr)
{
    for (int i = 0; i <= arr.Length - 1 ; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < arr.Length; j++)     // мы начали позицию поиска максимального от индекса "i + 1" где "i" меняется до макс знач позиции массива то нужно отнять 1-цу у "arrLength"  то нужно         // поиск максимального элемента
        {                                                      //
            if(arr[j] < arr[minPosition]) minPosition = j; //
                                                               //
        }
        int temporrary = arr[i];        
        arr[i] = arr[minPosition];
        arr[minPosition] = temporrary;
        

        Console.Write(array[i] + " ");
    }

} 

SelectionSortmax(array);

Console.WriteLine();

int diferens = array[array.Length -1] - array[0];
Console.WriteLine($"Разница max - min: {diferens} ");


