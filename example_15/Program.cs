/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет,
является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/

Console.Write("Введи день недели: ");
string numberdayStr = Console.ReadLine();
int numberday = Convert.ToInt32(numberdayStr);

if (numberday < 8 && numberday > 0) {
    if (numberday < 6) {
        Console.WriteLine("Нет");
    } else {
        Console.WriteLine("Да");
    }
} else {
    Console.WriteLine("Такого дня нет!");
}