/* 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/

Console.Write("Enter number from 1 to 7: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day<1 || day >7)
{
    Console.WriteLine("Invalid digit");
}
else
Console.WriteLine(day>5? "Yes": "No");




