// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.Clear();

void PrintRandMatr(double[,] matrix)
{
    Random random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)    // matrix.GetLength(0) получить - кол-во строк. 
    {
        for (int j = 0; j < matrix.GetLength(1); j++)   // matrix.GetLength(1) получить - кол-во столбцов. 
        {
            matrix[i, j] = random.NextDouble() * 20 - 10; // NextDouble() дает случайное вещественное число в диапазоне от 0 до 1." * 20(чисел) - 10(от -10)" 
            Console.Write($" {Math.Round(matrix[i, j], 1)} "); // Math.Round(matrix[i, j], 2) оставить "1" знакак после запятой.
        }
    Console.WriteLine();
    }
}

int newNumber()  // Конструкция Функции Ввода разных параметров.
{
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
System.Console.Write("Введите количество строк: m = ");
int m = newNumber();
System.Console.Write("Введите количество столбцов: n = ");
int n = newNumber();
double [,] matrix = new double [m, n];
PrintRandMatr(matrix);
