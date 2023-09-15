// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.


Console.WriteLine("Input 1-st number");
int number_1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input 2-nd number");
int number_2 = Convert.ToInt32(Console.ReadLine());

if (number_1 < number_2)
    Console.WriteLine($"{number_1}: min, {number_2}: max");

    else if (number_1 == number_2)
        Console.WriteLine($"your numbers are equal");

else 
    Console.WriteLine($"{number_2}: min, {number_1}: max");