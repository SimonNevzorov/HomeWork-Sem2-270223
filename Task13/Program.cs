// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6
Console.WriteLine("Введите число, содержащее не менее 3 цифр:");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100)
{
    Console.WriteLine("Третьей цифры нет, введите число, содержащее не менее 3 цифр!");
}
else 
{ 
Console.WriteLine($"Третья цифра числа = {number / 100 % 10}");

}