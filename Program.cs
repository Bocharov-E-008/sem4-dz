// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4-> 16
// int ReadIntA(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }
// int ReadIntB(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }
// //------------------------
// int numA=ReadIntA("Введите число А ");
// int numB=ReadIntB("Введите число В ");
// int step = numA;

// for (int i = 1; i < numB; i++)
// {
//     step = step * numA;
// }
// Console.WriteLine("A в степени B равно: " + step);

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.WriteLine("введите число");
// int i = Convert.ToInt32(Console.ReadLine());
// int sum = 0;

// while (i > 0)
// {
//     int num = i % 10;
//     i = i / 10;
//     sum = sum + num;
// }
// Console.WriteLine("сумма всех цифр в числе равна: " + sum);

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33-> [6, 1, 33]

int[] numbers = new int[8];
Console.Write("[");

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = new Random().Next(0, 9);
    Console.Write(" " + Method(i) + " ");
}
Console.Write("]");

int Method(int a)
{
    return numbers[a];
}


//1. напишите программу которая принимает число А и выдает сумму чисел от 1 до А
// System.Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int sum=0;
// for(int i=1; i<=number; i++)
// {
//     sum= sum+ i;
// }
// System.Console.WriteLine($"Сумма чисел от 1 до {number}: {sum}" );
// через функцию_______________________________

// int ReadInt(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }
// int SumNumbers(int A)
// {
//    int sum=0; 
//    for(int i = 1; i<=A; i++)
//     {
//     sum += i;
//     }

//     return sum;
// }
// //-----------------------------
// int number= ReadInt("Введите число: ");
// int sum = SumNumbers(number);

// System.Console.WriteLine($"Сумма чисел от 1 до {number}: {sum}" );