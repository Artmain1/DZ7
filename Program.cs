/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6*/
Console.Write("Введи число: ");
string? number = Console.ReadLine();
if (number?.Length > 2)
{
    Console.WriteLine("Третья цифра в числе " + number[2]);
}
else
{
    Console.WriteLine("Нет третьей цифры");
}