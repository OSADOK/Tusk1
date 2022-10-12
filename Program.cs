// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

/*Console.WriteLine("Введите первое число");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = int.Parse(Console.ReadLine());
if (num1 > num2)
{
    Console.WriteLine($"Наибольшее число: {num1}");
}
else
{
    Console.WriteLine($"Наибольшее число: {num2}");
}
*/
/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.WriteLine("Введите первое число");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число");
int num3 = int.Parse(Console.ReadLine());
if  (num1 > num2)
{
    if (num1 > num3)
    Console.WriteLine($"Наибольшее число: {num1}");
    else Console.WriteLine($"Наибольшее число: {num3}");
}
else
{
    if (num2 > num3)
    Console.WriteLine($"Наибольшее число: {num2}");
    Console.WriteLine($"Наибольшее число: {num3}");
}
*/
// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
/*
Console.WriteLine("Введите первое число");
int num1 = int.Parse(Console.ReadLine()); 
if (num1 % 2 == 0)
{
    Console.WriteLine("Да");
}
else
{
Console.WriteLine("Нет");
}
*/ 
// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());
int count = 1;
while (count <= N){
    if (count % 2 == 0)
    {
        
        Console.Write(count + ",");
    }
    count++;
}