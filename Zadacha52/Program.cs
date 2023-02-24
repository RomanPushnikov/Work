// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.Clear();

void averageColumns(int [,] matrix)
{
    Console.WriteLine("Среднее арифметическое элементов в столбце: ");

    for (int j = 0; j < matrix.GetLength(1); j++)    // matrix.GetLength(0) получить - кол-во столб. 
        {
            double SummInColumn = 0;
            double averageNum = 0; 

            for (int i = 0; i < matrix.GetLength(0); i++)   // matrix.GetLength(1) получить - кол-во строк. 
            {
                SummInColumn += matrix[i, j]; 
            }
            averageNum = SummInColumn / matrix.GetLength(0);
            Console.Write($" {Math.Round(averageNum, 2)} ");
            
        }
    
}

int[,] matrix = new int[,]
{
{1, 4, 7, 2},
{5, 9, 2, 3},
{8, 4, 2, 4},
};

averageColumns(matrix);

