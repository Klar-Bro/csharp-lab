//zad 1

double QuadraticEquation(double x=0.0, double a=1.0, double b=1.0, double c=1.0)
{
    return a * x * x + b * x + c;
}
double Wynik = QuadraticEquation();
Console.WriteLine("WYNIK: " + Wynik);

//zad 2
void Swap(ref double a,ref double b)
{
    double temp = a;
    a = b;
    b = temp;
}
double x = 10;
double y = 20;
Swap(ref x, ref y);
Console.WriteLine($"x = {x}, y = {y}");

//zad3

static double Multiply(double a, double b)
{
    return a * b;
}
static double Multiply(double a, double b, double c)
{
    return a * b * c;
}
static double Multiply(params double[] a)
{
    double result = 1.0;
    foreach (double x in a)
    {
        result *= x;
    }
    return result;
}

//zad4

 static void PrintDayOfTheWeek(DayOfTheWeek day)

{
    Console.WriteLine(day);

    if ((int)day >= 7)
        Console.WriteLine("Weekend!");
    else
        Console.WriteLine("Work");
}
    enum DayOfTheWeek
{
    Monday = 1,
    Tuesday = 2,
    Wednesday = 3,
    Thursday = 4,
    Friday = 5,
    Saturday = 7,
    Sunday = 8,
}

//zad5
string itemName = "eggplant";
DateTime date = DateTime.Now;
decimal price = 1.99m;
Unit unit = Unit.item;
Console.WriteLine($"On {date.Year}, the price of {itemName} was {price} per {unit}.");

PrintDateTime(DateTime.Now);

static void PrintDateTime(DateTime date)
{
    string customDateString = $"{date.Day}...{date.Month}...{date.Year}...{date.Hour}:{date.Minute}:{date.Second}...{date.DayOfWeek}";
    Console.WriteLine(customDateString);
}

//zad6
double Divide(double a,double b)
{
    if (b == 0.0)
        throw new DivideByZeroException("b=0.0:(");
    return a / b;
}
double DivideSafe(double a, double b)
{
    double result;
    try
    {
        result = Divide(a, b);
    }
    catch (DivideByZeroException ex)
    {
        result = 0.0;
    }
    return result;
}

//zad7
