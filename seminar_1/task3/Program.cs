﻿// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).


Console.WriteLine("Input number");
int number_1 = Convert.ToInt32(Console.ReadLine());



if ((number_1 % 2) == 0)
    Console.WriteLine($"even");


else
    Console.WriteLine($"yteven");



