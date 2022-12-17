// Задача 4: Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число ");
 int max = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число ");
 int number1 = Convert.ToInt32(Console.ReadLine());

 Console.WriteLine("Введите третье число ");
 int number2 = Convert.ToInt32(Console.ReadLine());

 if (max < number1)
 max = number1;

 else if (max < number2)
 max = number2;
Console.WriteLine($"Максимальное число {max}");