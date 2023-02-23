void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length){
        collection[index] = new Random().Next(1, 8);
        index++;
    }
}

// метод void кот будет печатать массив
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }

}

int[] Array = new int[8];
FillArray(Array);
PrintArray(Array);

/* void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }

}

int newNumber()  // Конструкция Функции Ввода разных параметров.
{
    System.Console.WriteLine("Введите параметр: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int a = newNumber();

int[] Array = {a};
FillArray(Array);
PrintArray(Array);
*/