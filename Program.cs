﻿// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


// Задача 2. Напишите программу, которая на вход принимает два числа и выдаёт
// какое число больше, а какое меньше.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

System.Console.WriteLine("Задача 2");

System.Console.Write("Введите первое число: ");
string? strNumber1_1 = Console.ReadLine();         
int Number1_1 = Convert.ToInt32(strNumber1_1);

System.Console.Write("Введите второе число: ");
string? strNumber1_2 = Console.ReadLine();
int Number1_2 = Convert.ToInt32(strNumber1_2);

if (Number1_1 > Number1_2)
 {
    System.Console.WriteLine("max = " + Number1_1);
 }

else
 {
    System.Console.WriteLine("max = " + Number1_2);
 }

// Конец





// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт
// максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

System.Console.WriteLine("Задача 4");

System.Console.Write("Введите первое число: ");
string? strNumber2_1 = Console.ReadLine();
int Number2_1 = Convert.ToInt32(strNumber2_1);

System.Console.Write("Введите второе число: ");
string? strNumber2_2 = Console.ReadLine();
int Number2_2 = Convert.ToInt32(strNumber2_2);

System.Console.Write("Введите третье число: ");
string? strNumber2_3 = Console.ReadLine();
int Number2_3 = Convert.ToInt32(strNumber2_3);

int max = Number2_1;

if (Number2_2 > max) max = Number2_2;

if (Number2_3 > max) max = Number2_3;

Console.WriteLine("Максимальное число= " + max);

// Конец







// Задача 6: Напишите программу, которая на вход принимает число и выдаёт является
// ли число чётным.

// 4 -> да
// -3 -> нет
// 7 -> нет

System.Console.WriteLine("Задача 6");

System.Console.Write("Введите число: ");
string? strNumber3_1 = Console.ReadLine();
int Number3_1 = Convert.ToInt32(strNumber3_1);

  if (Number3_1 % 2 == 0)
  {
      System.Console.WriteLine("Да");
  }
  else
  {
      System.Console.WriteLine("Нет");
  }

// Конец





// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает
// все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

System.Console.WriteLine("Задача 8");

System.Console.Write("Введите число: ");
string? strNumber4_1 = Console.ReadLine();
int Number4_1 = Convert.ToInt32(strNumber4_1);

  if (Number4_1 <= 1)
  {
      System.Console.WriteLine("Решений нет");
      return;
  }

  else
  {
    int count = 2;

    while (count <= Number4_1)
    {
        System.Console.Write(count + ", ");
        count = count + 2;
    }
  }

System.Console.WriteLine();

// Конец


