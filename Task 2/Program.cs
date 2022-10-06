// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
Console.Clear();

Console.Write(" Введите порядковый номер дня недели ");
int n = Convert.ToInt32(Console.ReadLine());

if (n==1 | n == 2 | n == 3 | n == 4 | n == 5)
    Console.WriteLine( "No( This day is weekday");
else 
    Console.WriteLine(" Yes! It is day off");