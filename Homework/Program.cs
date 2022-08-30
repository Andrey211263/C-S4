// // ====Задача 25: 
// // Напишите цикл, который принимает на вход два числа (A и B) 
// // и возводит число A в натуральную степень B. 
// // Например: 3, 5 -> 243 (3⁵)
// //           2, 4 -> 16

// void Degree(int number1, int number2)
// {
//     double degree = Math.Pow(number1, number2);
 
//     Console.Write($"А^В = {degree}");
    
// }    

// Console.WriteLine("Введите число А: ");
// int numberA = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число В: ");
// int numberB = Convert.ToInt32(Console.ReadLine());

// Degree(numberA, numberB);


// // ====Задача 27: Напишите программу, которая принимает 
// // на вход число и выдаёт сумму цифр в числе.
// // Например:  452 -> 11
// //            82 -> 10
// //            9012 -> 12


// //метод для определения разрядности числа
// int Bit(int nmb)
// {
//     int temp = nmb;
//     int count = 0;
// for (; temp > 0; count++)
// {
//     temp = temp / 10;
// }
// return count;
// }


// //метод для сумирования цифр числа
// void Sum(int number, int count)
// {
//     int sum = 0;
//     int tmp = number;   
//     for(int i = 0; i < count; i++)
//     {
//         sum = sum + number%10;
//         number = number/10; 
//     }
    
//     Console.WriteLine($"Сумма цифр {tmp} = {sum}");
    
// }    

// // Тело программы
// Console.WriteLine("Введите число А: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int count = Bit(number);
// Sum(number, count);


//==== Задача 29: Напишите программу, которая задаёт массив из введенного числа и выводит их на экран.
// пользователь вводит число элементов в массиве и минимальное, и максимальное значение . надо 
// заполнить массив рандоными данными от минимального до максимального значение .И важное уточнениее, 
// делать все в методе который возвращает массив
// Например: 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//           6, 1, 33 -> [6, 1, 33]

//  int[] arr = new int[8];
//  for(int i = 0; i < 8; i++)
//  {
//      arr[i] = new Random().Next(0, 2);
//        Console.Write($" {arr[i]}");
//  }
// Console.WriteLine($"[{String.Join(", ", arr)}]");

Console.Write("Задайте длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите min число массива: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите max число массива: ");
int max = Convert.ToInt32(Console.ReadLine());

// создаем метод формирования массива

int[] Array(int length, int min, int max) 
{
    int[] array = new int[length];
    for(int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;

}
int[] mass = Array(length, min, max);
Console.WriteLine($"[{String.Join(", ", mass)}]");
Console.WriteLine();

// или организовать вывод более понятным способом
for(int i = 0; i < length; i++)
{
  Console.Write($" {mass[i]}");
}
  



