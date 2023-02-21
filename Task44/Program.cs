// Задача 44. Не используя рекурсию, выведите первые N чисел фибоначчи.
// Первые два числа Фибоначчи 0 и 1
Console.Clear();
int num = Input();
if(num>1)
{
    Console.WriteLine(Fibonacci(num));
}
else
{
    Console.WriteLine("Вы ввели неверное число.");
}
string Fibonacci(int num)
{
int[] arr = new int[num];
arr[1]=1;
for (int i = 2; i < num; i++)
{
    arr[i] =  arr[i-1] + arr[i-2];
} 
return string.Join(" ",arr);
}

int Input()
{
    int res;
    Console.Write("Введите число больше 2: ");
    res = int.Parse(Console.ReadLine()!); 
    return res;
}
