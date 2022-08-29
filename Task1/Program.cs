//==== Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// Console.WriteLine("Введите число А: ");
// int A = Convert.ToInt32(Console.ReadLine());
// int Sum = 0;

// for (int i = 1; i <= A; i++)
// {
//     Sum = Sum + i;
// }
// Console.WriteLine("Сумма = "+Sum);

// Решение от Роман Коробков
using System;
namespace Mynamespase
{
    class Myclass
    {
        public static void Main(string[] args)
        {
            // Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
           /* void Number(string? data)
            {
                int number;
                while(true)
                {
                    if(int.TryParse(data, out number))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка ввода");
                        data = Console.ReadLine();
                    }
                }
                int num = (int)Math.Log10(number) + 1;
                Console.WriteLine($"Здесь будет киличество цифр {num}");
            }*/
            

           


            Console.WriteLine("Введите число");
            // Number(Console.ReadLine());
        }
    }
}


//==== Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// //Вариант 1
// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int count = 0;
// while (number > 0)
// {
//     number /= 10;
//     count++;
// }
// Console.WriteLine(count);

// //Вариант 2
// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int count = (int)Math.Log10(number);
// Console.WriteLine(count+1);

//Решение Аднрея Борисова
//static void numberLength() 
//    {
        // Console.Write("Введите число:");
        // string number = Console.ReadLine();
        // Console.WriteLine($"{number} -> {number.Length}");
//    }

//==== Задача 28: 
// Напишите программу, которая принимает на вход число N
//и выдаёт произведение чисел от 1 до N.

// Console.Write("Введите число:");
// int data = Convert.ToInt32(Console.ReadLine());
// int result = 1;
// for(int i = 1; i <= data; i++ )
// {
//     result *=i;
    
//   }
//     Console.Write($"{data} -> {result}");


//==== Задача 30: Напишите программу, которая 
//выводит массив из 8 элементов, заполненный 
//нулями и единицами в случайном порядке.
//[1,0,1,1,0,1,0,0]

//  int[] arr = new int[8];
//  for(int i = 0; i < 8; i++)
//  {
//      arr[i] = new Random().Next(0, 2);
//        Console.Write($" {arr[i]}");
//  }
// Console.WriteLine($"[{String.Join(", ", arr)}]");



