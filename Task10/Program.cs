/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1*/

int SecondDigit (int num)
{
    int num1 = num / 10;
    int secondDigit = num1 % 10;
    return secondDigit;
}


Console.Write("Enter three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = SecondDigit(number);
Console.Write($"The second digit of number {number} is {result}");
