//Задача 42. Напишите программу, которая будет преобрпзовывать 
// десятичное число в двоичное.
Console.Clear();
int num = Input();
Console.WriteLine(DecimalToBinary(num));
string DecimalToBinary (int someNum)
{
    string str = "";
    do{
        str = Convert.ToString(someNum %2) + str;
        someNum= someNum / 2;
    } while (someNum != 0);
    return str;
}
int Input()
{
    Console.Write("Введите число: ");
    int res = int.Parse(Console.ReadLine()!);
    return res;
}
