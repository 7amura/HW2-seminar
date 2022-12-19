// Задача 13: 
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int N1 = Convert.ToInt32(Console.ReadLine()!);
string numN1 = Convert.ToString(N1);

if(numN1.Length > 2)
{
    Console.WriteLine("Третья цифра -> " + numN1[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}