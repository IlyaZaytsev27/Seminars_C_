// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.


Console.WriteLine("Input 1-st number");
int number_1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input 2-nd number");
int number_2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input 3-d number");
int number_3 = Convert.ToInt32(Console.ReadLine());

int max = number_1;


if (number_2 > max)
    max = number_2;

if (number_3 > max)
    max = number_3;

Console.WriteLine($"{max}: max");


