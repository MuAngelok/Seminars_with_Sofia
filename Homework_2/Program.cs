﻿// Знакомство с языками программирования (семинары)

// Урок 2. Базовые алгоритмы

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа. (Если решаете математически через рандом,
// то проверка не нужна на трехзначность. Если через строки, то она обязательна)
// 456 -> 5
// 782 -> 8
// 918 -> 1

// int num = new Random().Next(10, 1000);
// string NumStr = num.ToString();

// if (NumStr.Length == 3)
// {
//     Console.WriteLine($"Вторая цифра числа {num} имеет вид {NumStr[1]}");
// }
// else
// {
//     Console.WriteLine($"Число {num} не трехзначное");
// }

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет. (Если решаете математически максимум берем 100000)
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// int num = new Random().Next(10, 100000);
// string NumStr = num.ToString();

// if (NumStr.Length == 5)
// {
//     Console.WriteLine($"Третья цифра числа {NumStr} имеет вид {NumStr[2]}");
// }
// else
// {
//     Console.WriteLine($"Число {num} не трехзначное");
// }

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным. (Проверка выхода за пределы значений недели, т.е. < 1 и > 7)
// 6 -> да
// 7 -> да
// 1 -> нет

// Console.Write("Введите день недели: ");
// int number = int.Parse(Console.ReadLine()!);

// switch (number)
// {
//     case 6:
//         {
//             Console.WriteLine("Это суббота!");
//             break;
//         }
//     case 7:
//         {
//             Console.WriteLine("Это воскрксенье!");
//             break;
//         }
//     default:
//         {
//             Console.WriteLine("Это будний день!");
//             break;
//         }
// }