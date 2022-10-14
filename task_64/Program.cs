// Задайте значения M и N. Напишите рекурсивный метод, который 
// выведет все натуральные числа кратные 3-ём в промежутке от M до N.

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Числа кратные 3-ём: ");

void Zadaha64(int n, int m)
{
    m++;
    if(m % 3 == 0)
        Console.Write(m + ", ");
    if(m >= n)
        return;
    Zadaha64(n, m);
}
Zadaha64(n, m);
