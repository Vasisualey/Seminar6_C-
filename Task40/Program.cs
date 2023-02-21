// Напишите программу, которая принимает на вход
// три числа и проверяет, может ли существовать треугольник
// такой длины
// теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон
double a = Input();
double b = Input();
double c = Input();

if (CheckTriangle(a,b,c))
{
    Console.WriteLine("Такой треугольник существует");
}
else
{
    Console.WriteLine("Такой треугольник не существует");
}
bool CheckTriangle (double a, double b, double c)
{
    if((a<(b+c))&&(b<(a+c))&&(c<(a+b))) return true; else return false;
}

double Input()
{
    Console.Write("Введите длину стороны треугольника: ");
    double res = double.Parse(Console.ReadLine()!);
    return res;
}