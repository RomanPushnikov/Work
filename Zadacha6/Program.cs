Console.Clear();
Console.Write("Введите число: ");
string? str =(Console.ReadLine());
int a;
Console.WriteLine(int.TryParse(str, out a));
int  b = (a % 2);


switch (b) {

case 0:
System.Console.WriteLine( $" {a} четное число" );
break;

default:
System.Console.WriteLine( $"{a} нечетное число" );
break;
}
