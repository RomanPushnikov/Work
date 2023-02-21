Console.Clear();

System.Console.WriteLine("Система уравнений для поиска координат точки: \n y = k1 * x + b1, \n y = k2 * x + b2 ");

System.Console.Write("Введите b1: ");
double b1 = newNumber();

System.Console.Write("Введите k1: ");
double k1 = newNumber();

System.Console.Write("Введите b2: ");
double b2 = newNumber();

System.Console.Write("Введите k2: ");
double k2 = newNumber();

double newNumber()  // Конструкция Функции Ввода разных параметров.
{
    double number = Convert.ToDouble(Console.ReadLine());
    return number;
}

double findX() // Находим "х"
{
    double x = (b2 - b1)/(k1 - k2);
    return x;
}

void pointResult(double x) //Выведем точку найдя перед этим "у".
{
    double y = k2 * x + b2;
    Console.WriteLine("Координата точки: " + (Math.Round(x, 2), Math.Round(y, 2)));
}

pointResult(findX());

