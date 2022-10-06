//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Clear();

Console.Write(" Введите трехзначное число ");
int n = Convert.ToInt32(Console.ReadLine());

/*int n = new Random().Next(100, 1000);
Console.WriteLine ($" Сгенерированное число: {n}");*/

int n1 = n / 100;
int n3 = n / 10;
int n2 = n%10;
if (n>99)
Console.WriteLine (n3 - n1*10);
else
Console.WriteLine ( "Введите трехзначное число");
