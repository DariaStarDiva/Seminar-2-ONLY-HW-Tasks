// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// (Можно воспользоваться нумерацией строк, но необязательно)

Console.Clear();

Console.Write(" Введите число ");
int n = Convert.ToInt32(Console.ReadLine());

/*string TextN = Convert.ToString(n);

if (TextN.Length > 2)
{
Console.WriteLine(" Третья цифра " + TextN[2]);
Console.WriteLine(TextN.Length);
}
else 
Console.WriteLine(" Третьей цифры нет");*/


if (n<100)
    {
        Console.WriteLine(" Третьей цифры нет");    
    }
    else
 {
    for(n = n; n>=1000; n = n/10);
 
  Console.WriteLine (n = n%10);
}