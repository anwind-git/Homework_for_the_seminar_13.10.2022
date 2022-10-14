// Задайте значения M и N. Напишите рекурсивный метод, который 
// найдёт сумму натуральных элементов в промежутке от M до N.

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

void Zadaha64(int n, int m, int summa = 0)
{
    summa = summa + m;
    m++;
    if(m > n)
    {
        Console.WriteLine();
        Console.WriteLine("Сумма натуральных элементов в промежутке от M до N = " + summa);
        Console.WriteLine();
        return;
    }
    Zadaha64(n, m, summa);
}
Zadaha64(n, m);
