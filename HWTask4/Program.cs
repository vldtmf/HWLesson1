﻿// написать программу по которой на вход принимается три числа, а на 
// выходе выдаётся максимальное из них
 Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число");
int c = int.Parse(Console.ReadLine());
int max = a;
if(a > max) max = a;
if(b > max) max = b;
if(c > max) max = c;
    Console.WriteLine($"Максимальное число {max}");
