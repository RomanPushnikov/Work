// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет

//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

void PrintImage(int[,] matrix)
{
    Console.Write("Enter search number: ");
    int a;
    string? str = (Console.ReadLine());
    bool result = int.TryParse(str, out a);
    bool b = false;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(matrix[i,j] == a && result == true) 
            {
                b = true;
                break;
            }
        }
    }
    if (b)                                       // дальше ели b - True то пишу есть.
    {
        Console.Write($"This array have that number: {a} ");
    }                                          // если остался False то пишу нету.
    else Console.Write("This array haven't that number! "); 

}

int[,] matrix = new int[,]
{
{1, 4, 7, 2},
{5, 9, 2, 3},
{8, 4, 17, 4},
};

PrintImage(matrix);
