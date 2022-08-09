/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
Решить без использования строк.

645 -> 5

78 -> третьей цифры нет

32679 -> 6*/


int ThirdDigit(int num)
{
    
int count = 0;
int num1 = num;
while(num1>=10)
{
    num1 = num1/10;
    count++;
}
int degree = count-2;
int newNum = num; 
while (degree>0)
{
    newNum = newNum/10;
    degree = degree-1;
}
int thirdDigit = newNum%10;
    return thirdDigit;
}
Console.Write("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = ThirdDigit(number);
Console.WriteLine($"The third digit of number {number} is {result}");
