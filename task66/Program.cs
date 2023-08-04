// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int summa(int num1, int num2)
{
    if (num1==num2) 
    {
        return num1;
    }
    else 
    {
        return summa(num1,num2-1) + num2;
    }
}
Console.WriteLine("Введите первое число: ");
int first = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int second = Convert.ToInt32(Console.ReadLine());
if (first>second)
{
    Console.WriteLine(summa(second,first));
}
else
{
    Console.WriteLine(summa(first,second));
}
;