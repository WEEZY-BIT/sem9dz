// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.


Console.WriteLine("Введите значение M:");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите значение N:");
int n = int.Parse(Console.ReadLine());

int sum = SumNaturalNumbers(m, n);
Console.WriteLine("Сумма натуральных чисел от M до N: " + sum);

Console.ReadLine();
    

    static int SumNaturalNumbers(int m, int n)
{
    int sum = 0;

    for (int i = m; i <= n; i++)
    {
        sum += i;
    }

    return sum;
    
}