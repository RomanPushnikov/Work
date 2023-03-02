// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Clear();

int EntNumb()
{
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void SummNumb(int M, int N, int sum)
{
    if(M > N) 
    {
        Console.Write($"Cумма натуральных числе в промежутке = {sum}. "); 
        return;
    }
    else sum += M;
    
    SummNumb(M + 1, N, sum);
}

Console.Write("Введите число М: ");
int M = EntNumb();
Console.Write("Введите число N: ");
int N = EntNumb();
int sum = 0;
SummNumb(M, N, sum);
