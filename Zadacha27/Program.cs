//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

 int newNumber()  // Конструкция Функции Ввода разных параметров.
{
    System.Console.WriteLine("Введите параметр: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

 int a = newNumber();


 int PrintImage(int numb)
{
    int sumNumbers = 0;
    while (numb > 0)
    {
        sumNumbers = sumNumbers + numb % 10;
        numb = numb / 10; 
    }
    return sumNumbers;
}

int res = PrintImage(a); 
Console.WriteLine(res);

