/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/

Console.Write("Введи трёхзначное число: ");
string numberStr = Console.ReadLine();
int number = Convert.ToInt32(numberStr);
number = number < 0 ? number * -1 : number;

if (number > 99 && number < 1000) {
    int secondDigit = number / 10;
    secondDigit = secondDigit % 10;
    Console.WriteLine(secondDigit);
} else {
    Console.WriteLine("Это не трехначное число!");
}