﻿// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8
// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98
// от Stanislav N для Все (10:40)
// 3)
// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно
// от Stanislav N для Все (10:40)

// int a = 13;
// int b = 5;
// if (a % b ==0)
// {
//     Console.WriteLine("кратно");
// }
// else
// {
//     Console.WriteLine($"остаток {a%b}");
//     }


// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
// 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да

// int a = 161;
// // int b = 5;
// if (a % 7 == 0 && a % 23 ==0)
// {
//     Console.WriteLine("кратно");
// }
// else
// {
//     Console.WriteLine("нет");
    // }


    
// от Stanislav N для Все (10:41)
// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

int a = new Random().Next(10, 100);
Console.WriteLine(a);

int result1 = a % 10;
int result2 = a/10;

int result3 = Math.Max(result1,result2);
Console.WriteLine(result3);




// int a = new Random().Next(100, 1000);
// Console.WriteLine(a);
// int b = (a/100) *10;
// int c = a % 10;

// Console.WriteLine(b + c);
// // Console.WriteLine(b);
// // Console.WriteLine(c);


