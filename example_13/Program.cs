/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/
Console.Write("Введи число: ");
string numberStr = Console.ReadLine();
int number = Convert.ToInt32(numberStr);

if (number < 0) number *= -1;

if (number > 99) {
    while (number > 999) {
        number /= 10;
    }
    number %= 10;
    Console.WriteLine($"Третья цифра: {number}");
} else {
    Console.WriteLine("Третьей цифры нет");
}