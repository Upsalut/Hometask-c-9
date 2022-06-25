// Показать натуральные числа от M до N, N и M заданы
void NumbersFromMinToMax(int min, int max)
{
    if (max < min)
    {
        Console.WriteLine();
        return;
    }
    Console.Write(min + " ");
   NumbersFromMinToMax(min + 1, max);
}
Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine() ?? "0");
if (m <= 0 || n <= 0)
    Console.WriteLine("Введены не натуральные числа!");
else if (m > n)
{
    Console.WriteLine("Число M больше числа N, меняем их местами");
    int tmp = m; m = n; n = tmp;
    NumbersFromMinToMax(m, n);
}
else NumbersFromMinToMax(m, n);