// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии


Console.WriteLine("Введите значение N:");
int n = int.Parse(Console.ReadLine());

Console.WriteLine("Натуральные числа от N до 1:");
PrintNumbers(n);

Console.ReadLine();


static void PrintNumbers(int n)
{
    if (n <= 0)
        return;

    Console.WriteLine(n);
    PrintNumbers(n - 1);
}
