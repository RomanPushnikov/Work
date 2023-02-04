/*Принимает цифру обознач день недели и проверяет 
является ли день выходным*/
Console.Clear();

Console.Write("Введите число: ");
int a;
string? str = (Console.ReadLine());
Console.WriteLine(int.TryParse(str, out a)); //  "int.TryParse" преобразует строку в целое число и выводит Тrue или False, отсюда и возьмём.

switch (a) 
{

    case 1:
    System.Console.WriteLine( $"{a} - Раб день" );
    break;

    case 2:
    System.Console.WriteLine( $"{a} - Раб день" );
    break;

    case 3:
    System.Console.WriteLine( $"{a} - Раб день" );
    break;

    case 4:
    System.Console.WriteLine( $"{a} - Раб день" );
    break;

    case 5:
    System.Console.WriteLine( $"{a} - Раб день" );
    break;

    case 6:
    System.Console.WriteLine( $"{a} - Суббота. Это выходной день!" );
    break;

    case 7:
    System.Console.WriteLine( $"{a} - Воскресенье. Это выходной день!" );
    break;

    default:
    System.Console.WriteLine( $"{a} - Это не день недели!" );
    break;
}

